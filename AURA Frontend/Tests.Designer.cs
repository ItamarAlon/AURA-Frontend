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
            chatbox2 = new Chatbox();
            roundedPanel1 = new RoundedPanel();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // chatbox2
            // 
            chatbox2.BackColor = Color.White;
            chatbox2.Dock = DockStyle.Fill;
            chatbox2.Location = new Point(0, 0);
            chatbox2.Margin = new Padding(4);
            chatbox2.Name = "chatbox2";
            chatbox2.Size = new Size(371, 508);
            chatbox2.TabIndex = 0;
            // 
            // roundedPanel1
            // 
            roundedPanel1.Controls.Add(chatbox2);
            roundedPanel1.CornerRadius = 1;
            roundedPanel1.Location = new Point(273, 43);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(371, 508);
            roundedPanel1.TabIndex = 1;
            // 
            // Tests
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(roundedPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Tests";
            Text = "Form2";
            roundedPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Chatbox chatbox1;
        private Chatbox chatbox2;
        private RoundedPanel roundedPanel1;
    }
}