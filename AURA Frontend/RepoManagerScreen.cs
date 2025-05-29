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

        private void toggleChatButton_Click(object sender, EventArgs e)
        {
            toggleChat();
        }

        private void toggleChat()
        {
            chatbox1.Visible = !chatbox1.Visible;
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

        }

        ~RepoManagerScreen()
        {
            //MessageBox.Show("Screen Removed");
        }
    }
}
