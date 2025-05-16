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
            reposTable1 = new ReposTable();
            button1 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // reposTable1
            // 
            reposTable1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            reposTable1.Location = new Point(0, 0);
            reposTable1.Margin = new Padding(11, 13, 11, 13);
            reposTable1.MaximumSize = new Size(464, 0);
            reposTable1.MinimumSize = new Size(0, 431);
            reposTable1.Name = "reposTable1";
            reposTable1.Size = new Size(433, 543);
            reposTable1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(145, 660);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(139, 49);
            button1.TabIndex = 5;
            button1.Text = "Add Repo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.Controls.Add(reposTable1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(444, 118);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 709);
            panel1.TabIndex = 6;
            // 
            // SelectRepoScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "SelectRepoScreen";
            Size = new Size(1393, 960);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ReposTable reposTable1;
        private Button button1;
        private Panel panel1;
    }
}
