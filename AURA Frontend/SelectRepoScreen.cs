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
    public partial class SelectRepoScreen : UserControl
    {
        public event EventHandler<EventArgs<Repository>> RepoSelected;
        public event EventHandler CloneRepositoryRequested;

        public SelectRepoScreen()
        {
            InitializeComponent();
            reposTable.RepoSelected += (o, e) => this.RepoSelected?.Invoke(o, e);
            BackendConnector.Instance.RegisterRepoSelectScreen(this);
        }

        protected virtual void OnRepoSelected(EventArgs<Repository> e)
        {
            RepoSelected?.Invoke(this, e);
        }

        private void cloneRepositoryButton_Click(object sender, EventArgs e)
        {
            addReposToTable(); //For Testing
            OnCloneRepositoryRequested(new EventArgs());
            centerButtonToGrid();
        }

        private void addReposToTable()
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

        protected virtual void OnCloneRepositoryRequested(EventArgs e)
        {
            CloneRepositoryRequested?.Invoke(this, e);
        }

        private void centerPanel()
        {
            int x = (this.ClientSize.Width - panel1.Width) / 2;
            //int x = panel1.Location.X;
            //int y = (this.ClientSize.Height - panel1.Height) / 2;
            int y = panel1.Location.Y;
            panel1.Location = new Point(x, y);
        }

        private void centerButtonToGrid()
        {
            int buttonX = reposTable.Left + (reposTable.Width - cloneRepositoryButton.Width) / 2;
            cloneRepositoryButton.Location = new Point(buttonX, cloneRepositoryButton.Location.Y);
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

    }
}
