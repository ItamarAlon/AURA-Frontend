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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(114, 325);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 32);
            label1.TabIndex = 0;
            label1.Text = "Enter LLM Key:";
            // 
            // githubTextBox
            // 
            githubTextBox.BackColor = Color.FromArgb(43, 45, 48);
            githubTextBox.BorderStyle = BorderStyle.FixedSingle;
            githubTextBox.ForeColor = Color.White;
            githubTextBox.Location = new Point(294, 248);
            githubTextBox.Margin = new Padding(5);
            githubTextBox.Name = "githubTextBox";
            githubTextBox.Size = new Size(521, 39);
            githubTextBox.TabIndex = 1;
            // 
            // llmTextBox
            // 
            llmTextBox.BackColor = Color.FromArgb(43, 45, 48);
            llmTextBox.BorderStyle = BorderStyle.FixedSingle;
            llmTextBox.ForeColor = Color.White;
            llmTextBox.Location = new Point(294, 325);
            llmTextBox.Margin = new Padding(5);
            llmTextBox.Name = "llmTextBox";
            llmTextBox.Size = new Size(521, 39);
            llmTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(83, 250);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(202, 32);
            label2.TabIndex = 3;
            label2.Text = "Enter GitHub Key:";
            // 
            // ContinueButton
            // 
            ContinueButton.BackColor = Color.FromArgb(43, 45, 48);
            ContinueButton.FlatAppearance.BorderColor = Color.FromArgb(78, 81, 87);
            ContinueButton.FlatStyle = FlatStyle.Flat;
            ContinueButton.ForeColor = Color.White;
            ContinueButton.Location = new Point(252, 452);
            ContinueButton.Margin = new Padding(5);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new Size(346, 46);
            ContinueButton.TabIndex = 4;
            ContinueButton.Text = "Continue To A.U.R.A";
            ContinueButton.UseVisualStyleBackColor = false;
            ContinueButton.Click += ContinueButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.AURA_White;
            pictureBox1.Location = new Point(252, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(406, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 31, 34);
            ClientSize = new Size(899, 596);
            Controls.Add(pictureBox1);
            Controls.Add(ContinueButton);
            Controls.Add(label2);
            Controls.Add(llmTextBox);
            Controls.Add(githubTextBox);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "LoginForm";
            Text = "A.U.R.A";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox githubTextBox;
        private TextBox llmTextBox;
        private Label label2;
        private Button ContinueButton;
        private PictureBox pictureBox1;
    }
}