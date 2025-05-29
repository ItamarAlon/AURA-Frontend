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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            assignEnteredKeysAndSwitchToWindow();
        }

        private void assignEnteredKeysAndSwitchToWindow()
        {
            if (assignEnteredKeys())
            {
                switchToMainWindow();
            }
            else
            {
                MessageBox.Show("Not all entered keys are valid");
            }
        }

        private void switchToMainWindow()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool assignEnteredKeys()
        {
            string? githubKey = githubTextBox.Text;
            string? llmKey = llmTextBox.Text;

            if (!LoginData.IsStringAValidGitHubKey(githubKey) || 
                !LoginData.IsStringAValidLLMKey(llmKey))
                return false;

            LoginData.Instance.GitHubKey = githubKey;            
            LoginData.Instance.LLMKey = llmKey;
            
            return true;
        }
    }
}
