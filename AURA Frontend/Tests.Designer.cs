namespace AURA_Frontend
{
    partial class Tests
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
            chatbox1 = new Chatbox();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // chatbox1
            // 
            chatbox1.BackColor = Color.White;
            chatbox1.Location = new Point(333, 0);
            chatbox1.Margin = new Padding(4, 3, 4, 3);
            chatbox1.Name = "chatbox1";
            chatbox1.Size = new Size(274, 450);
            chatbox1.TabIndex = 1;
            chatbox1.Visible = false;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.Dock = DockStyle.Right;
            toolStrip1.Font = new Font("Segoe UI", 9F);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.ImeMode = ImeMode.Off;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(753, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(47, 450);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.ChatGPT_Black_Logo;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(45, 24);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(chatbox1);
            Name = "Form2";
            Text = "Form2";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Chatbox chatbox1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
    }
}