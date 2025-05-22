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
            reposTable.AddItem(new Repository { Name = "Hello", Status = RepoStatus.eStatus.Error });
            reposTable.AddItem(new Repository { Name = "World", Status = RepoStatus.eStatus.Done });
            reposTable.AddItem(new Repository { Name = "How", Status = RepoStatus.eStatus.Warning });
        }
    }
}
