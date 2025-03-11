using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TitanicSyndrome
{
    public partial class frmSurveyorg : Form
    {
        public frmSurveyorg()
        {
            InitializeComponent();
        }

        private string actualPassword = "";

        private bool ValidEmail(string email)
        {
            string emailRegex = "^[a-zA-Z0-9_+&*-]+(?:\\.[a-zA-Z0-9_+&*-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,7}$";
            return Regex.IsMatch(email, emailRegex);
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            string name = "";
            string surname = "";
            string email = "";
            string phone = "";
            int age = 0;
            bool valid = true;
            string gender = "";
            string job = rtbJob.Text;
            string company = rtbCompany.Text;

            //validating inputs
            if (rtbName.Text == "" || rtbNumber.Text == "" || rtbGender.Text == "" || rtbSurname.Text == "" || rtbAge.Text == "" || rtbEmail.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }

            if (valid)
            {
                try
                {
                    name = rtbName.Text;
                    surname = rtbSurname.Text;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please provide your name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valid = false;
                }
            }

            if (valid)
            {
                try
                {
                    if (!ValidEmail(rtbEmail.Text))
                    {
                        MessageBox.Show("Please provide a valid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        valid = false;
                    }
                    email = rtbEmail.Text;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please provide a valid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valid = false;
                }
            }

            if (valid)
            {
                try
                {
                    if (rtbNumber.Text.Length != 10)
                    {
                        MessageBox.Show("Please provide a valid phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        valid = false;
                    }
                    phone = rtbNumber.Text;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please provide a valid phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valid = false;
                }

            }

            if (valid)
            {
                try
                {
                    age = int.Parse(rtbAge.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please provide a number when indicating your age", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valid = false;
                }
            }
            if (valid)
            {
                try
                {
                    string userGender = rtbGender.Text.ToUpper().Trim();
                    if ((userGender[0] != 'M') & (userGender[0] != 'F'))
                    {
                        MessageBox.Show("Please enter either 'M' or 'F' when indacting your gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        valid = false;
                    }
                    gender = userGender;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter either 'M' or 'F' when indacting your gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valid = false;
                }
            }

            if (valid)
            {
                try
                {
                    job = rtbJob.Text;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please provide a valid job title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valid = false;
                }
            }

            if (valid)
            {
                try
                {
                    company = rtbCompany.Text;
                } catch (FormatException ex)
                {
                    MessageBox.Show("Please provide a valid company name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valid = false;
                }
            }

            if (valid)
            {
                try
                {   if (Program.org)
                    {
                        Program.organization.name = name;
                        Program.organization.surname = surname;
                        Program.organization.password = actualPassword;
                        Program.organization.email = email;
                        Program.organization.phone = phone;
                        Program.organization.age = age;
                        Program.organization.gender = gender;
                        Program.organization.job = job;
                        Program.organization.company = company;
                    }

                    if (Program.per)
                    {
                        Program.person.name = name;
                        Program.person.surname = surname;
                        Program.person.password = actualPassword;
                        Program.person.email = email;
                        Program.person.phone = phone;
                        Program.person.age = age;
                        Program.person.job = job;
                        Program.person.company = company;
                        Program.person.gender = gender;
                    }

                }
                catch (FormatException ex)
                {
                    MessageBox.Show($"Error creating person object: Please provide a number when indicating your age", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                frmLogin who = new frmLogin();
                this.Hide();
                who.Show();
                who.FormClosed += (s, args) => this.Close();
            }
        }

        private void rjbReturn_Click(object sender, EventArgs e)
        {
            frmLogin who = new frmLogin();
            this.Hide();
            who.Show();
            who.FormClosed += (s, args) => this.Close();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            Program.per = true;
            btnme.BackColor = Color.IndianRed;
            btnboth.BackgroundImage = null;
            btnboth.BackColor = Color.Black;
            btnorg.BackColor = Color.Black;

        }

        private void btnboth_Click(object sender, EventArgs e)
        {
            Program.per = true;
            Program.org = true;
            btnboth.BackgroundImage = Image.FromFile("C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\rjbutton.png");
            btnme.BackColor = Color.Black;
            btnorg.BackColor = Color.Black;
        }

        private void btnorg_Click(object sender, EventArgs e)
        {
            Program.org = true;
            btnorg.BackColor = Color.RoyalBlue;
            btnme.BackColor = Color.Black;
            btnboth.BackgroundImage = null;
            btnboth.BackColor = Color.Black;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
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
