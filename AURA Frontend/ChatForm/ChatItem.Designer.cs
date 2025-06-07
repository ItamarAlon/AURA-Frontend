
namespace AURA_Frontend
{
	partial class ChatItem
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
            authorPanel = new Panel();
            authorLabel = new Label();
            bodyPanel = new Panel();
            bodyTextBox = new TextBox();
            authorPanel.SuspendLayout();
            bodyPanel.SuspendLayout();
            SuspendLayout();
            // 
            // authorPanel
            // 
            authorPanel.Controls.Add(authorLabel);
            authorPanel.Dock = DockStyle.Bottom;
            authorPanel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            authorPanel.ForeColor = SystemColors.ButtonShadow;
            authorPanel.Location = new Point(22, 111);
            authorPanel.Margin = new Padding(7, 6, 7, 6);
            authorPanel.Name = "authorPanel";
            authorPanel.Padding = new Padding(0, 13, 0, 0);
            authorPanel.Size = new Size(1269, 64);
            authorPanel.TabIndex = 8;
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Dock = DockStyle.Left;
            authorLabel.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            authorLabel.Location = new Point(0, 13);
            authorLabel.Margin = new Padding(7, 0, 7, 0);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(215, 30);
            authorLabel.TabIndex = 0;
            authorLabel.Text = "System - 10/22/2020";
            // 
            // bodyPanel
            // 
            bodyPanel.BackColor = Color.RoyalBlue;
            bodyPanel.Controls.Add(bodyTextBox);
            bodyPanel.Dock = DockStyle.Left;
            bodyPanel.Location = new Point(22, 13);
            bodyPanel.Margin = new Padding(7, 6, 7, 6);
            bodyPanel.Name = "bodyPanel";
            bodyPanel.Padding = new Padding(4);
            bodyPanel.Size = new Size(787, 98);
            bodyPanel.TabIndex = 9;
            // 
            // bodyTextBox
            // 
            bodyTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bodyTextBox.BackColor = Color.RoyalBlue;
            bodyTextBox.BorderStyle = BorderStyle.None;
            bodyTextBox.Font = new Font("Segoe UI Emoji", 9F);
            bodyTextBox.ForeColor = Color.White;
            bodyTextBox.Location = new Point(11, 13);
            bodyTextBox.Margin = new Padding(7, 6, 7, 6);
            bodyTextBox.Multiline = true;
            bodyTextBox.Name = "bodyTextBox";
            bodyTextBox.ReadOnly = true;
            bodyTextBox.Size = new Size(765, 75);
            bodyTextBox.TabIndex = 4;
            bodyTextBox.Text = "Hello there. This is a test for the longer word usage.";
            // 
            // ChatItem
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 21, 26);
            Controls.Add(bodyPanel);
            Controls.Add(authorPanel);
            Margin = new Padding(7, 6, 7, 6);
            Name = "ChatItem";
            Padding = new Padding(22, 13, 22, 13);
            Size = new Size(1313, 188);
            Load += ChatItem_Load;
            authorPanel.ResumeLayout(false);
            authorPanel.PerformLayout();
            bodyPanel.ResumeLayout(false);
            bodyPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel authorPanel;
		private System.Windows.Forms.Label authorLabel;
		private System.Windows.Forms.Panel bodyPanel;
		private System.Windows.Forms.TextBox bodyTextBox;
	}
}
