
namespace AURA_Frontend
{
	partial class Chatbox
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
            topPanel = new Panel();
            clientnameLabel = new Label();
            bottomPanel = new Panel();
            chatTextbox = new TextBox();
            attachButton = new Button();
            removeButton = new Button();
            sendButton = new MaterialSkin.Controls.MaterialButton();
            itemsPanel = new Panel();
            topPanel.SuspendLayout();
            bottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(251, 252, 251);
            topPanel.Controls.Add(clientnameLabel);
            topPanel.Dock = DockStyle.Top;
            topPanel.ForeColor = SystemColors.ButtonHighlight;
            topPanel.Location = new Point(0, 0);
            topPanel.Margin = new Padding(6);
            topPanel.Name = "topPanel";
            topPanel.Padding = new Padding(32, 35, 32, 35);
            topPanel.Size = new Size(890, 118);
            topPanel.TabIndex = 0;
            topPanel.Paint += topPanel_Paint;
            // 
            // clientnameLabel
            // 
            clientnameLabel.AutoSize = true;
            clientnameLabel.Dock = DockStyle.Bottom;
            clientnameLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            clientnameLabel.ForeColor = Color.Black;
            clientnameLabel.Location = new Point(32, 32);
            clientnameLabel.Margin = new Padding(6, 0, 6, 0);
            clientnameLabel.Name = "clientnameLabel";
            clientnameLabel.Size = new Size(222, 51);
            clientnameLabel.TabIndex = 0;
            clientnameLabel.Text = "Need Help?";
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = Color.FromArgb(251, 252, 251);
            bottomPanel.Controls.Add(chatTextbox);
            bottomPanel.Controls.Add(attachButton);
            bottomPanel.Controls.Add(removeButton);
            bottomPanel.Controls.Add(sendButton);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.ForeColor = SystemColors.ControlLightLight;
            bottomPanel.Location = new Point(0, 1352);
            bottomPanel.Margin = new Padding(6);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Padding = new Padding(32, 26, 32, 26);
            bottomPanel.Size = new Size(890, 131);
            bottomPanel.TabIndex = 1;
            bottomPanel.Paint += bottomPanel_Paint;
            // 
            // chatTextbox
            // 
            chatTextbox.Dock = DockStyle.Fill;
            chatTextbox.Location = new Point(32, 26);
            chatTextbox.Margin = new Padding(6);
            chatTextbox.Multiline = true;
            chatTextbox.Name = "chatTextbox";
            chatTextbox.Size = new Size(610, 79);
            chatTextbox.TabIndex = 7;
            // 
            // attachButton
            // 
            attachButton.AutoSize = true;
            attachButton.BackColor = Color.GhostWhite;
            attachButton.BackgroundImageLayout = ImageLayout.Center;
            attachButton.Dock = DockStyle.Right;
            attachButton.FlatStyle = FlatStyle.System;
            attachButton.ForeColor = SystemColors.ControlText;
            attachButton.ImageAlign = ContentAlignment.MiddleLeft;
            attachButton.Location = new Point(642, 26);
            attachButton.Margin = new Padding(6);
            attachButton.Name = "attachButton";
            attachButton.Size = new Size(46, 79);
            attachButton.TabIndex = 6;
            attachButton.TextAlign = ContentAlignment.MiddleRight;
            attachButton.TextImageRelation = TextImageRelation.TextAboveImage;
            attachButton.UseVisualStyleBackColor = false;
            attachButton.Click += attachButton_Click_1;
            // 
            // removeButton
            // 
            removeButton.BackColor = Color.Red;
            removeButton.Dock = DockStyle.Right;
            removeButton.FlatAppearance.BorderSize = 2;
            removeButton.FlatStyle = FlatStyle.Flat;
            removeButton.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold);
            removeButton.ForeColor = SystemColors.ControlLightLight;
            removeButton.Location = new Point(688, 26);
            removeButton.Margin = new Padding(0);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(34, 79);
            removeButton.TabIndex = 5;
            removeButton.Text = "X";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Visible = false;
            // 
            // sendButton
            // 
            sendButton.AutoSize = false;
            sendButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sendButton.BackColor = Color.RoyalBlue;
            sendButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            sendButton.Depth = 0;
            sendButton.Dock = DockStyle.Right;
            sendButton.FlatStyle = FlatStyle.Flat;
            sendButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            sendButton.HighEmphasis = true;
            sendButton.Icon = null;
            sendButton.Location = new Point(722, 26);
            sendButton.Margin = new Padding(6);
            sendButton.MouseState = MaterialSkin.MouseState.HOVER;
            sendButton.Name = "sendButton";
            sendButton.NoAccentTextColor = Color.Empty;
            sendButton.Padding = new Padding(16);
            sendButton.Size = new Size(136, 79);
            sendButton.TabIndex = 1;
            sendButton.Text = "Send";
            sendButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            sendButton.UseAccentColor = false;
            sendButton.UseVisualStyleBackColor = false;
            // 
            // itemsPanel
            // 
            itemsPanel.AutoScroll = true;
            itemsPanel.Dock = DockStyle.Fill;
            itemsPanel.Location = new Point(0, 118);
            itemsPanel.Margin = new Padding(6);
            itemsPanel.Name = "itemsPanel";
            itemsPanel.Size = new Size(890, 1234);
            itemsPanel.TabIndex = 2;
            itemsPanel.Paint += itemsPanel_Paint;
            // 
            // Chatbox
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(itemsPanel);
            Controls.Add(bottomPanel);
            Controls.Add(topPanel);
            Margin = new Padding(6);
            Name = "Chatbox";
            Size = new Size(890, 1483);
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            bottomPanel.ResumeLayout(false);
            bottomPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
		private System.Windows.Forms.Label clientnameLabel;
		private System.Windows.Forms.Panel bottomPanel;
		private System.Windows.Forms.Button attachButton;
		private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.TextBox chatTextbox;
		private System.Windows.Forms.Panel itemsPanel;
        private MaterialSkin.Controls.MaterialButton sendButton;
    }
}
