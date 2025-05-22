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
    public partial class DotIndicator : UserControl
    {
        private Color m_dotColor = Color.Gray;
        private int m_diameter = 14;

        public DotIndicator()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Size = new Size(20, 20);
        }

        [Category("Appearance")]
        public Color DotColor
        {
            get { return m_dotColor; }
            set { m_dotColor = value; Invalidate(); }
        }

        [Category("Layout")]
        public int Diameter
        {
            get { return m_diameter; }
            set { m_diameter = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            drawDot(e);
        }

        private void drawDot(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int x = (this.Width - m_diameter) / 2;
            int y = (this.Height - m_diameter) / 2;

            using (SolidBrush brush = new SolidBrush(m_dotColor))
            {
                e.Graphics.FillEllipse(brush, x, y, m_diameter, m_diameter);
            }
        }
    }
}
