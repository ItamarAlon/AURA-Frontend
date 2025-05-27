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

        public Repository Repository { get; }

        public RepoManagerScreen()
        {
            InitializeComponent();
        }

        public RepoManagerScreen(Repository i_Repository)
        {
            InitializeComponent();
            Repository = i_Repository;
            statusBar1.Status = Repository.Status;
        }

        protected virtual void OnGoToMainScreenRequested(EventArgs e)
        {
            GoToMainScreenRequested?.Invoke(this, e);
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            OnGoToMainScreenRequested(e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void runButton_Paint(object sender, PaintEventArgs e)
        {
        }

        private void statusBar1_Load(object sender, EventArgs e)
        {

        }

        ~RepoManagerScreen()
        {
            //MessageBox.Show("Screen Removed");
        }
    }
}
