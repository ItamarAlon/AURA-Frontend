namespace AURA_Frontend
{
    partial class RepoManagerScreen
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
            goBackButton = new Button();
            chatbox1 = new Chatbox();
            statusBar1 = new StatusBar();
            SuspendLayout();
            // 
            // goBackButton
            // 
            goBackButton.Location = new Point(2, 2);
            goBackButton.Margin = new Padding(2);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(92, 29);
            goBackButton.TabIndex = 3;
            goBackButton.Text = "Go Back";
            goBackButton.UseVisualStyleBackColor = true;
            goBackButton.Click += goBackButton_Click;
            // 
            // chatbox1
            // 
            chatbox1.BackColor = Color.White;
            chatbox1.Location = new Point(175, 13);
            chatbox1.Margin = new Padding(4, 4, 4, 4);
            chatbox1.Name = "chatbox1";
            chatbox1.Size = new Size(447, 420);
            chatbox1.TabIndex = 4;
            // 
            // statusBar1
            // 
            statusBar1.Location = new Point(691, 128);
            statusBar1.Name = "statusBar1";
            statusBar1.Size = new Size(91, 29);
            statusBar1.Status = null;
            statusBar1.TabIndex = 5;
            // 
            // RepoManagerScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(statusBar1);
            Controls.Add(chatbox1);
            Controls.Add(goBackButton);
            Margin = new Padding(2);
            Name = "RepoManagerScreen";
            Size = new Size(857, 600);
            ResumeLayout(false);
        }

        #endregion
        private Button goBackButton;
        private Chatbox chatbox1;
        private StatusBar statusBar1;
    }
}
