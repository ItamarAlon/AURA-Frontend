namespace AURA_Frontend
{
    partial class StatusBar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dotIndicator1 = new DotIndicator();
            statusLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dotIndicator1
            // 
            dotIndicator1.BackColor = Color.Transparent;
            dotIndicator1.Diameter = 14;
            dotIndicator1.Dock = DockStyle.Right;
            dotIndicator1.DotColor = Color.Gray;
            dotIndicator1.Location = new Point(0, 0);
            dotIndicator1.Margin = new Padding(0);
            dotIndicator1.Name = "dotIndicator1";
            dotIndicator1.Size = new Size(17, 60);
            dotIndicator1.TabIndex = 0;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Dock = DockStyle.Left;
            statusLabel.Location = new Point(17, 0);
            statusLabel.Margin = new Padding(0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(38, 60);
            statusLabel.TabIndex = 1;
            statusLabel.Text = "status";
            statusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AllowDrop = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(statusLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(dotIndicator1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RightToLeft = RightToLeft.No;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(212, 60);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // StatusBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StatusBar";
            Size = new Size(212, 60);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DotIndicator dotIndicator1;
        private Label statusLabel;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
