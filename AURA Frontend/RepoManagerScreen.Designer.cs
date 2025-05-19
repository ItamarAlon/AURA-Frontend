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
            SuspendLayout();
            // 
            // goBackButton
            // 
            goBackButton.Location = new Point(3, 3);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(150, 46);
            goBackButton.TabIndex = 3;
            goBackButton.Text = "Go Back";
            goBackButton.UseVisualStyleBackColor = true;
            goBackButton.Click += goBackButton_Click;
            // 
            // chatbox1
            // 
            chatbox1.BackColor = Color.White;
            chatbox1.Location = new Point(284, 21);
            chatbox1.Margin = new Padding(7, 6, 7, 6);
            chatbox1.Name = "chatbox1";
            chatbox1.Size = new Size(727, 672);
            chatbox1.TabIndex = 4;
            // 
            // RepoManagerScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(chatbox1);
            Controls.Add(goBackButton);
            Name = "RepoManagerScreen";
            Size = new Size(3045, 1332);
            ResumeLayout(false);
        }

        #endregion
        private Button goBackButton;
        private Chatbox chatbox1;
    }
}
