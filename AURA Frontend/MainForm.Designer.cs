namespace AURA_Frontend
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            mainScreen = new SelectRepoScreen();
            menuStrip1 = new MenuStrip();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            llmMenuItem = new ToolStripMenuItem();
            chatgptMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(mainScreen);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 40);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1649, 1280);
            panel1.TabIndex = 0;
            // 
            // mainScreen
            // 
            mainScreen.Dock = DockStyle.Fill;
            mainScreen.Location = new Point(0, 0);
            mainScreen.Margin = new Padding(2, 2, 2, 2);
            mainScreen.Name = "mainScreen";
            mainScreen.Size = new Size(1649, 1280);
            mainScreen.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, llmMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 2, 0, 2);
            menuStrip1.Size = new Size(1649, 40);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(120, 36);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // llmMenuItem
            // 
            llmMenuItem.Alignment = ToolStripItemAlignment.Right;
            llmMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chatgptMenuItem });
            llmMenuItem.Name = "llmMenuItem";
            llmMenuItem.Size = new Size(78, 36);
            llmMenuItem.Text = "LLM";
            // 
            // chatgptMenuItem
            // 
            chatgptMenuItem.Image = Properties.Resources.ChatGPT_Black_Logo;
            chatgptMenuItem.Name = "chatgptMenuItem";
            chatgptMenuItem.Size = new Size(234, 44);
            chatgptMenuItem.Text = "chatGPT";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1649, 1320);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "A.U.R.A";
            panel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private SelectRepoScreen mainScreen;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem llmMenuItem;
        private ToolStripMenuItem chatgptMenuItem;
    }
}
