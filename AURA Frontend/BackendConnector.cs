using System;
using System.Diagnostics.Eventing.Reader;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

using static AURA_Frontend.ApiConstants;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace AURA_Frontend
{
    public sealed class BackendConnector
    {
        // ─────────── Singleton ───────────
        private static BackendConnector s_Instance;
        private static readonly object s_Key = new object();

        private BackendConnector() {}

        public static BackendConnector Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_Key)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new BackendConnector();
                        }
                    }
                }
                return s_Instance;
            }
        }

        // ─────────── Events (Observer) ───────────
        public event Action<int> CloneProgressChanged;          // 0..100
        public event Action<Repository> CloneCompleted;         // repo details at end
        public event Action<string> LogReceived;                 // logs/status lines
        public event Action<string> ChatChunkReceived;           // streaming chat text
        public event Action<string> ErrorOccurred;               // central error pipe

        private void onCloneProgressChanged(int percent) => CloneProgressChanged?.Invoke(percent);
        private void onCloneCompleted(Repository repo) => CloneCompleted?.Invoke(repo);
        private void onLogReceived(string text) => LogReceived?.Invoke(text);
        private void onChatChunkReceived(string text) => ChatChunkReceived?.Invoke(text);
        private void onErrorOccurred(string message) => ErrorOccurred?.Invoke(message);

        // ─────────── JSON options ───────────
        private static readonly JsonSerializerOptions sr_JsonSerializerOptions = new(JsonSerializerDefaults.Web)
        {
            PropertyNameCaseInsensitive = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };
        private static string Serialize<T>(T payload) =>
            JsonSerializer.Serialize(payload, sr_JsonSerializerOptions);

        // ─────────── Tiny helpers that wrap HttpClientUtil callbacks as Task<T> ───────────
        private Task<T> sendAsyncGet<T>(string url, CancellationToken ct = default)
        {
            var tcs = new TaskCompletionSource<T>();
            HttpClientUtil.Instance.RunAsync(
                url,
                HttpRequestType.GET,
                i_activateWhenOk: res =>
                {
                    try
                    {
                        string text = res.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                        var dto = JsonSerializer.Deserialize<T>(text, sr_JsonSerializerOptions);
                        tcs.TrySetResult(dto!);
                    }
                    catch (Exception ex) { tcs.TrySetException(ex); }
                },
                i_activateOnError: () => tcs.TrySetException(new HttpRequestException($"GET failed: {url}")),
                ct
            );
            return tcs.Task;
        }
        private Task<T> sendAsyncJson<T>(string url, HttpRequestType method, string jsonBody, CancellationToken ct = default)
        {
            var tcs = new TaskCompletionSource<T>();
            HttpClientUtil.Instance.RunAsyncJson(
                url, method, jsonBody,
                i_activateWhenOk: res =>
                {
                    try
                    {
                        string text = res.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                        var dto = JsonSerializer.Deserialize<T>(text, sr_JsonSerializerOptions);
                        tcs.TrySetResult(dto!);
                    }
                    catch (Exception ex) { tcs.TrySetException(ex); }
                },
                i_activateOnError: () => tcs.TrySetException(new HttpRequestException($"{method} failed: {url}")),
                i_ct: ct
            );
            return tcs.Task;
        }
        private Task<T> sendAsyncJson<T>(string url, HttpRequestType method, object json, CancellationToken ct = default)
        {
            return sendAsyncJson<T>(url, method, Serialize(json), ct);
        }

        private enum KeyType { GitHub, LLM}
        private string convertKeyTypeToUri(KeyType keyType) => keyType switch
        {
            KeyType.GitHub => Key.k_GetGithubKey,
            KeyType.LLM => Key.k_GetLLMKey,
            _ => throw new NotImplementedException()
        };

        // ─────────── DTOs from backend (adjust to your API) ───────────
        private interface IDto { }
        private sealed class ValidateTokenResponseDto : IDto
        {
            public bool GitHubValid { get; set; }
            public bool LLMValid { get; set; }
            public string? Login { get; set; }
            public string? Error { get; set; }
        }
        private sealed class RepoInfoDto : IDto
        {
            public string? Name { get; set; }
            public string? Description { get; set; }
            public string? Version { get; set; }
        }
        private sealed class KeyDto : IDto
        {
            public string? Key { get; set; }
        }

        // ─────────── Public API (Queries/Commands) ───────────

        public async Task<bool> VerifyKeysAsync(string githubKey, string llmKey, CancellationToken ct = default)
        {
            try
            {
                var body = new { github = githubKey, llm = llmKey };
                var dto = await sendAsyncJson<ValidateTokenResponseDto>(Key.k_ValidateKeys, HttpRequestType.POST, body, ct);
                onLogReceived($"GitHub key verification: {(dto?.GitHubValid == true ? "valid" : "invalid")}");

                if (llmKey == "_")
                    return dto?.GitHubValid == true;
                else if (githubKey == "_")
                    return dto?.LLMValid == true;
                else
                    return dto?.GitHubValid == true && dto?.LLMValid == true;
            }
            catch (Exception ex)
            {
                onErrorOccurred($"VerifyGithubKey failed: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> VerifyGithubKeyAsync(string githubKey, CancellationToken ct = default)
        {
            return await VerifyKeysAsync(githubKey, "_", ct);
        }

        public async Task<bool> VerifyLLMKeyAsync(string llmKey, CancellationToken ct = default)
        {
            return await VerifyKeysAsync("_", llmKey, ct);
        }


        public async Task StartAuraAsync(Repository repository, CancellationToken ct = default)
        {
            try
            {
                onLogReceived($"Starting AURA for repo '{repository?.Name}'...");
                var body = new { repo = repository?.Name };
                _ = await sendAsyncJson<object>(Aura.k_Start, HttpRequestType.POST, body, ct);
                onLogReceived("AURA started.");
            }
            catch (Exception ex)
            {
                onErrorOccurred($"StartAura failed: {ex.Message}");
                throw;
            }
        }

        public async Task<Repository> CloneRepositoryAsync(string repoUrl, CancellationToken ct = default)
        {
            try
            {
                onLogReceived($"Cloning repository from {repoUrl}...");
                var body = new { url = repoUrl };
                _ = await sendAsyncJson<object>(Repos.k_Clone, HttpRequestType.POST, body, ct);

                // Optional: poll progress or simulate until you wire real progress
                for (int p = 0; p <= 100; p += 10)
                {
                    ct.ThrowIfCancellationRequested();
                    onCloneProgressChanged(p);
                    await Task.Delay(120, ct);
                }

                // Fetch final info
                RepoInfoDto dto = await sendAsyncGet<RepoInfoDto>(Repos.k_Last, ct);

                Repository repo = new Repository
                {
                    Name = dto?.Name ?? "Repository",
                    Description = dto?.Description ?? "",
                    Version = dto?.Version ?? "1.0",
                    Status = RepoStatus.eStatus.Done,
                    LastModifiedTime = DateTime.Now
                };

                onCloneCompleted(repo);
                onLogReceived("Clone completed.");
                return repo;
            }
            catch (Exception ex)
            {
                onErrorOccurred($"CloneRepository failed: {ex.Message}");
                throw;
            }
        }

        public async Task<string> SendChatAsync(string message, CancellationToken ct = default)
        {
            try
            {
                // If/when your backend streams, raise ChatChunkReceived as chunks arrive.
                // For now, call the endpoint and return the final message (replace with your API).
                var body = new { message = message.Replace("\"", "\\\"")}; 
                string reply = await sendAsyncJson<string>(Chat.k_Send, HttpRequestType.POST, body, ct);

                // Optionally stream fake chunks for current UI
                foreach (var chunk in new[] { "Received. ", "Processing… ", "Done." })
                {
                    ct.ThrowIfCancellationRequested();
                    await Task.Delay(120, ct);
                    onChatChunkReceived(chunk);
                }

                return reply ?? string.Empty;
            }
            catch (Exception ex)
            {
                onErrorOccurred($"SendChat failed: {ex.Message}");
                throw;
            }
        }

        public async Task<string> GetGitHubKey(CancellationToken ct = default)
        {
            return await getKey(KeyType.GitHub, ct);
        }

        public async Task<string> GetLLMKey(CancellationToken ct = default)
        {
            return await getKey(KeyType.LLM, ct);
        }

        private async Task<string> getKey(KeyType keyType, CancellationToken ct)
        {
            string uri = convertKeyTypeToUri(keyType);

            try
            {
                KeyDto keyDto = await sendAsyncGet<KeyDto>(uri, ct);
                return keyDto.Key ?? string.Empty;
            }
            catch (Exception ex)
            {
                onErrorOccurred($"Key Request Failed: {ex.Message}");
                throw;
            }
        }
    }
}
