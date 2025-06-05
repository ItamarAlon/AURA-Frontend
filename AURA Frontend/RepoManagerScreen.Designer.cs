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
            components = new System.ComponentModel.Container();
            goBackButton = new Button();
            chatbox = new Chatbox();
            statusBar = new StatusBar();
            repoNameLabel = new Label();
            repositoryBindingSource = new BindingSource(components);
            descriptionTextBox = new TextBox();
            lastModifiedLabel = new Label();
            runButton = new Button();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableSeperatorLabel = new Label();
            pathLabel = new Label();
            versionLabel = new Label();
            toolStrip1 = new ToolStrip();
            toggleChatButton = new ToolStripButton();
            mainPanel = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)repositoryBindingSource).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // goBackButton
            // 
            goBackButton.BackColor = Color.Transparent;
            goBackButton.BackgroundImageLayout = ImageLayout.None;
            goBackButton.FlatAppearance.BorderColor = SystemColors.Control;
            goBackButton.FlatStyle = FlatStyle.Flat;
            goBackButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goBackButton.Location = new Point(12, 19);
            goBackButton.Margin = new Padding(2, 2, 2, 2);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(121, 51);
            goBackButton.TabIndex = 3;
            goBackButton.Text = "← Back";
            goBackButton.UseVisualStyleBackColor = false;
            goBackButton.Click += goBackButton_Click;
            // 
            // chatbox
            // 
            chatbox.BackColor = Color.White;
            chatbox.Dock = DockStyle.Right;
            chatbox.Location = new Point(516, 0);
            chatbox.Margin = new Padding(4, 4, 4, 4);
            chatbox.Name = "chatbox";
            chatbox.Size = new Size(308, 689);
            chatbox.TabIndex = 4;
            chatbox.Visible = false;
            // 
            // statusBar1
            // 
            statusBar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusBar.Location = new Point(292, 346);
            statusBar.Margin = new Padding(12, 13, 12, 13);
            statusBar.Name = "statusBar1";
            statusBar.RightToLeft = RightToLeft.Yes;
            statusBar.Size = new Size(116, 33);
            statusBar.Status = null;
            statusBar.TabIndex = 5;
            // 
            // repoNameLabel
            // 
            repoNameLabel.AutoSize = true;
            repoNameLabel.DataBindings.Add(new Binding("Text", repositoryBindingSource, "Name", true));
            repoNameLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            repoNameLabel.Location = new Point(28, 102);
            repoNameLabel.Margin = new Padding(4, 0, 4, 0);
            repoNameLabel.Name = "repoNameLabel";
            repoNameLabel.Size = new Size(243, 54);
            repoNameLabel.TabIndex = 6;
            repoNameLabel.Text = "Repo Name";
            // 
            // repositoryBindingSource
            // 
            repositoryBindingSource.DataSource = typeof(Repository);
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.BackColor = SystemColors.Control;
            descriptionTextBox.BorderStyle = BorderStyle.None;
            descriptionTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionTextBox.Location = new Point(28, 161);
            descriptionTextBox.Margin = new Padding(4, 4, 4, 4);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.ReadOnly = true;
            descriptionTextBox.Size = new Size(278, 78);
            descriptionTextBox.TabIndex = 8;
            descriptionTextBox.Text = "Description";
            // 
            // lastModifiedLabel
            // 
            lastModifiedLabel.AutoSize = true;
            lastModifiedLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastModifiedLabel.Location = new Point(28, 242);
            lastModifiedLabel.Margin = new Padding(4, 0, 4, 0);
            lastModifiedLabel.Name = "lastModifiedLabel";
            lastModifiedLabel.Size = new Size(278, 25);
            lastModifiedLabel.TabIndex = 9;
            lastModifiedLabel.Text = "Last Modified: January 1st, 1970";
            // 
            // runButton
            // 
            runButton.BackColor = Color.FromArgb(46, 85, 219);
            runButton.BackgroundImageLayout = ImageLayout.None;
            runButton.FlatAppearance.BorderColor = Color.FromArgb(5, 48, 214);
            runButton.FlatAppearance.MouseDownBackColor = Color.Navy;
            runButton.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            runButton.FlatStyle = FlatStyle.Flat;
            runButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            runButton.ForeColor = Color.White;
            runButton.Location = new Point(28, 287);
            runButton.Margin = new Padding(4, 4, 4, 4);
            runButton.Name = "runButton";
            runButton.Size = new Size(172, 54);
            runButton.TabIndex = 10;
            runButton.Text = "Run";
            runButton.UseVisualStyleBackColor = false;
            runButton.Click += runButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 248, 247);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 689);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 59);
            panel1.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 734F));
            tableLayoutPanel1.Controls.Add(tableSeperatorLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(pathLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(versionLabel, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 2, 4, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(860, 59);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // tableSeperatorLabel
            // 
            tableSeperatorLabel.AutoSize = true;
            tableSeperatorLabel.Dock = DockStyle.Fill;
            tableSeperatorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableSeperatorLabel.Location = new Point(169, 0);
            tableSeperatorLabel.Margin = new Padding(0);
            tableSeperatorLabel.Name = "tableSeperatorLabel";
            tableSeperatorLabel.Size = new Size(20, 59);
            tableSeperatorLabel.TabIndex = 2;
            tableSeperatorLabel.Text = "|";
            tableSeperatorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pathLabel
            // 
            pathLabel.AutoSize = true;
            pathLabel.Dock = DockStyle.Fill;
            pathLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pathLabel.Location = new Point(4, 0);
            pathLabel.Margin = new Padding(4, 0, 4, 0);
            pathLabel.Name = "pathLabel";
            pathLabel.Size = new Size(161, 59);
            pathLabel.TabIndex = 0;
            pathLabel.Text = "Path: users/home";
            pathLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Dock = DockStyle.Fill;
            versionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            versionLabel.Location = new Point(189, 0);
            versionLabel.Margin = new Padding(0);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(734, 59);
            versionLabel.TabIndex = 1;
            versionLabel.Text = "Version: 1.0";
            versionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.FromArgb(247, 248, 247);
            toolStrip1.Dock = DockStyle.Right;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toggleChatButton });
            toolStrip1.Location = new Point(824, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 2, 0);
            toolStrip1.Size = new Size(36, 689);
            toolStrip1.TabIndex = 13;
            toolStrip1.Text = "toolStrip1";
            // 
            // toggleChatButton
            // 
            toggleChatButton.AutoSize = false;
            toggleChatButton.CheckOnClick = true;
            toggleChatButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toggleChatButton.Image = Properties.Resources.ChatGPT_Black_Logo;
            toggleChatButton.ImageTransparentColor = Color.Magenta;
            toggleChatButton.Name = "toggleChatButton";
            toggleChatButton.Size = new Size(40, 40);
            toggleChatButton.Text = "Chat";
            toggleChatButton.Click += toggleChatButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(button1);
            mainPanel.Controls.Add(goBackButton);
            mainPanel.Controls.Add(runButton);
            mainPanel.Controls.Add(statusBar);
            mainPanel.Controls.Add(lastModifiedLabel);
            mainPanel.Controls.Add(repoNameLabel);
            mainPanel.Controls.Add(descriptionTextBox);
            mainPanel.Location = new Point(47, 113);
            mainPanel.Margin = new Padding(4, 4, 4, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(418, 404);
            mainPanel.TabIndex = 14;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F);
            button1.Location = new Point(206, 287);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(153, 58);
            button1.TabIndex = 12;
            button1.Text = "Options";
            button1.UseVisualStyleBackColor = true;
            // 
            // RepoManagerScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(chatbox);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            Controls.Add(mainPanel);
            Margin = new Padding(2, 2, 2, 2);
            Name = "RepoManagerScreen";
            Size = new Size(860, 748);
            ((System.ComponentModel.ISupportInitialize)repositoryBindingSource).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button goBackButton;
        private Chatbox chatbox;
        private StatusBar statusBar;
        private Label repoNameLabel;
        private TextBox descriptionTextBox;
        private Label lastModifiedLabel;
        private Button runButton;
        private Panel panel1;
        private Label pathLabel;
        private ToolStrip toolStrip1;
        private ToolStripButton toggleChatButton;
        private Panel mainPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label versionLabel;
        private Label tableSeperatorLabel;
        private Button button1;
        private BindingSource repositoryBindingSource;
    }
}
