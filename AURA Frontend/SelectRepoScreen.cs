using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AURA_Frontend
{
    public partial class SelectRepoScreen : UserControl
    {
        public event EventHandler<EventArgs<Repository>> RepoSelected;
        public event EventHandler CloneRepositoryRequested;

        private CancellationTokenSource m_Cts;

        public SelectRepoScreen()
        {
            InitializeComponent();
            reposTable.RepoSelected += reposTable_RepoSelected;

            // Optional: show progress/errors from connector
            BackendConnector.Instance.CloneProgressChanged += backend_CloneProgressChanged;
            BackendConnector.Instance.CloneCompleted += backend_CloneCompleted;
            BackendConnector.Instance.ErrorOccurred += backend_ErrorOccurred;
        }

        private void reposTable_RepoSelected(object? sender, EventArgs<Repository> e) => OnRepoSelected(e);
        protected virtual void OnRepoSelected(EventArgs<Repository> e) => RepoSelected?.Invoke(this, e);
        protected virtual void OnCloneRepositoryRequested() => CloneRepositoryRequested?.Invoke(this, EventArgs.Empty);

        private async void cloneRepositoryButton_Click(object sender, EventArgs e)
        {
            OnCloneRepositoryRequested();
            addReposToScreen(); //for testing
            //await cloneRepository();
        }

        private async Task cloneRepository()
        {
            try
            {
                cloneRepositoryButton.Enabled = false;
                cancelPreviousRequests();

                // TODO: get URL from a textbox or dialog
                string repoUrl = "https://example.com/repo.git";

                Repository repo = await BackendConnector.Instance.CloneRepositoryAsync(repoUrl, m_Cts.Token);
                if (repo != null)
                    reposTable.AddItem(repo);

                centerButtonToGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Clone failed:\n{ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cloneRepositoryButton.Enabled = true;
            }
        }

        private void cancelPreviousRequests()
        {
            m_Cts?.Cancel();
            m_Cts = new CancellationTokenSource();
        }

        private void backend_CloneProgressChanged(int percent)
        {
            // If you have a ProgressBar on the screen, update it here
            // progressBar1.Value = percent;
        }

        private void backend_CloneCompleted(Repository repo)
        {
            // Optional toast/status
            // statusLabel.Text = $"Clone completed: {repo?.Name}";
        }

        private void backend_ErrorOccurred(string message)
        {
            // Optional central error surface
        }

        //Testing Only
        private void addReposToScreen()
        {
            reposTable.AddItem(new Repository
            {
                Name = "Pong Game 2",
                Status = RepoStatus.eStatus.Done,
                Description = "The better version of Pong",
                Version = "1.3"
            });
            reposTable.AddItem(new Repository { Name = "Grand Theft Auto VII", Status = RepoStatus.eStatus.Running });
            reposTable.AddItem(new Repository { Name = "Concord", Status = RepoStatus.eStatus.Error });
            reposTable.AddItem(new Repository { Name = "Very Awesome Project", Status = RepoStatus.eStatus.Done });
        }

        private void centerPanel()
        {
            int x = (ClientSize.Width - panel1.Width) / 2;
            int y = panel1.Location.Y;
            panel1.Location = new Point(x, y);
        }

        private void centerButtonToGrid()
        {
            int buttonX = reposTable.Left + (reposTable.Width - cloneRepositoryButton.Width) / 2;
            cloneRepositoryButton.Location = new Point(buttonX, cloneRepositoryButton.Location.Y);
        }

        protected override void OnLoad(EventArgs e) { base.OnLoad(e); centerPanel(); }
        protected override void OnResize(EventArgs e) { base.OnResize(e); centerPanel(); }
    }
}
