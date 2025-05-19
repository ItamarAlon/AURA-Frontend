
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
            phoneLabel = new Label();
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
            topPanel.Controls.Add(phoneLabel);
            topPanel.Controls.Add(clientnameLabel);
            topPanel.Dock = DockStyle.Top;
            topPanel.ForeColor = SystemColors.ButtonHighlight;
            topPanel.Location = new Point(0, 0);
            topPanel.Margin = new Padding(7, 6, 7, 6);
            topPanel.Name = "topPanel";
            topPanel.Padding = new Padding(33, 36, 33, 36);
            topPanel.Size = new Size(890, 190);
            topPanel.TabIndex = 0;
            topPanel.Paint += topPanel_Paint;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Dock = DockStyle.Right;
            statusLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            statusLabel.ForeColor = SystemColors.ControlLightLight;
            statusLabel.Location = new Point(720, 87);
            statusLabel.Margin = new Padding(7, 0, 7, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(137, 32);
            statusLabel.TabIndex = 2;
            statusLabel.Text = "LastViewed";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Dock = DockStyle.Bottom;
            phoneLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            phoneLabel.ForeColor = SystemColors.ControlLightLight;
            phoneLabel.Location = new Point(33, 109);
            phoneLabel.Margin = new Padding(7, 0, 7, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(239, 45);
            phoneLabel.TabIndex = 1;
            phoneLabel.Text = "(408) 262-9190";
            // 
            // clientnameLabel
            // 
            clientnameLabel.AutoSize = true;
            clientnameLabel.Dock = DockStyle.Top;
            clientnameLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            clientnameLabel.ForeColor = SystemColors.ControlLightLight;
            clientnameLabel.Location = new Point(33, 36);
            clientnameLabel.Margin = new Padding(7, 0, 7, 0);
            clientnameLabel.Name = "clientnameLabel";
            clientnameLabel.Size = new Size(235, 51);
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
            bottomPanel.Location = new Point(0, 1351);
            bottomPanel.Margin = new Padding(7, 6, 7, 6);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Padding = new Padding(33, 26, 33, 26);
            bottomPanel.Size = new Size(890, 132);
            bottomPanel.TabIndex = 1;
            // 
            // chatTextbox
            // 
            chatTextbox.Dock = DockStyle.Fill;
            chatTextbox.Location = new Point(33, 26);
            chatTextbox.Margin = new Padding(7, 6, 7, 6);
            chatTextbox.Multiline = true;
            chatTextbox.Name = "chatTextbox";
            chatTextbox.Size = new Size(544, 80);
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
            attachButton.Location = new Point(577, 26);
            attachButton.Margin = new Padding(7, 6, 7, 6);
            attachButton.Name = "attachButton";
            attachButton.Size = new Size(76, 80);
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
            removeButton.Location = new Point(653, 26);
            removeButton.Margin = new Padding(7, 6, 7, 6);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(41, 80);
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
            sendButton.Location = new Point(694, 26);
            sendButton.Margin = new Padding(7, 6, 7, 6);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(163, 80);
            sendButton.TabIndex = 1;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = false;
            // 
            // itemsPanel
            // 
            itemsPanel.AutoScroll = true;
            itemsPanel.Dock = DockStyle.Fill;
            itemsPanel.Location = new Point(0, 190);
            itemsPanel.Margin = new Padding(7, 6, 7, 6);
            itemsPanel.Name = "itemsPanel";
            itemsPanel.Size = new Size(890, 1161);
            itemsPanel.TabIndex = 2;
            // 
            // Chatbox
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(itemsPanel);
            Controls.Add(bottomPanel);
            Controls.Add(topPanel);
            Margin = new Padding(7, 6, 7, 6);
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
		private System.Windows.Forms.Label statusLabel;
		private System.Windows.Forms.Label phoneLabel;
		private System.Windows.Forms.Label clientnameLabel;
		private System.Windows.Forms.Panel bottomPanel;
		private System.Windows.Forms.Button sendButton;
		private System.Windows.Forms.Button attachButton;
		private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.TextBox chatTextbox;
		private System.Windows.Forms.Panel itemsPanel;
	}
}
