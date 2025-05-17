using System.Windows.Forms;

namespace AURA_Frontend
{
    using Screen = UserControl;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mainScreen.RepoSelected += reposTable_RepoSelected;
        }

        private void reposTable_RepoSelected(object sender, EventArgs<Repository> e)
        {
            Repository chosenRepo = e.Value;
            Screen repoScreen = RepoManagerScreenFactory.CreateScreen(chosenRepo);
            switchScreen(repoScreen);
        }

        private void switchScreen(Screen newScreen)
        {
            panel1.Controls.Clear();
            newScreen.Dock = DockStyle.Fill;

            if (newScreen is IHasGoBackOption canGoBackScreen)
                canGoBackScreen.GoToMainScreenRequested += canGoBackScreen_GoToMainScreenRequested;

            panel1.Controls.Add(newScreen);
        }

        private void canGoBackScreen_GoToMainScreenRequested(object sender, EventArgs e)
        {
            switchBackToMainScreen();
        }

        private void switchBackToMainScreen()
        {
            switchScreen(mainScreen);
        }
    }
}
