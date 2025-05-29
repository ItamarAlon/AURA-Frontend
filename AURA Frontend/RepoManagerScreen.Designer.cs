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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            runButton = new Button();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            label4 = new Label();
            toolStrip1 = new ToolStrip();
            toggleChatButton = new ToolStripButton();
            mainPanel = new Panel();
            panel1.SuspendLayout();
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
            goBackButton.Location = new Point(24, 19);
            goBackButton.Margin = new Padding(2);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(72, 38);
            goBackButton.TabIndex = 3;
            goBackButton.Text = "← Back";
            goBackButton.UseVisualStyleBackColor = false;
            goBackButton.Click += goBackButton_Click;
            // 
            // chatbox1
            // 
            chatbox1.BackColor = Color.White;
            chatbox1.Dock = DockStyle.Right;
            chatbox1.Location = new Point(443, 0);
            chatbox1.Margin = new Padding(4, 3, 4, 3);
            chatbox1.Name = "chatbox1";
            chatbox1.Size = new Size(270, 517);
            chatbox1.TabIndex = 4;
            chatbox1.Visible = false;
            // 
            // statusBar1
            // 
            statusBar1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusBar1.Location = new Point(256, 260);
            statusBar1.Margin = new Padding(10);
            statusBar1.Name = "statusBar1";
            statusBar1.RightToLeft = RightToLeft.Yes;
            statusBar1.Size = new Size(101, 25);
            statusBar1.Status = null;
            statusBar1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 81);
            label1.Name = "label1";
            label1.Size = new Size(194, 45);
            label1.TabIndex = 6;
            label1.Text = "Repo Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(213, 97);
            label2.Name = "label2";
            label2.Size = new Size(45, 25);
            label2.TabIndex = 7;
            label2.Text = "v1.0";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(24, 129);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(234, 50);
            textBox1.TabIndex = 8;
            textBox1.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 182);
            label3.Name = "label3";
            label3.Size = new Size(218, 20);
            label3.TabIndex = 9;
            label3.Text = "Last Modified: January 1st, 1970";
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
            runButton.Location = new Point(24, 215);
            runButton.Name = "runButton";
            runButton.Size = new Size(150, 41);
            runButton.TabIndex = 10;
            runButton.Text = "Run";
            runButton.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.ForeColor = SystemColors.WindowText;
            comboBox1.FormattingEnabled = true;
            comboBox1.ItemHeight = 34;
            comboBox1.Items.AddRange(new object[] { "Options", "Option 1", "Option 2" });
            comboBox1.Location = new Point(180, 216);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.No;
            comboBox1.Size = new Size(136, 40);
            comboBox1.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 248, 247);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 517);
            panel1.Name = "panel1";
            panel1.Size = new Size(753, 44);
            panel1.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 9);
            label4.Name = "label4";
            label4.Size = new Size(157, 25);
            label4.TabIndex = 0;
            label4.Text = "Path: users/home";
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.FromArgb(247, 248, 247);
            toolStrip1.Dock = DockStyle.Right;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toggleChatButton });
            toolStrip1.Location = new Point(713, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(40, 517);
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
            mainPanel.Controls.Add(comboBox1);
            mainPanel.Controls.Add(goBackButton);
            mainPanel.Controls.Add(runButton);
            mainPanel.Controls.Add(statusBar1);
            mainPanel.Controls.Add(label3);
            mainPanel.Controls.Add(label1);
            mainPanel.Controls.Add(textBox1);
            mainPanel.Controls.Add(label2);
            mainPanel.Location = new Point(200, 105);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(361, 303);
            mainPanel.TabIndex = 14;
            // 
            // RepoManagerScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(chatbox1);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            Controls.Add(mainPanel);
            Margin = new Padding(2);
            Name = "RepoManagerScreen";
            Size = new Size(753, 561);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button goBackButton;
        private Chatbox chatbox1;
        private StatusBar statusBar1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Button runButton;
        private ComboBox comboBox1;
        private Panel panel1;
        private Label label4;
        private ToolStrip toolStrip1;
        private ToolStripButton toggleChatButton;
        private Panel mainPanel;
    }
}
