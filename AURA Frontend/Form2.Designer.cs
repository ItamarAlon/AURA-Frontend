namespace AURA_Frontend
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            repoManagerScreen1 = new RepoManagerScreen();
            SuspendLayout();
            // 
            // repoManagerScreen1
            // 
            repoManagerScreen1.AutoSize = true;
            repoManagerScreen1.Dock = DockStyle.Fill;
            repoManagerScreen1.Location = new Point(0, 0);
            repoManagerScreen1.Margin = new Padding(2);
            repoManagerScreen1.Name = "repoManagerScreen1";
            repoManagerScreen1.Size = new Size(800, 450);
            repoManagerScreen1.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(repoManagerScreen1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RepoManagerScreen repoManagerScreen1;
    }
}