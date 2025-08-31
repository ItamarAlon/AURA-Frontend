using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA_Frontend
{
    public sealed class LoginData
    {
        public event EventHandler<EventArgs<string>> CheckGitHubKeyRequested;
        public event EventHandler<EventArgs<string>> CheckLLMKeyRequested;

        private static LoginData s_Instance;
        private static readonly object key = new object();
        private CancellationTokenSource m_Cts;

        public string GitHubKey { get; set; }
        public string LLMKey { get; set; }

        private LoginData()
        {
            HttpClientUtil.Instance.CaptureUiContextFromCurrentThread();
        }
        public static LoginData Instance
        {
            get
            {
                if (s_Instance == null)
                    lock (key)
                        if (s_Instance == null)
                            s_Instance = new LoginData();

                return s_Instance;
            }
        }

        public static bool IsStringAValidGitHubKey(string githubKey)
        {
            if (string.IsNullOrEmpty(githubKey))
                return false;

            //todo: check validility
            return true;
        }

        public static bool IsStringAValidLLMKey(string llmKey)
        {
            if (string.IsNullOrEmpty(llmKey))
                return false;

            //todo: check validility
            return true;
        }

        public async Task<bool> CheckIfAllKeysAreSet()
        {
            cancelPreviousRequests();
            try
            {
                string githubKey = await BackendConnector.Instance.GetGitHubKey(m_Cts.Token);
                string llmKey = await BackendConnector.Instance.GetLLMKey(m_Cts.Token);

                if (!string.IsNullOrEmpty(githubKey))
                    GitHubKey = githubKey;
                if (!string.IsNullOrEmpty(llmKey))
                    LLMKey = llmKey;

                return !string.IsNullOrEmpty(githubKey) && !string.IsNullOrEmpty(llmKey);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong! {ex.Message}");
                return false;
            }
        }

        private void OnCheckGitHubKeyRequested(EventArgs<string> e)
        {
            CheckGitHubKeyRequested?.Invoke(this, e);
        }

        private void OnCheckLLMKeyRequested(EventArgs<string> e)
        {
            CheckLLMKeyRequested?.Invoke(this, e);
        }

        private void cancelPreviousRequests()
        {
            m_Cts?.Cancel();
            m_Cts = new CancellationTokenSource();
        }
    }
}
