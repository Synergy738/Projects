using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace TitanicSyndrome
{
    public partial class frmTestIntro_org : Form
    {
        public frmTestIntro_org()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            frmTest_org test = new frmTest_org();
            this.Hide();
            test.Show();
            test.FormClosed += (s, args) => this.Close();
        }

        private void frmTestIntro_org_Load(object sender, EventArgs e)
        {

        }

        private void rjbReturn_Click(object sender, EventArgs e)
        {
            frmSurveyorg who = new frmSurveyorg();
            this.Hide();
            who.Show();
            who.FormClosed += (s, args) => this.Close();
        }
    }
}
