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
    public partial class frmTest_org : Form
    {
        public frmTest_org()
        {
            InitializeComponent();
        }

        // Functions
        private bool clicked = true;

        private void noSelection(char l)
        {
            switch (l)
            {
                case 'a':
                    {
                        btnNext.BackColor = Color.RoyalBlue;
                        btn0.BackgroundColor = Color.SteelBlue;
                        btn1.BackgroundColor = Color.SteelBlue;
                        btn2.BackgroundColor = Color.SteelBlue;
                        btn3.BackgroundColor = Color.SteelBlue;
                        btn4.BackgroundColor = Color.SteelBlue;
                        btn5.BackgroundColor = Color.SteelBlue;
                        break;
                    }
                case 'd':
                    {
                        btnNext.BackColor = Color.Red;
                        btn0.BackgroundColor = Color.IndianRed;
                        btn1.BackgroundColor = Color.IndianRed;
                        btn2.BackgroundColor = Color.IndianRed;
                        btn3.BackgroundColor = Color.IndianRed;
                        btn4.BackgroundColor = Color.IndianRed;
                        btn5.BackgroundColor = Color.IndianRed;
                        break;
                    }
                case 'i':
                    {
                        btnNext.BackColor = Color.DarkGreen;
                        btn0.BackgroundColor = Color.DarkGreen;
                        btn1.BackgroundColor = Color.DarkGreen;
                        btn2.BackgroundColor = Color.DarkGreen;
                        btn3.BackgroundColor = Color.DarkGreen;
                        btn4.BackgroundColor = Color.DarkGreen;
                        btn5.BackgroundColor = Color.DarkGreen;
                        break;
                    }
            }
        }

        private void retrieveInfo()
        {
            if (Program.orgcount < 5)
            {
                //index into appropriate list and change buttons
                switch (Program.organization.aChange[Program.orgcount])
                {
                    case 0:
                        {
                            UpdateButtonStyles(btn0);
                            clicked = true;
                            break;
                        }
                    case 1:
                        {
                            UpdateButtonStyles(btn1);
                            clicked = true;
                            break;
                        }
                    case 2:
                        {
                            UpdateButtonStyles(btn2);
                            clicked = true;
                            break;
                        }
                    case 3:
                        {
                            UpdateButtonStyles(btn3);
                            clicked = true;
                            break;
                        }
                    case 4:
                        {
                            UpdateButtonStyles(btn4);
                            clicked = true;
                            break;
                        }
                    case 5:
                        {
                            UpdateButtonStyles(btn5);
                            clicked = true;
                            break;
                        }
                    case 6:
                        {
                            noSelection('a');
                            break;
                        }
                }
            }
            else if (Program.orgcount >= 5 && Program.orgcount < 10)
            {
                switch (Program.organization.dChange[Program.orgcount - 5])
                {
                    case 0:
                        {
                            UpdateButtonStyles(btn0);
                            clicked = true;
                            break;
                        }
                    case 1:
                        {
                            UpdateButtonStyles(btn1);
                            clicked = true;
                            break;
                        }
                    case 2:
                        {
                            UpdateButtonStyles(btn2);
                            clicked = true;
                            break;
                        }
                    case 3:
                        {
                            UpdateButtonStyles(btn3);
                            clicked = true;
                            break;
                        }
                    case 4:
                        {
                            UpdateButtonStyles(btn4);
                            clicked = true;
                            break;
                        }
                    case 5:
                        {
                            UpdateButtonStyles(btn5);
                            clicked = true;
                            break;
                        }
                    case 6:
                        {
                            noSelection('d');
                            break;
                        }
                }
            }
            else if (Program.orgcount >= 10)
            {
                switch (Program.organization.iChange[Program.orgcount - 10])
                {
                    case 0:
                        {
                            UpdateButtonStyles(btn0);
                            clicked = true;
                            break;
                        }
                    case 1:
                        {
                            UpdateButtonStyles(btn1);
                            clicked = true;
                            break;
                        }
                    case 2:
                        {
                            UpdateButtonStyles(btn2);
                            clicked = true;
                            break;
                        }
                    case 3:
                        {
                            UpdateButtonStyles(btn3);
                            clicked = true;
                            break;
                        }
                    case 4:
                        {
                            UpdateButtonStyles(btn4);
                            clicked = true;
                            break;
                        }
                    case 5:
                        {
                            UpdateButtonStyles(btn5);
                            clicked = true;
                            break;
                        }
                    case 6:
                        {
                            noSelection('i');
                            break;
                        }
                }
            }
        }

        private void changeInfo()
        {
            string[] imagePaths =
            {
                "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\orgachange2.png",
                "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\orgachange3.png",
                "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\orgachange4.png",
                "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\orgachange5.png",
                "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\orgdchange1.png",
                "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\orgdchange2.png",
                "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\orgdchange3.png",
                "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\orgdchange4.png",
                "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\orgdchange5.png",
                "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\orgichange1.png",
                "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\orgichange2.png",
                "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\orgichange3.png",
                "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\orgichange4.png",
                "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\orgichange5.png"
            };
            if (!Program.orgcomplete)
            {
                Program.orgcount++;
            }

            this.BackgroundImage = Image.FromFile(imagePaths[Program.orgcount - 1]);
            this.BackgroundImageLayout = ImageLayout.Stretch;

            if (Program.orgcount < 5)
            {
                btnNext.BackColor = Color.RoyalBlue;
                btn0.BackgroundColor = Color.SteelBlue;
                btn1.BackgroundColor = Color.SteelBlue;
                btn2.BackgroundColor = Color.SteelBlue;
                btn3.BackgroundColor = Color.SteelBlue;
                btn4.BackgroundColor = Color.SteelBlue;
                btn5.BackgroundColor = Color.SteelBlue;
            }
            else if (Program.orgcount >= 5 && Program.orgcount < 10)
            {
                btnNext.BackColor = Color.Red;
                btn0.BackgroundColor = Color.IndianRed;
                btn1.BackgroundColor = Color.IndianRed;
                btn2.BackgroundColor = Color.IndianRed;
                btn3.BackgroundColor = Color.IndianRed;
                btn4.BackgroundColor = Color.IndianRed;
                btn5.BackgroundColor = Color.IndianRed;
            }
            else if (Program.orgcount >= 10)
            {
                btnNext.BackColor = Color.DarkGreen;
                btn0.BackgroundColor = Color.DarkGreen;
                btn1.BackgroundColor = Color.DarkGreen;
                btn2.BackgroundColor = Color.DarkGreen;
                btn3.BackgroundColor = Color.DarkGreen;
                btn4.BackgroundColor = Color.DarkGreen;
                btn5.BackgroundColor = Color.DarkGreen;
            }

        }
        private void UpdateButtonStyles(Button selected)
        {
            List<Button> buttons = new List<Button> { btn0, btn1, btn2, btn3, btn4, btn5 };

            foreach (Button btn in buttons)
            {
                if (btn != selected)
                {
                    btn.BackColor = Color.White;
                }
            }
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            clicked = true;
            // Updates list according to orgcount
            if (Program.orgcount < 5)
            {
                Program.organization.aChange[Program.orgcount] = 0;
                btn0.BackColor = Color.SteelBlue;

            }
            else if (Program.orgcount > 4 && Program.orgcount < 10)
            {
                Program.organization.dChange[Program.orgcount - 5] = 0;
                btn0.BackColor = Color.IndianRed;
            }
            else
            {
                Program.organization.iChange[Program.orgcount - 10] = 0;
                btn0.BackColor = Color.DarkGreen;
            }
            UpdateButtonStyles(btn0);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            clicked = true;
            // Updates list according to orgcount
            if (Program.orgcount < 5)
            {
                Program.organization.aChange[Program.orgcount] = 1;
                btn1.BackColor = Color.SteelBlue;
            }
            else if (Program.orgcount > 4 && Program.orgcount < 10)
            {
                Program.organization.dChange[Program.orgcount - 5] = 1;
                btn1.BackColor = Color.IndianRed;
            }
            else
            {
                Program.organization.iChange[Program.orgcount - 10] = 1;
                btn1.BackColor = Color.DarkGreen;
            }
            UpdateButtonStyles(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            clicked = true;
            // Updates list according to orgcount
            if (Program.orgcount < 5)
            {
                Program.organization.aChange[Program.orgcount] = 2;
                btn2.BackColor = Color.SteelBlue;

            }
            else if (Program.orgcount > 4 && Program.orgcount < 10)
            {
                Program.organization.dChange[Program.orgcount - 5] = 2;
                btn2.BackColor = Color.IndianRed;
            }
            else
            {
                Program.organization.iChange[Program.orgcount - 10] = 2;
                btn2.BackColor = Color.DarkGreen;
            }
            UpdateButtonStyles(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            clicked = true;
            // Updates list according to orgcount
            if (Program.orgcount < 5)
            {
                Program.organization.aChange[Program.orgcount] = 3;
                btn3.BackColor = Color.SteelBlue;
            }
            else if (Program.orgcount > 4 && Program.orgcount < 10)
            {
                Program.organization.dChange[Program.orgcount - 5] = 3;
                btn3.BackColor = Color.IndianRed;
            }
            else
            {
                Program.organization.iChange[Program.orgcount - 10] = 3;
                btn3.BackColor = Color.DarkGreen;
            }
            UpdateButtonStyles(btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            clicked = true;
            // Updates list according to orgcount
            if (Program.orgcount < 5)
            {
                Program.organization.aChange[Program.orgcount] = 4;
                btn4.BackColor = Color.SteelBlue;
            }
            else if (Program.orgcount > 4 && Program.orgcount < 10)
            {
                Program.organization.dChange[Program.orgcount - 5] = 4;
                btn4.BackColor = Color.IndianRed;
            }
            else
            {
                Program.organization.iChange[Program.orgcount - 10] = 4;
                btn4.BackColor = Color.DarkGreen;
            }
            UpdateButtonStyles(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            clicked = true;
            // Updates list according to orgcount
            if (Program.orgcount < 5)
            {
                Program.organization.aChange[Program.orgcount] = 5;
                btn5.BackColor = Color.SteelBlue;
            }
            else if (Program.orgcount > 4 && Program.orgcount < 10)
            {
                Program.organization.dChange[Program.orgcount - 5] = 5;
                btn5.BackColor = Color.IndianRed;
            }
            else
            {
                Program.organization.iChange[Program.orgcount - 10] = 5;
                btn5.BackColor = Color.Green;
            }
            UpdateButtonStyles(btn5);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!clicked)
            {
                MessageBox.Show("Select an option to continue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Program.orgcount == 14)
            {
                btnNext.Text = "Submit";
                Program.orgcomplete = true;
                frmSummary_org summary = new frmSummary_org();
                this.Hide();
                summary.Show();
                summary.FormClosed += (s, args) => this.Close();
            }
            else if (Program.orgcount < 14 && clicked)
            {              
                changeInfo();
               // clicked = false;                           
            }
        }

        private void rjbReturn_Click(object sender, EventArgs e)
        {
            if (Program.orgcount == 0)
            {
                frmIntro_per intro = new frmIntro_per();
                this.Hide();
                intro.Show();
                intro.FormClosed += (s, args) => this.Close();
            }
            else if (Program.orgcount == 1)
            {
                Program.orgcount--;
                this.BackgroundImage = Image.FromFile("C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\orgachange1.png");
                retrieveInfo();
            }
            else
            {
                Program.orgcount -= 2;
                changeInfo();
                retrieveInfo();
            }
        }
        private void autoInfo()
        {
            // Check if the form count is greater than 0 to prevent automatic selection of the first button
            if (Program.orgcount > 0)
            {
                // Determine which array to work with based on percount value
                int index = Program.orgcount - 1;
                List<int> changeArray = new List<int>();

                if (Program.orgcount < 5)
                {
                    changeArray = Program.person.aChange;
                }
                else if (Program.orgcount >= 5 && Program.orgcount < 10)
                {
                    changeArray = Program.person.dChange;
                }
                else if (Program.orgcount >= 10)
                {
                    changeArray = Program.person.iChange;
                }

                // Preselect buttons based on the values in the corresponding changeArray
                for (int i = 0; i < changeArray.Count; i++)
                {
                    // Skip the first one in the aChange array if percount is 0
                    if (Program.orgcount == 0 && i == 0) continue;

                    switch (changeArray[i])
                    {
                        case 0:
                            UpdateButtonStyles(btn0);
                            break;
                        case 1:
                            UpdateButtonStyles(btn1);
                            break;
                        case 2:
                            UpdateButtonStyles(btn2);
                            break;
                        case 3:
                            UpdateButtonStyles(btn3);
                            break;
                        case 4:
                            UpdateButtonStyles(btn4);
                            break;
                        case 5:
                            UpdateButtonStyles(btn5);
                            break;
                    }
                }
            }
        }
        private void frmTest_org_Load(object sender, EventArgs e)
        {
            autoInfo();
        }
    }
}
