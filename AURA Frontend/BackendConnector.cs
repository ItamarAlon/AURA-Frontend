using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA_Frontend
{
    public sealed class BackendConnector
    {
        private static BackendConnector s_Instance;
        private static readonly object key = new object();
        private BackendConnector() {}
        public static BackendConnector Instance
        {
            get
            {
                if (s_Instance == null)
                    lock (key)
                        if (s_Instance == null)
                            s_Instance = new BackendConnector();

                return s_Instance;
            }
        }

        public void RegisterRepoManagerScreen(RepoManagerScreen screen)
        {
            screen.StartRunningRequested += repoManagerScreen_StartRunningRequested;
            screen.ChatMessageSent += repoManagerScreen_ChatMessageSent;
        }

        public void RegisterRepoSelectScreen(SelectRepoScreen screen)
        {
            screen.CloneRepositoryRequested += selectRepoScreen_CloneRepositoryRequested;
        }

        private void selectRepoScreen_CloneRepositoryRequested(object? sender, EventArgs e)
        {
            askUserForRepositoryToClone();
        }


        private void repoManagerScreen_StartRunningRequested(object? sender, EventArgs<Repository> e)
        {
            startAURA((Repository)e);
        }

        private void repoManagerScreen_ChatMessageSent(object? sender, EventArgs<string> e)
        {
            sendRequestToLLM((string)e);
        }

        private void sendRequestToLLM(string message)
        {
            //todo: send a request to the llm
        }

        private void startAURA(Repository repository)
        {
            //todo: tell backend to start aura.
        }

        private void askUserForRepositoryToClone()
        {
            //todo: go to backend to ask user for repository.
        }
    }
}
