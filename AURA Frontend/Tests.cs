using MaterialSkin;
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
    public partial class Tests : Form
    {
        public Tests()
        {
            InitializeComponent();
            MaterialListBoxItem a = new MaterialListBoxItem();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            chatbox1.Visible = !chatbox1.Visible;
        }
    }
}
