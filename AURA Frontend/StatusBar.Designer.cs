namespace AURA_Frontend
{
    partial class StatusBar
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
            dotIndicator1 = new DotIndicator();
            statusLabel = new Label();
            SuspendLayout();
            // 
            // dotIndicator1
            // 
            dotIndicator1.BackColor = Color.Transparent;
            dotIndicator1.Diameter = 14;
            dotIndicator1.DotColor = Color.Gray;
            dotIndicator1.Location = new Point(0, 0);
            dotIndicator1.Name = "dotIndicator1";
            dotIndicator1.Size = new Size(16, 20);
            dotIndicator1.TabIndex = 0;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(22, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(47, 20);
            statusLabel.TabIndex = 1;
            statusLabel.Text = "status";
            statusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StatusBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dotIndicator1);
            Controls.Add(statusLabel);
            Name = "StatusBar";
            Size = new Size(73, 23);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DotIndicator dotIndicator1;
        private Label statusLabel;
    }
}
