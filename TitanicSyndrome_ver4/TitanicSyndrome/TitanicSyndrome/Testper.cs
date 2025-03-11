using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TitanicSyndrome
{
    public partial class frmPer1 : Form
    {
        public frmPer1()
        {
            InitializeComponent();
        }

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
            if (Program.percount < 5)
            {
                //index into appropriate list and change buttons
                switch (Program.person.aChange[Program.percount])
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
            else if (Program.percount >= 5 && Program.percount < 10)
            {
                switch (Program.person.dChange[Program.percount - 5])
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
            else if (Program.percount >= 10)
            {
                switch (Program.person.iChange[Program.percount - 10])
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
                "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\perachange2.png",
                "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\perachange3.png",
                "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\perachange4.png",
                "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\perachange5.png",
                "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\perdchange1.png",
                "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\perdchange2.png",
                "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\perdchange3.png",
                "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\perdchange4.png",
                "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\perdchange5.png",
                "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\perichange1.png",
                "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\perichange2.png",
                "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\perichange3.png",
                "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\perichange4.png",
                "C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\perichange5.png"
            };

            if (!Program.percomplete)
            {
                Program.percount++;
            }
            
            this.BackgroundImage = Image.FromFile(imagePaths[Program.percount - 1]);

            if (Program.percount < 5)
            {
                btnNext.BackColor = Color.RoyalBlue;
                btn0.BackgroundColor = Color.SteelBlue;
                btn1.BackgroundColor = Color.SteelBlue;
                btn2.BackgroundColor = Color.SteelBlue;
                btn3.BackgroundColor = Color.SteelBlue;
                btn4.BackgroundColor = Color.SteelBlue;
                btn5.BackgroundColor = Color.SteelBlue;
            }
            else if (Program.percount >= 5 && Program.percount < 10)
            {
                btnNext.BackColor = Color.Red;
                btn0.BackgroundColor = Color.IndianRed;
                btn1.BackgroundColor = Color.IndianRed;
                btn2.BackgroundColor = Color.IndianRed;
                btn3.BackgroundColor = Color.IndianRed;
                btn4.BackgroundColor = Color.IndianRed;
                btn5.BackgroundColor = Color.IndianRed;
            }
            else if (Program.percount >= 10)
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
        private void rjButton1_Click(object sender, EventArgs e)
        {
            clicked = true;
            // Updates list according to percount
            if (Program.percount < 5)
            {
                Program.person.aChange[Program.percount] = 0;
                btn0.BackColor = Color.SteelBlue;

            } else if (Program.percount > 4 && Program.percount < 10)
            {
                Program.person.dChange[Program.percount - 5] = 0;
                btn0.BackColor = Color.IndianRed;
            } else
            {
                Program.person.iChange[Program.percount - 10] = 0;
                btn0.BackColor = Color.DarkGreen;
            }          
            UpdateButtonStyles(btn0);
        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            clicked = true;
            // Updates list according to percount
            if (Program.percount < 5)
            {
                Program.person.aChange[Program.percount] = 1;
                btn1.BackColor = Color.SteelBlue;
            }
            else if (Program.percount > 4 && Program.percount < 10)
            {
                Program.person.dChange[Program.percount - 5] = 1;
                btn1.BackColor = Color.IndianRed;
            }
            else
            {
                Program.person.iChange[Program.percount - 10] = 1;
                btn1.BackColor = Color.DarkGreen;
            }
            UpdateButtonStyles(btn1);
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            clicked = true;
            // Updates list according to percount
            if (Program.percount < 5)
            {
                Program.person.aChange[Program.percount] = 2;
                btn2.BackColor = Color.SteelBlue;

            }
            else if (Program.percount > 4 && Program.percount < 10)
            {
                Program.person.dChange[Program.percount - 5] = 2;
                btn2.BackColor = Color.IndianRed;
            }
            else
            {
                Program.person.iChange[Program.percount - 10] = 2;
                btn2.BackColor = Color.DarkGreen;
            }
            UpdateButtonStyles(btn2);
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            clicked = true;
            // Updates list according to percount
            if (Program.percount < 5)
            {
                Program.person.aChange[Program.percount] = 3;
                btn3.BackColor = Color.SteelBlue;
            }
            else if (Program.percount > 4 && Program.percount < 10)
            {
                Program.person.dChange[Program.percount - 5] = 3;
                btn3.BackColor = Color.IndianRed;
            }
            else
            {
                Program.person.iChange[Program.percount - 10] = 3;
                btn3.BackColor = Color.DarkGreen;
            }
            UpdateButtonStyles(btn3);
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            clicked = true;
            // Updates list according to percount
            if (Program.percount < 5)
            {
                Program.person.aChange[Program.percount] = 4;
                btn4.BackColor = Color.SteelBlue;
            }
            else if (Program.percount > 4 && Program.percount < 10)
            {
                Program.person.dChange[Program.percount - 5] = 4;
                btn4.BackColor = Color.IndianRed;
            }
            else
            {
                Program.person.iChange[Program.percount - 10] = 4;
                btn4.BackColor = Color.DarkGreen;
            }
            UpdateButtonStyles(btn4);
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            clicked = true;
            // Updates list according to percount
            if (Program.percount < 5)
            {
                Program.person.aChange[Program.percount] = 5;
                btn5.BackColor = Color.SteelBlue;
            }
            else if (Program.percount > 4 && Program.percount < 10)
            {
                Program.person.dChange[Program.percount - 5] = 5;
                btn5.BackColor = Color.IndianRed;
            }
            else
            {
                Program.person.iChange[Program.percount - 10] = 5;
                btn5.BackColor = Color.DarkGreen;
            }
            UpdateButtonStyles(btn5);
        }

        private void rjbReturn_Click(object sender, EventArgs e)
        {
            if (Program.percount == 0)
            {
                frmIntro_per intro = new frmIntro_per();
                this.Hide();
                intro.Show();
                intro.FormClosed += (s, args) => this.Close();
            } else if (Program.percount == 1)
            {
                Program.percount--;
                this.BackgroundImage = Image.FromFile("C:\\Users\\Blu\\Documents\\C#\\TitanicSyndrome\\TitanicSyndrome_ver3\\perachange1.png");
                retrieveInfo();
            } else
            {
                Program.percount -= 2;
                changeInfo();
                retrieveInfo();
            }
        }

       

        private void rjButton7_Click(object sender, EventArgs e)
        {
                if (!clicked)
            {
                MessageBox.Show("Select an option to continue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Program.percount < 14 && clicked)
                {
                    changeInfo();
                    //clicked = false;
                } else if (Program.percount == 14)
                {
                    btnNext.Text = "Submit";
                    frmSummary summary = new frmSummary();
                    this.Hide();
                    summary.Show();
                    summary.FormClosed += (s, args) => this.Close();
                }
                else
                {
                    MessageBox.Show("Select an option to continue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }            
        }

        private void autoInfo()
        {
            // Check if the form count is greater than 0 to prevent automatic selection of the first button
            if (Program.percount > 0)
            {
                // Determine which array to work with based on percount value
                int index = Program.percount - 1;
                List<int> changeArray = new List<int>();

                if (Program.percount < 5)
                {
                    changeArray = Program.person.aChange;
                }
                else if (Program.percount >= 5 && Program.percount < 10)
                {
                    changeArray = Program.person.dChange;
                }
                else if (Program.percount >= 10)
                {
                    changeArray = Program.person.iChange;
                }

                // Preselect buttons based on the values in the corresponding changeArray
                for (int i = 0; i < changeArray.Count; i++)
                {
                    // Skip the first one in the aChange array if percount is 0
                    if (Program.percount == 0 && i == 0) continue;

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


        private void frmPer1_Load(object sender, EventArgs e)
        {
            autoInfo();
        }
    }
}
