using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TitanicSyndrome
{
    public partial class frmSummary_org : Form
    {
        public frmSummary_org()
        {
            InitializeComponent();
        }

        private void Summary_org_Load(object sender, EventArgs e)
        {
            int total = Program.organization.totalScore();
            lblScore.Text = $"{total}";

            if (total <= 75 && total >= 56)
            {
                lblScore.Text = $"{total}\n\n\nMan the lifeboats! \n You have Titanic Syndrome";
            }
            else if (total <= 55 && total >= 36)
            {
                lblScore.Text = $"{total}\n\n\nSignificant signs of Titanic Syndrome";
            }
            else if (total <= 35 && total >= 16)
            {
                lblScore.Text = $"{total}\n\n\nReasonable change and reinvention skills, with a growing risk for Titanic Syndrome";
            }
            else if (total <= 15 && total >= 0)
            {
                lblScore.Text = $"{total}\n\n\nExcellent change and reinvention skills";
            }


            switch (Program.organization.pairedScores()[0].category)
            {
                case "aChange":
                    lblchange1.Text = "Anticipating change: " + Program.organization.pairedScores()[0].sum;
                    break;
                case "dChange":
                    lblchange1.Text = "Designing change: " + Program.organization.pairedScores()[0].sum;
                    break;
                case "iChange":
                    lblchange1.Text = "Implementing change: " + Program.organization.pairedScores()[0].sum;
                    break;
            }

            switch (Program.organization.pairedScores()[1].category)
            {
                case "aChange":
                    lblchange2.Text = "Anticipating change: " + Program.organization.pairedScores()[1].sum;
                    break;
                case "dChange":
                    lblchange2.Text = "Designing change: " + Program.organization.pairedScores()[1].sum;
                    break;
                case "iChange":
                    lblchange2.Text = "Implementing change: " + Program.organization.pairedScores()[1].sum;
                    break;
            }

            switch (Program.organization.pairedScores()[2].category)
            {
                case "aChange":
                    lblchange3.Text = "Anticipating change: " + Program.organization.pairedScores()[2].sum;
                    break;
                case "dChange":
                    lblchange3.Text = "Designing change: " + Program.organization.pairedScores()[2].sum;
                    break;
                case "iChange":
                    lblchange3.Text = "Implementing change: " + Program.organization.pairedScores()[2].sum;
                    break;
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (Program.exists)
            {
                frmSummary intro = new frmSummary();
                this.Hide();
                intro.Show();
                intro.FormClosed += (s, args) => this.Close();
            } else if (Program.per)
            {
                frmIntro_per frmSummary = new frmIntro_per();
                this.Hide();
                frmSummary.Show();
                frmSummary.FormClosed += (s, args) => this.Close();
            } else
            {
                frmExit frmExit = new frmExit();    
                this.Hide();
                frmExit.Show();
                frmExit.FormClosed += (s, args) => this.Close();
            }
            
        }

        private void rjbReturn_Click(object sender, EventArgs e)
        {
            frmTest_org test = new frmTest_org();
            this.Hide();
            test.Show();
            test.FormClosed += (s, args) => this.Close();
        }
    }
}
