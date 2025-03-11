namespace TitanicSyndrome
{
    partial class frmTestIntro_org
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTestIntro_org));
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.rjbReturn = new CustomControls.RJControls.RJButton();
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
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(413, 552);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(210, 53);
            this.rjButton1.TabIndex = 6;
            this.rjButton1.Text = "Begin organization test";
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
            this.rjbReturn.Location = new System.Drawing.Point(12, 604);
            this.rjbReturn.Name = "rjbReturn";
            this.rjbReturn.Size = new System.Drawing.Size(91, 32);
            this.rjbReturn.TabIndex = 20;
            this.rjbReturn.Text = "Previous";
            this.rjbReturn.TextColor = System.Drawing.Color.White;
            this.rjbReturn.UseVisualStyleBackColor = false;
            this.rjbReturn.Click += new System.EventHandler(this.rjbReturn_Click);
            // 
            // frmTestIntro_org
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 648);
            this.Controls.Add(this.rjbReturn);
            this.Controls.Add(this.rjButton1);
            this.DoubleBuffered = true;
            this.Name = "frmTestIntro_org";
            this.Text = "TestIntro_org";
            this.Load += new System.EventHandler(this.frmTestIntro_org_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton rjbReturn;
    }
}