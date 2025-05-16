using System.Windows.Forms;

namespace AURA_Frontend
{
    using Screen = UserControl;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void switchScreen(Screen newScreen)
        {
            panel1.Controls.Clear();
            newScreen.Dock = DockStyle.Fill;
            panel1.Controls.Add(newScreen);
        }

        private void switchBackToMainScreen()
        {
            switchScreen(mainScreen);
        }
    }
}
