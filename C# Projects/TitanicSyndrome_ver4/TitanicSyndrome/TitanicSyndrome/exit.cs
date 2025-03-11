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
    public partial class frmExit : Form
    {
        public frmExit()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {                  
            //MessageBox.Show("Uploading results to database...", "Uploading");                   
            //Program.sendEmail();
            //MessageBox.Show("Results uploaded successfully!", "Success"); 
            Application.Exit();
        }

        private void frmExit_Load(object sender, EventArgs e)
        {
            if (!Program.exists)
            {
                Program.createExcelFile();
            }
        }
    }
}
