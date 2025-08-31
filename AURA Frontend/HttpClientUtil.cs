// Ensure the first access to Instance happens on the UI thread if you want UI context captured.
//
// Usage:
//   // 1) Edit Options below (BaseAddress, Timeout, etc.)
//   // 2) Call anywhere:
//   await HttpClientUtil.Instance.RunAsyncJson(
//       "auth/github/validate", HttpRequestType.POST,
//       $"{\"token\":\"{txtGitHubToken.Text}\"}",
//       res => {
//           var text = res.Content.ReadAsStringAsync().GetAwaiter().GetResult();
//           var dto = System.Text.Json.JsonSerializer.Deserialize<ValidateTokenResponse>(text,
//               new System.Text.Json.JsonSerializerOptions{ PropertyNameCaseInsensitive = true });
//           HttpClientUtil.Instance.RunOnUi(() => lblStatus.Text = (dto?.Valid == true)
//               ? $"✓ Connected as {dto.Login}"
//               : $"✗ {dto?.Error ?? "Invalid token"}");
//       },
//       activateOnError: () => HttpClientUtil.Instance.RunOnUi(() => lblStatus.Text = "✗ Request failed"));

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public enum HttpRequestType { GET, POST, PUT, DELETE }

public sealed class HttpClientUtil : IDisposable
{
    // ───────────── Options you can edit ─────────────
    public static class Options
    {
        // Strings can be const; complex types use static readonly
        public const string BaseAddress = "http://localhost:5000/"; // Edit me
        public static readonly TimeSpan Timeout = TimeSpan.FromSeconds(12); // Edit me
        public const bool AllowInsecureDevCertificates = false;            // DEV only
        public const string? BearerToken = null;                            // Optional
        public static readonly Dictionary<string, string>? DefaultHeaders = null; // Optional
    }

    // ───────────── Singleton ─────────────
    private static HttpClientUtil s_Instance;
    public static HttpClientUtil Instance
    {
        get
        {
            if (s_Instance == null)
                throw new Exception("HttpClientUtil is not initialized yet. Recommended initializing on UI Thread");

            return s_Instance;
        }
    }

    private readonly HttpClient m_Http;
    private readonly CancellationTokenSource m_Cts = new CancellationTokenSource();
    private readonly SynchronizationContext? m_UiCtx; // captured at construction
    private bool m_Disposed;

    // --- ctor activates setup based on Options ---
    private HttpClientUtil()
    {
        m_UiCtx = SynchronizationContext.Current; // capture UI ctx if constructed on UI thread

        var handler = new HttpClientHandler();
        if (Options.AllowInsecureDevCertificates)
        {
            handler.ServerCertificateCustomValidationCallback = (msg, cert, chain, errors) => true; // DEV ONLY
        }

        m_Http = new HttpClient(handler)
        {
            Timeout = Options.Timeout
        };

        if (!string.IsNullOrWhiteSpace(Options.BaseAddress))
        {
            m_Http.BaseAddress = new Uri(Options.BaseAddress);
        }
        if (!string.IsNullOrWhiteSpace(Options.BearerToken))
        {
            m_Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Options.BearerToken);
        }
        if (Options.DefaultHeaders is not null)
        {
            foreach (var kv in Options.DefaultHeaders)
            {
                m_Http.DefaultRequestHeaders.Remove(kv.Key);
                m_Http.DefaultRequestHeaders.TryAddWithoutValidation(kv.Key, kv.Value);
            }
        }
    }

    public static void InitializeInstance()
    {
        s_Instance = new HttpClientUtil();
    }
    // --- finalizer shuts things down if you forgot Dispose() ---
    ~HttpClientUtil() { Dispose(false); }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    private void Dispose(bool disposing)
    {
        if (m_Disposed) return;
        m_Disposed = true;
        try { m_Cts.Cancel(); } catch { /* ignore */ }
        if (disposing)
        {
            m_Http.Dispose();
            m_Cts.Dispose();
        }
    }

    // WinForms equivalent to Platform.runLater
    public void RunOnUi(Action i_action)
    {
        var ctx = m_UiCtx ?? SynchronizationContext.Current;
        if (ctx is null) { i_action(); return; }
        ctx.Post(_ => i_action(), null);
    }

    // ───────────── Java-style overloads (INSTANCE methods) ─────────────

    // RunAsync(url, method, response -> { ... })
    public Task RunAsync(string i_url, HttpRequestType i_method, Action<HttpResponseMessage> i_activateWhenOk,
                         Action? i_activateOnError = null, CancellationToken i_ct = default)
    {
        var req = new HttpRequestMessage(ToMethod(i_method), i_url);
        return RunAsync(req, i_activateWhenOk, i_activateOnError, i_ct);
    }

    // RunAsync(url, response -> { ... }, onError) using GET by default
    public Task RunAsync(string i_url, Action<HttpResponseMessage> i_activateWhenOk, Action? i_activateOnError = null, CancellationToken i_ct = default)
    {
        var req = new HttpRequestMessage(HttpMethod.Get, i_url);
        return RunAsync(req, i_activateWhenOk, i_activateOnError, i_ct);
    }

    // RunAsync(request, response -> { ... }, onError)
    public async Task RunAsync(HttpRequestMessage i_request, Action<HttpResponseMessage> i_activateWhenOk, Action? i_activateOnError = null, CancellationToken i_ct = default)
    {
        if (m_Disposed) { i_activateOnError?.Invoke(); return; }

        using var linkedCts = CancellationTokenSource.CreateLinkedTokenSource(m_Cts.Token, i_ct);

        HttpResponseMessage res;
        try
        {
            res = await m_Http.SendAsync(i_request, linkedCts.Token).ConfigureAwait(false);
        }
        catch
        {
            i_activateOnError?.Invoke();
            return;
        }

        if (res.IsSuccessStatusCode)
        {
            i_activateWhenOk(res);
        }
        else
        {
            i_activateOnError?.Invoke();
        }
    }

    // Convenience: JSON body overload
    public Task RunAsyncJson(string i_url, HttpRequestType i_method, string i_jsonBody,
                             Action<HttpResponseMessage> i_activateWhenOk, Action? i_activateOnError = null, CancellationToken i_ct = default)
    {
        var req = new HttpRequestMessage(ToMethod(i_method), i_url)
        {
            Content = new StringContent(i_jsonBody, Encoding.UTF8, "application/json")
        };
        return RunAsync(req, i_activateWhenOk, i_activateOnError, i_ct);
    }

    private static HttpMethod ToMethod(HttpRequestType i_method) => i_method switch
    {
        HttpRequestType.GET => HttpMethod.Get,
        HttpRequestType.POST => HttpMethod.Post,
        HttpRequestType.PUT => HttpMethod.Put,
        HttpRequestType.DELETE => HttpMethod.Delete,
        _ => HttpMethod.Get
    };
}

// Example DTO for typed parsing in your callbacks
public sealed class ValidateTokenResponse
{
    public bool Valid { get; set; }
    public string? Login { get; set; }
    public string? Error { get; set; }
}
