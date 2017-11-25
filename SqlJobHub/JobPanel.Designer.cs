namespace SqlJobHub
{
    partial class JobPanel
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
            this.JobNameTextLbl = new System.Windows.Forms.Label();
            this.StepNameLbl = new System.Windows.Forms.Label();
            this.JobNameLbl = new System.Windows.Forms.Label();
            this.StepNameTextLbl = new System.Windows.Forms.Label();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ActionBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JobNameTextLbl
            // 
            this.JobNameTextLbl.AutoSize = true;
            this.JobNameTextLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobNameTextLbl.Location = new System.Drawing.Point(3, 0);
            this.JobNameTextLbl.Name = "JobNameTextLbl";
            this.JobNameTextLbl.Size = new System.Drawing.Size(68, 16);
            this.JobNameTextLbl.TabIndex = 0;
            this.JobNameTextLbl.Text = "Job name:";
            // 
            // StepNameLbl
            // 
            this.StepNameLbl.AutoSize = true;
            this.StepNameLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepNameLbl.Location = new System.Drawing.Point(77, 16);
            this.StepNameLbl.Name = "StepNameLbl";
            this.StepNameLbl.Size = new System.Drawing.Size(194, 16);
            this.StepNameLbl.TabIndex = 1;
            this.StepNameLbl.Text = "Step for execution of IS package";
            // 
            // JobNameLbl
            // 
            this.JobNameLbl.AutoSize = true;
            this.JobNameLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobNameLbl.Location = new System.Drawing.Point(77, 0);
            this.JobNameLbl.Name = "JobNameLbl";
            this.JobNameLbl.Size = new System.Drawing.Size(215, 16);
            this.JobNameLbl.TabIndex = 2;
            this.JobNameLbl.Text = "Test job for execution of IS package";
            // 
            // StepNameTextLbl
            // 
            this.StepNameTextLbl.AutoSize = true;
            this.StepNameTextLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepNameTextLbl.Location = new System.Drawing.Point(3, 16);
            this.StepNameTextLbl.Name = "StepNameTextLbl";
            this.StepNameTextLbl.Size = new System.Drawing.Size(75, 16);
            this.StepNameTextLbl.TabIndex = 3;
            this.StepNameTextLbl.Text = "Step name:";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(3, 35);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.RefreshBtn.TabIndex = 4;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(84, 35);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(232, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // ActionBtn
            // 
            this.ActionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionBtn.Location = new System.Drawing.Point(322, 35);
            this.ActionBtn.Name = "ActionBtn";
            this.ActionBtn.Size = new System.Drawing.Size(75, 23);
            this.ActionBtn.TabIndex = 6;
            this.ActionBtn.Text = "Start";
            this.ActionBtn.UseVisualStyleBackColor = true;
            this.ActionBtn.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // JobPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ActionBtn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.StepNameTextLbl);
            this.Controls.Add(this.JobNameLbl);
            this.Controls.Add(this.StepNameLbl);
            this.Controls.Add(this.JobNameTextLbl);
            this.MinimumSize = new System.Drawing.Size(400, 65);
            this.Name = "JobPanel";
            this.Size = new System.Drawing.Size(400, 65);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JobNameTextLbl;
        private System.Windows.Forms.Label StepNameLbl;
        private System.Windows.Forms.Label JobNameLbl;
        private System.Windows.Forms.Label StepNameTextLbl;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button ActionBtn;
    }
}
