using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AURA_Frontend.Repository;
using static AURA_Frontend.RepoStatus;

namespace AURA_Frontend
{
    public partial class ReposTable : UserControl
    {
        public event EventHandler<EventArgs<Repository>> RepoSelected;

        public ReposTable()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RowTemplate.Height = 30;
        }

        public Repository this[int index]
        {
            get => repositoryBindingSource?[index] as Repository;
        }

        public void AddItem(Repository item)
        {
            repositoryBindingSource.Add(item);
        }

        public void UpdateItemStatus(int index, eStatus newStatus)
        {
            if (index >= 0 && index < repositoryBindingSource.Count)
            {
                this[index].Status = newStatus;
                dataGridView1.InvalidateRow(index);
            }
        }

        public bool HasVerticalScrollBar()
        {
            return dataGridView1.DisplayedRowCount(true) < dataGridView1.RowCount;
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            drawDot(e);
        }

        private void drawDot(DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["State"].Index)
            {
                e.PaintBackground(e.ClipBounds, true);
                e.Handled = true;

                Color color = this[e.RowIndex].Status.Color;

                // Prevent duplicate controls
                var existing = dataGridView1.Controls
                    .OfType<DotIndicator>()
                    .FirstOrDefault(c => c.Tag as Point? == new Point(e.RowIndex, e.ColumnIndex));
                if (existing != null) return;
                
                DotIndicator dot = new DotIndicator
                {
                    DotColor = color,
                    Location = e.CellBounds.Location,
                    Size = e.CellBounds.Size,
                    Tag = new Point(e.RowIndex, e.ColumnIndex) // Prevent duplication
                };

                dataGridView1.Controls.Add(dot);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            openSelectedRepoManagerScreen(e);
        }

        private void openSelectedRepoManagerScreen(EventArgs e = null)
        {
            Repository clickedOnRepo = getClickedOnRepo(e as MouseEventArgs);

            if (clickedOnRepo != null)
            {
                NotifyThatRepoWasSelected(clickedOnRepo);
            }
        }

        private void NotifyThatRepoWasSelected(Repository clickedOnRepo)
        {
            OnRepoSelected(new EventArgs<Repository>(clickedOnRepo));
        }

        protected virtual void OnRepoSelected(EventArgs<Repository> e)
        {
            RepoSelected?.Invoke(this, e);
        }

        private Repository getClickedOnRepo(MouseEventArgs e)
        {
            DataGridViewRow clickedRow = GetClickedRow(e);

            if (clickedRow != null)
                return clickedRow.DataBoundItem as Repository;
            else
                return null;
        }

        private DataGridViewRow GetClickedRow(MouseEventArgs e)
        {
            if (e == null)
                return dataGridView1.CurrentRow;

            DataGridView.HitTestInfo hit = dataGridView1.HitTest(e.X, e.Y);

            if (hit.RowIndex >= 0)
            {
                return dataGridView1.Rows[hit.RowIndex];
            }

            return null;
        }

        private void dataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                openSelectedRepoManagerScreen();
        }
    }
}
