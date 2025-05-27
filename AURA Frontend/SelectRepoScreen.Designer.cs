namespace AURA_Frontend
{
    partial class SelectRepoScreen
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            reposTable = new ReposTable();
            button1 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // reposTable
            // 
            reposTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            reposTable.AutoSize = true;
            reposTable.Location = new Point(0, 0);
            reposTable.Margin = new Padding(6);
            reposTable.MaximumSize = new Size(250, 0);
            reposTable.MinimumSize = new Size(302, 202);
            reposTable.Name = "reposTable";
            reposTable.Size = new Size(302, 264);
            reposTable.TabIndex = 4;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(110, 285);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Add Repo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.AutoSize = true;
            panel1.Controls.Add(reposTable);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(187, 53);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 308);
            panel1.TabIndex = 6;
            // 
            // SelectRepoScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "SelectRepoScreen";
            Size = new Size(750, 426);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ReposTable reposTable;
        private Button button1;
        private Panel panel1;
    }
}
