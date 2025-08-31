using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AURA_Frontend
{
    public partial class RepoManagerScreen : UserControl, IHasGoBackOption
    {
        public event EventHandler GoToMainScreenRequested;

        public event EventHandler<EventArgs<Repository>> StartRunningRequested;
        public event EventHandler<EventArgs<string>> ChatMessageSent;
        public Repository Repository { get; }

        private CancellationTokenSource m_Cts;

        public RepoManagerScreen()
        {
            InitializeComponent();
        }

        public RepoManagerScreen(Repository repository)
        {
            InitializeComponent();
            Repository = repository;
            bindRepositoryDataToScreen();
            chatbox.MessageSent += chatBox_MessageSent;

            toolStrip1.Renderer = new DarkModeToolStripRenderer();
        }

        private void bindRepositoryDataToScreen()
        {
            if (Repository == null) return;

            statusBar.Status = Repository.Status;
            repoNameLabel.Text = Repository.Name;
            lastModifiedLabel.Text = $"Last Modified: {Repository.LastModifiedTime.Date:dd/MM/yyyy}";
            versionLabel.Text = $"Version: {Repository.Version}";
            descriptionTextBox.Text = Repository.Description;

            if (Repository.Path == null)
            {
                tableLayoutPanel1.Controls.Remove(pathLabel);
                tableLayoutPanel1.Controls.Remove(tableSeperatorLabel);
            }
            else
            {
                pathLabel.Text = $"Path: {Repository.Path}";
            }
        }

        protected virtual void OnGoToMainScreenRequested(EventArgs e) => GoToMainScreenRequested?.Invoke(this, e);

        private void goBackButton_Click(object sender, EventArgs e) => OnGoToMainScreenRequested(e);

        private void toggleChatButton_Click(object sender, EventArgs e) => toggleChat();

        private void toggleChat() => chatbox.Visible = !chatbox.Visible;

        private void centerPanel()
        {
            int x = (ClientSize.Width - mainPanel.Width) / 2;
            int y = mainPanel.Location.Y;
            mainPanel.Location = new Point(x, y);
        }

        protected override void OnLoad(EventArgs e) { base.OnLoad(e); centerPanel(); }
        protected override void OnResize(EventArgs e) { base.OnResize(e); centerPanel(); }

        private async void runButton_Click(object sender, EventArgs e)
        {
            await startAuraAsync();
        }

        private async Task startAuraAsync()
        {
            Repository.Status = RepoStatus.eStatus.Running;
            statusBar.Status = RepoStatus.eStatus.Running;
            runButton.Enabled = false;

            StartRunningRequested?.Invoke(this, new EventArgs<Repository>(Repository));

            try
            {
                cancelPreviousRequests();
                await BackendConnector.Instance.StartAuraAsync(Repository, m_Cts.Token);
                // Optionally notify user via status strip/toast
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Failed to start AURA:\n{ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                runButton.Enabled = true;
                Repository.Status = RepoStatus.eStatus.Error;
                statusBar.Status = RepoStatus.eStatus.Error;
            }
        }

        private void cancelPreviousRequests()
        {
            m_Cts?.Cancel();
            m_Cts = new CancellationTokenSource();
        }

        private async void chatBox_MessageSent(object? sender, EventArgs<string> e)
        {
            OnChatMessageSent(e);
            await sendMessageAndPrintReply(e);
        }

        private async Task sendMessageAndPrintReply(EventArgs<string> e)
        {
            try
            {
                string reply = await BackendConnector.Instance.SendChatAsync(e.Value);

                // TODO: append reply to your chat UI instead of MessageBox
                MessageBox.Show(this, reply, "Assistant");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Chat failed:\n{ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void OnChatMessageSent(EventArgs<string> e)
        {
            ChatMessageSent?.Invoke(this, e);
        }

        ~RepoManagerScreen() { /* optional cleanup */ }
    }
}
