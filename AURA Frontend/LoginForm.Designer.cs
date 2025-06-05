namespace AURA_Frontend
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            githubTextBox = new TextBox();
            llmTextBox = new TextBox();
            label2 = new Label();
            ContinueButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 115);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter LLM Key:";
            // 
            // githubTextBox
            // 
            githubTextBox.Location = new Point(154, 64);
            githubTextBox.Name = "githubTextBox";
            githubTextBox.Size = new Size(322, 27);
            githubTextBox.TabIndex = 1;
            // 
            // llmTextBox
            // 
            llmTextBox.Location = new Point(154, 112);
            llmTextBox.Name = "llmTextBox";
            llmTextBox.Size = new Size(322, 27);
            llmTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 67);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 3;
            label2.Text = "Enter GitHub Key:";
            // 
            // ContinueButton
            // 
            ContinueButton.Location = new Point(128, 204);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new Size(213, 29);
            ContinueButton.TabIndex = 4;
            ContinueButton.Text = "Continue To A.U.R.A";
            ContinueButton.UseVisualStyleBackColor = true;
            ContinueButton.Click += ContinueButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 311);
            Controls.Add(ContinueButton);
            Controls.Add(label2);
            Controls.Add(llmTextBox);
            Controls.Add(githubTextBox);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox githubTextBox;
        private TextBox llmTextBox;
        private Label label2;
        private Button ContinueButton;
    }
}