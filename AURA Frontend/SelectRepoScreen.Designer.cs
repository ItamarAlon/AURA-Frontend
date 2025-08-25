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
            components = new System.ComponentModel.Container();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            reposTable = new ReposTable();
            cloneRepositoryButton = new Button();
            panel1 = new Panel();
            repositoryBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)repositoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // reposTable
            // 
            reposTable.AutoSize = true;
            reposTable.Location = new Point(22, 0);
            reposTable.Margin = new Padding(11, 13, 11, 13);
            reposTable.MaximumSize = new Size(600, 0);
            reposTable.MinimumSize = new Size(0, 431);
            reposTable.Name = "reposTable";
            reposTable.Size = new Size(286, 431);
            reposTable.TabIndex = 4;
            // 
            // cloneRepositoryButton
            // 
            cloneRepositoryButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cloneRepositoryButton.BackColor = Color.FromArgb(43, 45, 48);
            cloneRepositoryButton.FlatAppearance.BorderColor = Color.FromArgb(78, 81, 87);
            cloneRepositoryButton.FlatStyle = FlatStyle.Flat;
            cloneRepositoryButton.ForeColor = Color.White;
            cloneRepositoryButton.Location = new Point(87, 608);
            cloneRepositoryButton.Margin = new Padding(7, 6, 7, 6);
            cloneRepositoryButton.Name = "cloneRepositoryButton";
            cloneRepositoryButton.Size = new Size(214, 49);
            cloneRepositoryButton.TabIndex = 5;
            cloneRepositoryButton.Text = "Clone Repository";
            cloneRepositoryButton.UseVisualStyleBackColor = false;
            cloneRepositoryButton.Click += cloneRepositoryButton_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(reposTable);
            panel1.Controls.Add(cloneRepositoryButton);
            panel1.Location = new Point(479, 111);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 657);
            panel1.TabIndex = 6;
            // 
            // repositoryBindingSource
            // 
            repositoryBindingSource.DataSource = typeof(Repository);
            // 
            // SelectRepoScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 31, 34);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "SelectRepoScreen";
            Size = new Size(1393, 909);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)repositoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ReposTable reposTable;
        private Button cloneRepositoryButton;
        private Panel panel1;
        private BindingSource repositoryBindingSource;
    }
}
