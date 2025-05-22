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
            enableDynamicParentMenuLabel(llmMenuItem);
        }

        private void reposTable_RepoSelected(object sender, EventArgs<Repository> e)
        {
            Repository chosenRepo = e.Value;
            switchToRepoScreen(chosenRepo);
        }

        private void switchToRepoScreen(Repository chosenRepo)
        {
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

        private void enableDynamicParentMenuLabel(ToolStripMenuItem parentItem)
        {
            foreach (ToolStripItem child in parentItem.DropDownItems)
            {
                if (child is ToolStripMenuItem childItem)
                {
                    childItem.Click += (sender, e) =>
                    {
                        ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;

                        // Update parent text and image
                        parentItem.Text = clickedItem.Text;
                        parentItem.Image = clickedItem.Image;
                    };
                }
            }
        }

    }
}
