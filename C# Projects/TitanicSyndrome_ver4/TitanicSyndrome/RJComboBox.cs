using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace TitanicSyndrome
{
    internal class RJComboBox
    {
        public bool Expand = false;
        private void selectDrowdown_Tick(object sender, EventArgs e)
        {
            if (Expand == false)
            {
                dropdown.Height += 15;
                if (dropdown.Height >= dropdown.MaximumSize.Height)
                {

                    selectDrowdown.Stop();
                    Expand = true;
                }
            }
            else
            {
                dropdown.Height -= 15;
                if (dropdown.Height <= dropdown.MinimumSize.Height)
                {

                    selectDrowdown.Stop();
                    Expand = false;
                }
            }
        }

        private void Select_Click(object sender, EventArgs e)
        {
            selectDrowdown.Start();
            Console.WriteLine(Expand);
            Console.ReadLine();
        }
    }
}
