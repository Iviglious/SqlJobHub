namespace SqlJobHub
{
    partial class MainForm
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
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LogRTBox = new System.Windows.Forms.RichTextBox();
            this.CPTabControl = new System.Windows.Forms.TabControl();
            this.MainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.tabPage1);
            this.MainTabControl.Controls.Add(this.tabPage2);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(507, 359);
            this.MainTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CPTabControl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(499, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Control Panel";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LogRTBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(499, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log Monitor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LogRTBox
            // 
            this.LogRTBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogRTBox.Location = new System.Drawing.Point(3, 3);
            this.LogRTBox.Name = "LogRTBox";
            this.LogRTBox.ReadOnly = true;
            this.LogRTBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.LogRTBox.Size = new System.Drawing.Size(493, 327);
            this.LogRTBox.TabIndex = 0;
            this.LogRTBox.Text = "";
            // 
            // CPTabControl
            // 
            this.CPTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CPTabControl.Location = new System.Drawing.Point(3, 3);
            this.CPTabControl.Name = "CPTabControl";
            this.CPTabControl.SelectedIndex = 0;
            this.CPTabControl.Size = new System.Drawing.Size(493, 327);
            this.CPTabControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 359);
            this.Controls.Add(this.MainTabControl);
            this.Name = "MainForm";
            this.Text = "SQL Job Hub";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox LogRTBox;
        private System.Windows.Forms.TabControl CPTabControl;
    }
}

