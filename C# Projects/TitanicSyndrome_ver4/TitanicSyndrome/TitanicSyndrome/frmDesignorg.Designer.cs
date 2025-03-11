namespace TitanicSyndrome
{
    partial class frmDesignorg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDesignorg));
            this.rtbEmail = new System.Windows.Forms.RichTextBox();
            this.rtbNumber = new System.Windows.Forms.RichTextBox();
            this.rtbGender = new System.Windows.Forms.RichTextBox();
            this.rtbAge = new System.Windows.Forms.RichTextBox();
            this.rtbSurname = new System.Windows.Forms.RichTextBox();
            this.rtbName = new System.Windows.Forms.RichTextBox();
            this.rtbCompany = new System.Windows.Forms.RichTextBox();
            this.rtbJob = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbEmail
            // 
            this.rtbEmail.Location = new System.Drawing.Point(868, 539);
            this.rtbEmail.Name = "rtbEmail";
            this.rtbEmail.Size = new System.Drawing.Size(402, 48);
            this.rtbEmail.TabIndex = 13;
            this.rtbEmail.Text = "";
            // 
            // rtbNumber
            // 
            this.rtbNumber.Location = new System.Drawing.Point(868, 462);
            this.rtbNumber.Name = "rtbNumber";
            this.rtbNumber.Size = new System.Drawing.Size(402, 47);
            this.rtbNumber.TabIndex = 12;
            this.rtbNumber.Text = "";
            // 
            // rtbGender
            // 
            this.rtbGender.Location = new System.Drawing.Point(868, 382);
            this.rtbGender.Name = "rtbGender";
            this.rtbGender.Size = new System.Drawing.Size(402, 47);
            this.rtbGender.TabIndex = 11;
            this.rtbGender.Text = "";
            // 
            // rtbAge
            // 
            this.rtbAge.Location = new System.Drawing.Point(868, 304);
            this.rtbAge.Name = "rtbAge";
            this.rtbAge.Size = new System.Drawing.Size(402, 47);
            this.rtbAge.TabIndex = 10;
            this.rtbAge.Text = "";
            // 
            // rtbSurname
            // 
            this.rtbSurname.Location = new System.Drawing.Point(868, 223);
            this.rtbSurname.Name = "rtbSurname";
            this.rtbSurname.Size = new System.Drawing.Size(402, 47);
            this.rtbSurname.TabIndex = 9;
            this.rtbSurname.Text = "";
            // 
            // rtbName
            // 
            this.rtbName.Location = new System.Drawing.Point(868, 147);
            this.rtbName.Name = "rtbName";
            this.rtbName.Size = new System.Drawing.Size(402, 47);
            this.rtbName.TabIndex = 8;
            this.rtbName.Text = "";
            // 
            // rtbCompany
            // 
            this.rtbCompany.Location = new System.Drawing.Point(868, 687);
            this.rtbCompany.Name = "rtbCompany";
            this.rtbCompany.Size = new System.Drawing.Size(402, 48);
            this.rtbCompany.TabIndex = 15;
            this.rtbCompany.Text = "";
            // 
            // rtbJob
            // 
            this.rtbJob.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.rtbJob.Location = new System.Drawing.Point(868, 610);
            this.rtbJob.Name = "rtbJob";
            this.rtbJob.Size = new System.Drawing.Size(402, 47);
            this.rtbJob.TabIndex = 14;
            this.rtbJob.Text = "";
            // 
            // frmDesignorg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.rtbCompany);
            this.Controls.Add(this.rtbJob);
            this.Controls.Add(this.rtbEmail);
            this.Controls.Add(this.rtbNumber);
            this.Controls.Add(this.rtbGender);
            this.Controls.Add(this.rtbAge);
            this.Controls.Add(this.rtbSurname);
            this.Controls.Add(this.rtbName);
            this.Name = "frmDesignorg";
            this.Text = "frmDesignorg";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbEmail;
        private System.Windows.Forms.RichTextBox rtbNumber;
        private System.Windows.Forms.RichTextBox rtbGender;
        private System.Windows.Forms.RichTextBox rtbAge;
        private System.Windows.Forms.RichTextBox rtbSurname;
        private System.Windows.Forms.RichTextBox rtbName;
        private System.Windows.Forms.RichTextBox rtbCompany;
        private System.Windows.Forms.RichTextBox rtbJob;
    }
}