namespace TitanicSyndrome
{
    partial class DatabaseUI
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseUI));
            this.dgvusers = new System.Windows.Forms.DataGridView();
            this.edtSearhPerson = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbxSort = new System.Windows.Forms.CheckedListBox();
            this.rjButton4 = new CustomControls.RJControls.RJButton();
            this.rjButton3 = new CustomControls.RJControls.RJButton();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.rjbReturn = new CustomControls.RJControls.RJButton();
            this.btnNext = new CustomControls.RJControls.RJButton();
            this.rjbPerUser = new CustomControls.RJControls.RJButton();
            this.rjButton5 = new CustomControls.RJControls.RJButton();
            this.rjButton6 = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvusers
            // 
            this.dgvusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusers.Location = new System.Drawing.Point(13, 264);
            this.dgvusers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvusers.Name = "dgvusers";
            this.dgvusers.Size = new System.Drawing.Size(788, 255);
            this.dgvusers.TabIndex = 0;
            this.dgvusers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvper_CellContentClick);
            // 
            // edtSearhPerson
            // 
            this.edtSearhPerson.Location = new System.Drawing.Point(96, 149);
            this.edtSearhPerson.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtSearhPerson.Name = "edtSearhPerson";
            this.edtSearhPerson.Size = new System.Drawing.Size(245, 26);
            this.edtSearhPerson.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MinimumSize = new System.Drawing.Size(375, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search for specific user or company";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(503, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sort users by test type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 31);
            this.label7.TabIndex = 21;
            this.label7.Text = "Users";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(237, 45);
            this.label9.TabIndex = 23;
            this.label9.Text = "Dashboard";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(834, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 31);
            this.label4.TabIndex = 26;
            this.label4.Text = "Average scores:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(996, 538);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(252, 26);
            this.lblTotal.TabIndex = 29;
            this.lblTotal.Text = "Overall average score:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chart1.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.AutoFitMinFontSize = 12;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(817, 28);
            this.chart1.Name = "chart1";
            series1.BackImageTransparentColor = System.Drawing.Color.DarkGray;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            series1.Legend = "Legend1";
            series1.Name = "s1";
            series1.ShadowColor = System.Drawing.Color.Silver;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(702, 507);
            this.chart1.TabIndex = 34;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            title1.Name = "Distribution of the average scores for each category";
            this.chart1.Titles.Add(title1);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // cbxSort
            // 
            this.cbxSort.FormattingEnabled = true;
            this.cbxSort.Items.AddRange(new object[] {
            "All",
            "Both",
            "Personal",
            "Organization",
            "Admin"});
            this.cbxSort.Location = new System.Drawing.Point(509, 147);
            this.cbxSort.Name = "cbxSort";
            this.cbxSort.Size = new System.Drawing.Size(292, 109);
            this.cbxSort.TabIndex = 35;
            this.cbxSort.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // rjButton4
            // 
            this.rjButton4.BackColor = System.Drawing.Color.LightGray;
            this.rjButton4.BackgroundColor = System.Drawing.Color.LightGray;
            this.rjButton4.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rjButton4.BorderRadius = 10;
            this.rjButton4.BorderSize = 0;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.ForeColor = System.Drawing.Color.Black;
            this.rjButton4.Location = new System.Drawing.Point(254, 534);
            this.rjButton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(143, 46);
            this.rjButton4.TabIndex = 38;
            this.rjButton4.Text = "Down";
            this.rjButton4.TextColor = System.Drawing.Color.Black;
            this.rjButton4.UseVisualStyleBackColor = false;
            this.rjButton4.Click += new System.EventHandler(this.rjButton4_Click);
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.LightGray;
            this.rjButton3.BackgroundColor = System.Drawing.Color.LightGray;
            this.rjButton3.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rjButton3.BorderRadius = 10;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.ForeColor = System.Drawing.Color.Black;
            this.rjButton3.Location = new System.Drawing.Point(103, 534);
            this.rjButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(143, 46);
            this.rjButton3.TabIndex = 37;
            this.rjButton3.Text = "Up";
            this.rjButton3.TextColor = System.Drawing.Color.Black;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.RoyalBlue;
            this.rjButton2.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 10;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.Wheat;
            this.rjButton2.Location = new System.Drawing.Point(405, 534);
            this.rjButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(143, 46);
            this.rjButton2.TabIndex = 36;
            this.rjButton2.Text = "Edit";
            this.rjButton2.TextColor = System.Drawing.Color.Wheat;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(1185, 588);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(143, 46);
            this.rjButton1.TabIndex = 33;
            this.rjButton1.Text = "Clear";
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
            this.rjbReturn.Location = new System.Drawing.Point(12, 603);
            this.rjbReturn.Name = "rjbReturn";
            this.rjbReturn.Size = new System.Drawing.Size(91, 32);
            this.rjbReturn.TabIndex = 25;
            this.rjbReturn.Text = "Previous";
            this.rjbReturn.TextColor = System.Drawing.Color.White;
            this.rjbReturn.UseVisualStyleBackColor = false;
            this.rjbReturn.Click += new System.EventHandler(this.rjbReturn_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNext.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnNext.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnNext.BorderRadius = 10;
            this.btnNext.BorderSize = 0;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(1335, 588);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(175, 46);
            this.btnNext.TabIndex = 24;
            this.btnNext.Text = "Take the test myself";
            this.btnNext.TextColor = System.Drawing.Color.White;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // rjbPerUser
            // 
            this.rjbPerUser.BackColor = System.Drawing.Color.RoyalBlue;
            this.rjbPerUser.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rjbPerUser.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbPerUser.BorderRadius = 0;
            this.rjbPerUser.BorderSize = 0;
            this.rjbPerUser.FlatAppearance.BorderSize = 0;
            this.rjbPerUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbPerUser.ForeColor = System.Drawing.Color.White;
            this.rjbPerUser.Location = new System.Drawing.Point(347, 149);
            this.rjbPerUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjbPerUser.Name = "rjbPerUser";
            this.rjbPerUser.Size = new System.Drawing.Size(70, 26);
            this.rjbPerUser.TabIndex = 4;
            this.rjbPerUser.Text = "Search";
            this.rjbPerUser.TextColor = System.Drawing.Color.White;
            this.rjbPerUser.UseVisualStyleBackColor = false;
            this.rjbPerUser.Click += new System.EventHandler(this.rjbPerUser_Click);
            // 
            // rjButton5
            // 
            this.rjButton5.BackColor = System.Drawing.Color.IndianRed;
            this.rjButton5.BackgroundColor = System.Drawing.Color.IndianRed;
            this.rjButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton5.BorderRadius = 10;
            this.rjButton5.BorderSize = 0;
            this.rjButton5.FlatAppearance.BorderSize = 0;
            this.rjButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton5.ForeColor = System.Drawing.Color.Wheat;
            this.rjButton5.Location = new System.Drawing.Point(556, 534);
            this.rjButton5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjButton5.Name = "rjButton5";
            this.rjButton5.Size = new System.Drawing.Size(143, 46);
            this.rjButton5.TabIndex = 39;
            this.rjButton5.Text = "Delete";
            this.rjButton5.TextColor = System.Drawing.Color.Wheat;
            this.rjButton5.UseVisualStyleBackColor = false;
            this.rjButton5.Click += new System.EventHandler(this.rjButton5_Click);
            // 
            // rjButton6
            // 
            this.rjButton6.BackColor = System.Drawing.Color.OliveDrab;
            this.rjButton6.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.rjButton6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton6.BorderRadius = 10;
            this.rjButton6.BorderSize = 0;
            this.rjButton6.FlatAppearance.BorderSize = 0;
            this.rjButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton6.ForeColor = System.Drawing.Color.White;
            this.rjButton6.Location = new System.Drawing.Point(1024, 588);
            this.rjButton6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjButton6.Name = "rjButton6";
            this.rjButton6.Size = new System.Drawing.Size(143, 46);
            this.rjButton6.TabIndex = 40;
            this.rjButton6.Text = "Save changes";
            this.rjButton6.TextColor = System.Drawing.Color.White;
            this.rjButton6.UseVisualStyleBackColor = false;
            this.rjButton6.Click += new System.EventHandler(this.rjButton6_Click);
            // 
            // DatabaseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1522, 675);
            this.Controls.Add(this.rjButton6);
            this.Controls.Add(this.rjButton5);
            this.Controls.Add(this.rjButton4);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.cbxSort);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rjbReturn);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rjbPerUser);
            this.Controls.Add(this.edtSearhPerson);
            this.Controls.Add(this.dgvusers);
            this.Controls.Add(this.chart1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DatabaseUI";
            this.Text = "DatabaseUI";
            this.Load += new System.EventHandler(this.DatabaseUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvusers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvusers;
        private System.Windows.Forms.TextBox edtSearhPerson;
        private CustomControls.RJControls.RJButton rjbPerUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private CustomControls.RJControls.RJButton btnNext;
        private CustomControls.RJControls.RJButton rjbReturn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckedListBox cbxSort;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton3;
        private CustomControls.RJControls.RJButton rjButton4;
        private CustomControls.RJControls.RJButton rjButton5;
        private CustomControls.RJControls.RJButton rjButton6;
    }
}