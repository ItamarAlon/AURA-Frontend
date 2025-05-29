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
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            label4 = new Label();
            toolStrip1 = new ToolStrip();
            toggleChatButton = new ToolStripButton();
            mainPanel = new Panel();
            label6 = new Label();
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
            goBackButton.Location = new Point(11, 19);
            goBackButton.Margin = new Padding(2, 3, 2, 3);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(121, 51);
            goBackButton.TabIndex = 3;
            goBackButton.Text = "← Back";
            goBackButton.UseVisualStyleBackColor = false;
            goBackButton.Click += goBackButton_Click;
            // 
            // chatbox1
            // 
            chatbox1.BackColor = Color.White;
            chatbox1.Dock = DockStyle.Right;
            chatbox1.Location = new Point(506, 0);
            chatbox1.Margin = new Padding(5, 4, 5, 4);
            chatbox1.Name = "chatbox1";
            chatbox1.Size = new Size(309, 689);
            chatbox1.TabIndex = 4;
            chatbox1.Visible = false;
            // 
            // statusBar1
            // 
            statusBar1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusBar1.Location = new Point(292, 345);
            statusBar1.Margin = new Padding(11, 13, 11, 13);
            statusBar1.Name = "statusBar1";
            statusBar1.RightToLeft = RightToLeft.Yes;
            statusBar1.Size = new Size(115, 33);
            statusBar1.Status = null;
            statusBar1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 103);
            label1.Name = "label1";
            label1.Size = new Size(243, 54);
            label1.TabIndex = 6;
            label1.Text = "Repo Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(264, 125);
            label2.Name = "label2";
            label2.Size = new Size(57, 32);
            label2.TabIndex = 7;
            label2.Text = "v1.0";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(27, 172);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(267, 67);
            textBox1.TabIndex = 8;
            textBox1.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 243);
            label3.Name = "label3";
            label3.Size = new Size(278, 25);
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
            runButton.Location = new Point(27, 287);
            runButton.Margin = new Padding(3, 4, 3, 4);
            runButton.Name = "runButton";
            runButton.Size = new Size(171, 55);
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
            comboBox1.Location = new Point(206, 288);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.No;
            comboBox1.Size = new Size(155, 40);
            comboBox1.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 248, 247);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 689);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(861, 59);
            panel1.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 214F));
            tableLayoutPanel1.Controls.Add(label6, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Controls.Add(label5, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(861, 59);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(187, 0);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(674, 59);
            label5.TabIndex = 1;
            label5.Text = "Version: 1.0";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(161, 59);
            label4.TabIndex = 0;
            label4.Text = "Path: users/home";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.FromArgb(247, 248, 247);
            toolStrip1.Dock = DockStyle.Right;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toggleChatButton });
            toolStrip1.Location = new Point(815, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(46, 689);
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
            mainPanel.Location = new Point(51, 81);
            mainPanel.Margin = new Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(418, 404);
            mainPanel.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(167, 0);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(20, 59);
            label6.TabIndex = 2;
            label6.Text = "|";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RepoManagerScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(chatbox1);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            Controls.Add(mainPanel);
            Margin = new Padding(2, 3, 2, 3);
            Name = "RepoManagerScreen";
            Size = new Size(861, 748);
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
        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
        private Label label6;
    }
}
