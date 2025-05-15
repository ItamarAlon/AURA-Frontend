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
    public partial class ReposTable : UserControl
    {
        public ReposTable()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RowTemplate.Height = 30;
        }

        public void AddItem(StateDotItem item)
        {
            stateDotItemBindingSource.Add(item);
            dataGridView1.Height += dataGridView1.Rows.GetRowsHeight(DataGridViewElementStates.Visible)
                       + dataGridView1.ColumnHeadersHeight;
        }

        public void UpdateItemStatus(int index, string newStatus)
        {
            if (index >= 0 && index < stateDotItemBindingSource.Count)
            {
                (stateDotItemBindingSource[index] as StateDotItem).Status = newStatus;
                dataGridView1.InvalidateRow(index);
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < stateDotItemBindingSource.Count && e.ColumnIndex == dataGridView1.Columns["State"].Index)
            {
                e.PaintBackground(e.ClipBounds, true);
                e.Handled = true;

                string status = (stateDotItemBindingSource[e.RowIndex] as StateDotItem).Status;
                Color dotColor = Color.Gray;

                switch (status)
                {
                    case "Done": dotColor = Color.Green; break;
                    case "Error": dotColor = Color.Red; break;
                    case "Warning": dotColor = Color.Orange; break;
                }

                int diameter = 14;
                int x = e.CellBounds.Left + (e.CellBounds.Width - diameter) / 2;
                int y = e.CellBounds.Top + (e.CellBounds.Height - diameter) / 2;

                using (SolidBrush brush = new SolidBrush(dotColor))
                {
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    e.Graphics.FillEllipse(brush, x, y, diameter, diameter);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }

    public class StateDotItem
    {
        public string Name { get; set; }
        public string Status { get; set; } // "Done", "Error", etc.
    }
}
