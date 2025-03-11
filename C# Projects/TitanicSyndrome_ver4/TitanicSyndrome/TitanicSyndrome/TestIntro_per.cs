using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TitanicSyndrome
{
    public partial class frmIntro_per : Form
    {
        public frmIntro_per()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
        }

        private void frmIntro_Load(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            frmPer1 test = new frmPer1();    
            this.Hide();
            test.Show();
            test.FormClosed += (s, args) => this.Close();
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
