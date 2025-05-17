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
        public event Action<Repository> RepoSelected;

        public SelectRepoScreen()
        {
            InitializeComponent();
            reposTable.RepoSelected += (repo) => this.RepoSelected?.Invoke(repo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reposTable.AddItem(new Repository { Name = "Hello", Status = Repository.eStatus.Error });
            reposTable.AddItem(new Repository { Name = "World", Status = Repository.eStatus.Done });
            reposTable.AddItem(new Repository { Name = "How", Status = Repository.eStatus.Warning });
        }
    }
}
