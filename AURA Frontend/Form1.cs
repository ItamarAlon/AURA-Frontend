using System.Windows.Forms;

namespace AURA_Frontend
{
    using Screen = UserControl;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mainScreen.RepoSelected += reposTable1_RepoChosen;
        }

        private void reposTable1_RepoChosen(Repository repoChosen)
        {
            Screen repoScreen = new RepoManagerScreen(); //TODO: pass repoChosen to the repo manager screen
            switchScreen(repoScreen);
        }

        private void switchScreen(Screen newScreen)
        {
            panel1.Controls.Clear();
            newScreen.Dock = DockStyle.Fill;

            if (newScreen is IHasGoBackOption canGoBackScreen)
                canGoBackScreen.GoToMainScreenRequested += goBackButton_GoToMainScreenRequested;

            panel1.Controls.Add(newScreen);
        }

        private void goBackButton_GoToMainScreenRequested()
        {
            switchBackToMainScreen();
        }

        private void switchBackToMainScreen()
        {
            switchScreen(mainScreen);
        }
    }
}
