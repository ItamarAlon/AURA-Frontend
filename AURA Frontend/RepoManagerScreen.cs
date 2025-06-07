using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        public RepoManagerScreen()
        {
            InitializeComponent();
        }

        public RepoManagerScreen(Repository i_Repository)
        {
            InitializeComponent();
            Repository = i_Repository;
            bindRepositoryDataToScreen();
            chatbox.MessageSent += chatBox_MessageSent;
            BackendConnector.Instance.RegisterRepoManagerScreen(this);
            toolStrip1.Renderer = new DarkModeToolStripRenderer();
        }


        private void bindRepositoryDataToScreen()
        {
            if (Repository == null)
                return;

            statusBar.Status = Repository.Status;
            repoNameLabel.Text = Repository.Name;
            lastModifiedLabel.Text = $"Last Modified: {Repository.LastModifiedTime.Date.ToString("dd.MM.yyyy")}";
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

        protected virtual void OnGoToMainScreenRequested(EventArgs e)
        {
            GoToMainScreenRequested?.Invoke(this, e);
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            OnGoToMainScreenRequested(e);
        }

        private void toggleChatButton_Click(object sender, EventArgs e)
        {
            toggleChat();
        }

        private void toggleChat()
        {
            chatbox.Visible = !chatbox.Visible;
        }

        private void centerPanel()
        {
            int x = (this.ClientSize.Width - mainPanel.Width) / 2;
            //int x = panel1.Location.X;
            //int y = (this.ClientSize.Height - panel1.Height) / 2;
            int y = mainPanel.Location.Y;
            mainPanel.Location = new Point(x, y);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            centerPanel();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            centerPanel();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            notifyRunningWasRequestedAndChangeStatus();
        }

        private void notifyRunningWasRequestedAndChangeStatus()
        {
            Repository.Status = RepoStatus.eStatus.Running;
            statusBar.Status = RepoStatus.eStatus.Running;
            runButton.Enabled = false;
            OnStartRunningRequested(Repository);
        }

        protected virtual void OnStartRunningRequested(EventArgs<Repository> e)
        {
            StartRunningRequested?.Invoke(this, e);
        }

        private void chatBox_MessageSent(object? sender, EventArgs<string> e)
        {
            OnChatMessageSent(e);
        }

        protected virtual void OnChatMessageSent(EventArgs<string> e)
        {
            ChatMessageSent?.Invoke(this, e);
        }

        ~RepoManagerScreen()
        {
            //MessageBox.Show("Screen Removed");
        }
    }
}
