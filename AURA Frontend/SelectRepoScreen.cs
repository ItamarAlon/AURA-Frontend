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

        public SelectRepoScreen()
        {
            InitializeComponent();
            reposTable.RepoSelected += (o, e) => this.RepoSelected?.Invoke(o, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reposTable.AddItem(new Repository
            {
                Name = "Pong Game 2",
                Status = RepoStatus.eStatus.Done,
                Description =
                "The better version of Pong",
                Version = "1.3"
            });
            reposTable.AddItem(new Repository { Name = "Grand Theft Auto VII", Status = RepoStatus.eStatus.Running });
            reposTable.AddItem(new Repository { Name = "Concord", Status = RepoStatus.eStatus.Error });
            reposTable.AddItem(new Repository { Name = "Very Awesome Project", Status = RepoStatus.eStatus.Done });

            centerButtonToGrid();
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
            int buttonX = reposTable.Left + (reposTable.Width - button1.Width) / 2;
            button1.Location = new Point(buttonX, button1.Location.Y);
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
