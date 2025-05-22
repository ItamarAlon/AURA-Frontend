
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
            statusLabel = new Label();
            clientnameLabel = new Label();
            bottomPanel = new Panel();
            chatTextbox = new TextBox();
            attachButton = new Button();
            removeButton = new Button();
            sendButton = new Button();
            itemsPanel = new Panel();
            topPanel.SuspendLayout();
            bottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.RoyalBlue;
            topPanel.Controls.Add(statusLabel);
            topPanel.Controls.Add(clientnameLabel);
            topPanel.Dock = DockStyle.Top;
            topPanel.ForeColor = SystemColors.ButtonHighlight;
            topPanel.Location = new Point(0, 0);
            topPanel.Margin = new Padding(4);
            topPanel.Name = "topPanel";
            topPanel.Padding = new Padding(20, 22, 20, 22);
            topPanel.Size = new Size(548, 97);
            topPanel.TabIndex = 0;
            topPanel.Paint += topPanel_Paint;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Dock = DockStyle.Right;
            statusLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            statusLabel.ForeColor = SystemColors.ControlLightLight;
            statusLabel.Location = new Point(443, 54);
            statusLabel.Margin = new Padding(4, 0, 4, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(85, 20);
            statusLabel.TabIndex = 2;
            statusLabel.Text = "LastViewed";
            // 
            // clientnameLabel
            // 
            clientnameLabel.AutoSize = true;
            clientnameLabel.Dock = DockStyle.Top;
            clientnameLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            clientnameLabel.ForeColor = SystemColors.ControlLightLight;
            clientnameLabel.Location = new Point(20, 22);
            clientnameLabel.Margin = new Padding(4, 0, 4, 0);
            clientnameLabel.Name = "clientnameLabel";
            clientnameLabel.Size = new Size(149, 32);
            clientnameLabel.TabIndex = 0;
            clientnameLabel.Text = "Client Name";
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = Color.RoyalBlue;
            bottomPanel.Controls.Add(chatTextbox);
            bottomPanel.Controls.Add(attachButton);
            bottomPanel.Controls.Add(removeButton);
            bottomPanel.Controls.Add(sendButton);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.ForeColor = SystemColors.ControlLightLight;
            bottomPanel.Location = new Point(0, 845);
            bottomPanel.Margin = new Padding(4);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Padding = new Padding(20, 16, 20, 16);
            bottomPanel.Size = new Size(548, 82);
            bottomPanel.TabIndex = 1;
            // 
            // chatTextbox
            // 
            chatTextbox.Dock = DockStyle.Fill;
            chatTextbox.Location = new Point(20, 16);
            chatTextbox.Margin = new Padding(4);
            chatTextbox.Multiline = true;
            chatTextbox.Name = "chatTextbox";
            chatTextbox.Size = new Size(336, 50);
            chatTextbox.TabIndex = 7;
            // 
            // attachButton
            // 
            attachButton.BackColor = Color.GhostWhite;
            attachButton.BackgroundImageLayout = ImageLayout.Center;
            attachButton.Dock = DockStyle.Right;
            attachButton.FlatStyle = FlatStyle.Flat;
            attachButton.ForeColor = SystemColors.ControlText;
            attachButton.ImageAlign = ContentAlignment.MiddleLeft;
            attachButton.Location = new Point(356, 16);
            attachButton.Margin = new Padding(4);
            attachButton.Name = "attachButton";
            attachButton.Size = new Size(47, 50);
            attachButton.TabIndex = 6;
            attachButton.TextAlign = ContentAlignment.MiddleRight;
            attachButton.UseVisualStyleBackColor = false;
            // 
            // removeButton
            // 
            removeButton.BackColor = Color.Red;
            removeButton.Dock = DockStyle.Right;
            removeButton.FlatStyle = FlatStyle.Popup;
            removeButton.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold);
            removeButton.ForeColor = SystemColors.ControlLightLight;
            removeButton.Location = new Point(403, 16);
            removeButton.Margin = new Padding(4);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(25, 50);
            removeButton.TabIndex = 5;
            removeButton.Text = "X";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Visible = false;
            // 
            // sendButton
            // 
            sendButton.BackColor = Color.RoyalBlue;
            sendButton.Dock = DockStyle.Right;
            sendButton.FlatStyle = FlatStyle.Flat;
            sendButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            sendButton.Location = new Point(428, 16);
            sendButton.Margin = new Padding(4);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(100, 50);
            sendButton.TabIndex = 1;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = false;
            // 
            // itemsPanel
            // 
            itemsPanel.AutoScroll = true;
            itemsPanel.Dock = DockStyle.Fill;
            itemsPanel.Location = new Point(0, 97);
            itemsPanel.Margin = new Padding(4);
            itemsPanel.Name = "itemsPanel";
            itemsPanel.Size = new Size(548, 748);
            itemsPanel.TabIndex = 2;
            // 
            // Chatbox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(itemsPanel);
            Controls.Add(bottomPanel);
            Controls.Add(topPanel);
            Margin = new Padding(4);
            Name = "Chatbox";
            Size = new Size(548, 927);
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            bottomPanel.ResumeLayout(false);
            bottomPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
		private System.Windows.Forms.Label statusLabel;
		private System.Windows.Forms.Label clientnameLabel;
		private System.Windows.Forms.Panel bottomPanel;
		private System.Windows.Forms.Button sendButton;
		private System.Windows.Forms.Button attachButton;
		private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.TextBox chatTextbox;
		private System.Windows.Forms.Panel itemsPanel;
	}
}
