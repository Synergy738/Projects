namespace TitanicSyndrome
{
    partial class frmSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSummary));
            this.lblScore = new System.Windows.Forms.Label();
            this.lblchange3 = new System.Windows.Forms.Label();
            this.lblchange2 = new System.Windows.Forms.Label();
            this.lblchange1 = new System.Windows.Forms.Label();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.rjbReturn = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore.BackColor = System.Drawing.Color.Gainsboro;
            this.lblScore.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblScore.Location = new System.Drawing.Point(104, 403);
            this.lblScore.MinimumSize = new System.Drawing.Size(605, 220);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(605, 220);
            this.lblScore.TabIndex = 14;
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblchange3
            // 
            this.lblchange3.AutoSize = true;
            this.lblchange3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchange3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblchange3.Location = new System.Drawing.Point(839, 443);
            this.lblchange3.MaximumSize = new System.Drawing.Size(50, 50);
            this.lblchange3.MinimumSize = new System.Drawing.Size(350, 40);
            this.lblchange3.Name = "lblchange3";
            this.lblchange3.Size = new System.Drawing.Size(350, 40);
            this.lblchange3.TabIndex = 21;
            this.lblchange3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblchange2
            // 
            this.lblchange2.AutoSize = true;
            this.lblchange2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchange2.ForeColor = System.Drawing.Color.IndianRed;
            this.lblchange2.Location = new System.Drawing.Point(839, 355);
            this.lblchange2.MaximumSize = new System.Drawing.Size(50, 50);
            this.lblchange2.MinimumSize = new System.Drawing.Size(350, 40);
            this.lblchange2.Name = "lblchange2";
            this.lblchange2.Size = new System.Drawing.Size(350, 40);
            this.lblchange2.TabIndex = 20;
            this.lblchange2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblchange1
            // 
            this.lblchange1.AutoSize = true;
            this.lblchange1.BackColor = System.Drawing.Color.Gainsboro;
            this.lblchange1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchange1.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblchange1.Location = new System.Drawing.Point(839, 281);
            this.lblchange1.MaximumSize = new System.Drawing.Size(50, 50);
            this.lblchange1.MinimumSize = new System.Drawing.Size(350, 40);
            this.lblchange1.Name = "lblchange1";
            this.lblchange1.Size = new System.Drawing.Size(350, 40);
            this.lblchange1.TabIndex = 19;
            this.lblchange1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.SystemColors.Highlight;
            this.rjButton1.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.rjButton1.BorderColor = System.Drawing.Color.DarkOrange;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(1099, 654);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(88, 32);
            this.rjButton1.TabIndex = 15;
            this.rjButton1.Text = "Continue";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjbReturn
            // 
            this.rjbReturn.BackColor = System.Drawing.Color.DimGray;
            this.rjbReturn.BackgroundColor = System.Drawing.Color.DimGray;
            this.rjbReturn.BorderColor = System.Drawing.Color.DarkOrange;
            this.rjbReturn.BorderRadius = 10;
            this.rjbReturn.BorderSize = 0;
            this.rjbReturn.FlatAppearance.BorderSize = 0;
            this.rjbReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbReturn.ForeColor = System.Drawing.Color.White;
            this.rjbReturn.Location = new System.Drawing.Point(12, 659);
            this.rjbReturn.Name = "rjbReturn";
            this.rjbReturn.Size = new System.Drawing.Size(91, 32);
            this.rjbReturn.TabIndex = 22;
            this.rjbReturn.Text = "Previous";
            this.rjbReturn.TextColor = System.Drawing.Color.White;
            this.rjbReturn.UseVisualStyleBackColor = false;
            this.rjbReturn.Click += new System.EventHandler(this.rjbReturn_Click);
            // 
            // frmSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1218, 714);
            this.Controls.Add(this.rjbReturn);
            this.Controls.Add(this.lblchange3);
            this.Controls.Add(this.lblchange2);
            this.Controls.Add(this.lblchange1);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.lblScore);
            this.DoubleBuffered = true;
            this.Name = "frmSummary";
            this.Text = "Summary";
            this.Load += new System.EventHandler(this.frmSummary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblchange3;
        private System.Windows.Forms.Label lblchange2;
        private System.Windows.Forms.Label lblchange1;
        private CustomControls.RJControls.RJButton rjbReturn;
    }
}