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
        public event Action GoToMainScreenRequested;

        public Repository Repo { get; set; }

        public RepoManagerScreen()
        {
            InitializeComponent();
        }

        protected virtual void OnGoToMainScreenRequested()
        {
            GoToMainScreenRequested?.Invoke();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            OnGoToMainScreenRequested();
        }
    }
}
