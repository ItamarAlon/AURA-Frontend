using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA_Frontend
{
    public class RoundedPanel : Panel
    {
        public int CornerRadius { get; set; } = 200;
        public Color BorderColor { get; set; } = Color.Black;
        public int BorderThickness { get; set; } = 20;

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            using (GraphicsPath path = GetRoundedRectPath(this.ClientRectangle, CornerRadius))
            {
                this.Region = new Region(path);
            }
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (GraphicsPath path = GetRoundedRectPath(this.ClientRectangle, CornerRadius))
            using (Pen pen = new Pen(BorderColor, BorderThickness))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90); // top-left
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90); // top-right
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90); // bottom-right
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90); // bottom-left
            path.CloseFigure();

            return path;
        }
    }
}
