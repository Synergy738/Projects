namespace TitanicSyndrome
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.edtusername = new System.Windows.Forms.RichTextBox();
            this.edtpass = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.IndianRed;
            this.rjButton1.BackgroundColor = System.Drawing.Color.IndianRed;
            this.rjButton1.BorderColor = System.Drawing.Color.DarkOrange;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(380, 438);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(165, 46);
            this.rjButton1.TabIndex = 7;
            this.rjButton1.Text = "Login";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rjButton2.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.rjButton2.BorderColor = System.Drawing.Color.DarkOrange;
            this.rjButton2.BorderRadius = 10;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(409, 353);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(108, 29);
            this.rjButton2.TabIndex = 8;
            this.rjButton2.Text = "I am a new user";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // edtusername
            // 
            this.edtusername.Location = new System.Drawing.Point(250, 228);
            this.edtusername.Name = "edtusername";
            this.edtusername.Size = new System.Drawing.Size(397, 41);
            this.edtusername.TabIndex = 9;
            this.edtusername.Text = "Admin";
            // 
            // edtpass
            // 
            this.edtpass.Location = new System.Drawing.Point(250, 295);
            this.edtpass.Name = "edtpass";
            this.edtpass.Size = new System.Drawing.Size(397, 41);
            this.edtpass.TabIndex = 10;
            this.edtpass.Text = "";
            this.edtpass.TextChanged += new System.EventHandler(this.edtpass_TextChanged);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(908, 581);
            this.Controls.Add(this.edtpass);
            this.Controls.Add(this.edtusername);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.rjButton1);
            this.DoubleBuffered = true;
            this.Name = "frmLogin";
            this.Text = "The Titanic Syndrome";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton rjButton2;
        private System.Windows.Forms.RichTextBox edtusername;
        private System.Windows.Forms.RichTextBox edtpass;
    }
}

