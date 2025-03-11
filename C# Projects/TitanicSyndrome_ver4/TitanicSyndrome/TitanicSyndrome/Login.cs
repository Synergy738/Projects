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
using OfficeOpenXml;
using System.IO;



namespace TitanicSyndrome
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private string actualPassword = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void readFile()
        {
            // Open the Excel file and read the data
            FileInfo fileInfo = new FileInfo(Program.filepath);
            using (var package = new ExcelPackage(fileInfo))
            {
                // Assume that the first sheet contains the user data
                var worksheet = package.Workbook.Worksheets[0];

                bool userFound = false;

                // Loop through rows (starting from row 2 to skip headers)
                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    // Assuming the username is in column 1 and the password is in column 2
                    string storedUsername = worksheet.Cells[row, 6].Text;
                    string storedPassword = worksheet.Cells[row, 4].Text;

                    // Check if the entered username and password match
                    if (edtusername.Text == storedUsername && actualPassword == storedPassword)
                    {
                        userFound = true;                            
                            
                        if (worksheet.Cells[row, 17].Text == "Yes")
                        {
                            Program.per = true;
                            Program.org = true;

                            //populating objects with user data
                            Program.person.name = worksheet.Cells[row, 2].Text;
                            Program.person.surname = worksheet.Cells[row, 3].Text;
                            Program.person.password = worksheet.Cells[row, 4].Text;
                            Program.person.age = int.Parse(worksheet.Cells[row, 5].Text);
                            Program.person.email = worksheet.Cells[row, 6].Text;
                            Program.person.gender = worksheet.Cells[row, 7].Text;
                            Program.person.phone = worksheet.Cells[row, 8].Text;
                            Program.person.job = worksheet.Cells[row, 9].Text;
                            Program.person.company = worksheet.Cells[row, 10].Text;
                            int achange = Convert.ToInt32(worksheet.Cells[row, 11].Value);
                            int ichange = Convert.ToInt32(worksheet.Cells[row, 12].Value);
                            int dchange = Convert.ToInt32(worksheet.Cells[row, 13].Value);
                            Program.person.calcScores(achange, dchange, ichange);

                            Program.organization = Program.person;
                            int orgachange = Convert.ToInt32(worksheet.Cells[row + 1, 11].Value);
                            int orgichange = Convert.ToInt32(worksheet.Cells[row + 1, 12].Value);
                            int orgdchange = Convert.ToInt32(worksheet.Cells[row + 1, 13].Value);
                            Program.organization.calcScores(orgachange, orgdchange, orgichange);

                            frmSummary_org frmSum = new frmSummary_org();
                            this.Hide();
                            frmSum.Show();
                            frmSum.FormClosed += (s, args) => this.Close();

                        } else if (worksheet.Cells[row, 15].Text == "Personal")
                        {
                            Program.per = true;
                            Program.person.name = worksheet.Cells[row, 2].Text;
                            Program.person.surname = worksheet.Cells[row, 3].Text;
                            Program.person.password = worksheet.Cells[row, 4].Text;
                            Program.person.age = Convert.ToInt32(worksheet.Cells[row, 5].Value);
                            Program.person.email = worksheet.Cells[row, 6].Text;
                            Program.person.gender = worksheet.Cells[row, 7].Text;
                            Program.person.phone = worksheet.Cells[row, 8].Text;
                            Program.person.job = worksheet.Cells[row, 9].Text;
                            Program.person.company = worksheet.Cells[row, 10].Text;
                            int achange = Convert.ToInt32(worksheet.Cells[row, 11].Value);
                            int ichange = Convert.ToInt32(worksheet.Cells[row, 12].Value);
                            int dchange = Convert.ToInt32(worksheet.Cells[row, 13].Value);
                            Program.person.calcScores(achange, dchange, ichange);

                            frmSummary frmSum = new frmSummary();
                            this.Hide();
                            frmSum.Show();
                            frmSum.FormClosed += (s, args) => this.Close();
                        } else
                        {
                            Program.org = true;
                            Program.organization.name = worksheet.Cells[row, 2].Text;
                            Program.organization.surname = worksheet.Cells[row, 3].Text;
                            Program.organization.password = worksheet.Cells[row, 4].Text;
                            Program.organization.age = Convert.ToInt32(worksheet.Cells[row, 5].Value);
                            Program.organization.email = worksheet.Cells[row, 6].Text;
                            Program.organization.gender = worksheet.Cells[row, 7].Text;
                            Program.organization.phone = worksheet.Cells[row, 8].Text;
                            Program.organization.job = worksheet.Cells[row, 9].Text;
                            Program.organization.company = worksheet.Cells[row, 10].Text;
                            int achange = Convert.ToInt32(worksheet.Cells[row, 11].Value);
                            int ichange = Convert.ToInt32(worksheet.Cells[row, 12].Value);
                            int dchange = Convert.ToInt32(worksheet.Cells[row, 13].Value);
                            Program.organization.calcScores(achange, dchange, ichange);

                            frmSummary_org frmSum = new frmSummary_org();
                            this.Hide();
                            frmSum.Show();
                            frmSum.FormClosed += (s, args) => this.Close();
                        }
                        break;
                    }
                }

                // If user not found, prompt to register
                if (!userFound)
                {
                    MessageBox.Show("Invalid username or password. Please register.");
                }
                
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (actualPassword == "1234" && edtusername.Text == "Admin")
            {
                DatabaseUI db = new DatabaseUI();
                this.Hide();
                db.Show();
                db.FormClosed += (s, args) => this.Close();
            } else if (Program.per || Program.org)
            {
                if (Program.per && !Program.org)
                {
                    frmIntro_per intro = new frmIntro_per();
                    this.Hide();
                    intro.Show();
                    intro.FormClosed += (s, args) => this.Close();
                }
                else
                {
                    frmTestIntro_org intro = new frmTestIntro_org();
                    this.Hide();
                    intro.Show();
                    intro.FormClosed += (s, args) => this.Close();
                }
            } else
            {
                readFile();
                Program.exists = true;
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            frmSurveyorg frmWho = new frmSurveyorg();   
            this.Hide();
            frmWho.Show();
            frmWho.FormClosed += (s, args) => this.Close();
        }

        private void edtpass_TextChanged(object sender, EventArgs e)
        {            
            int selectionStart = edtpass.SelectionStart;

            // Store the actual text
            if (edtpass.Text.Length > actualPassword.Length)
            {
                actualPassword += edtpass.Text.Substring(actualPassword.Length);
            }
            else if (edtpass.Text.Length < actualPassword.Length)
            {
                actualPassword = actualPassword.Substring(0, edtpass.Text.Length);
            }

            // Replace visible text with '*'
            edtpass.Text = new string('*', actualPassword.Length);
            edtpass.SelectionStart = selectionStart; // Restore cursor position
        

    }
}
}
