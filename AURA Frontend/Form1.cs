namespace AURA_Frontend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reposTable1.AddItem(new StateDotItem { Name = "Hello", Status = "Error" });
        }
    }
}
