using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataGrid;
using System.Xml.Linq;
using OfficeOpenXml;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace TitanicSyndrome
{
    public partial class frmEdit : Form
    {
        private string excelFilePath = Program.filepath;
        private DataGridViewRow rowData;

        public frmEdit(DataGridViewRow row)
        {
            InitializeComponent();
            rowData = row;
            LoadData();
        }

        private void LoadData()
        {
            rtbID.Text = rowData.Cells["ID"].Value?.ToString();
            rtbName.Text = rowData.Cells["Name"].Value?.ToString();
            rtbSurname.Text = rowData.Cells["Surname"].Value?.ToString();
            edtpass.Text = rowData.Cells["Password"].Value?.ToString();
            rtbAge.Text = rowData.Cells["Age"].Value?.ToString();
            rtbNumber.Text = rowData.Cells["Cell_Number"].Value?.ToString();
            rtbGender.Text = rowData.Cells["Gender"].Value?.ToString();
            rtbEmail.Text = rowData.Cells["Email"].Value?.ToString();
            rtbCompany.Text = rowData.Cells["Company"].Value?.ToString();
            rtbJob.Text = rowData.Cells["Job_Title"].Value?.ToString();
            cbxTest.Text = rowData.Cells["Test_Type"].Value?.ToString();
            cbxAdmin.Checked = rowData.Cells["Is_Admin"].Value?.ToString() == "Yes" ? cbxAdmin.Checked = true : cbxAdmin.Checked = false;    
            rtbachange.Text = rowData.Cells["aChange_Score"].Value?.ToString();
            rtbdchange.Text = rowData.Cells["dChange_Score"].Value?.ToString();
            rtbichange.Text = rowData.Cells["iChange_Score"].Value?.ToString();
            rtbTotal.Text = rowData.Cells["Total_Score"].Value?.ToString();
        }


        private void frmEdit_Load(object sender, EventArgs e)
        {

        }

        private int FindRowIndex(ExcelWorksheet worksheet, string id)
        {
            for (int row = 2; row <= worksheet.Dimension.Rows; row++)
            {
                if (worksheet.Cells[row, 1].Value?.ToString() == id)
                {
                    return row;
                }
            }
            return -1;
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            try
            {
                using (ExcelPackage package = new ExcelPackage(new FileInfo(excelFilePath)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                    int rowIndex = FindRowIndex(worksheet, rowData.Cells["ID"].Value?.ToString());
                    if (rowIndex > 0)
                    {
                        // allows admin to change the ID number for that user, but checks if the ID isn't already in the excel file before setting
                        worksheet.Cells[rowIndex, 2].Value = rtbName.Text;
                        worksheet.Cells[rowIndex, 3].Value = rtbSurname.Text;
                        worksheet.Cells[rowIndex, 4].Value = edtpass.Text;
                        worksheet.Cells[rowIndex, 5].Value = rtbAge.Text;
                        worksheet.Cells[rowIndex, 6].Value = rtbEmail.Text;
                        worksheet.Cells[rowIndex, 7].Value = rtbGender.Text;
                        worksheet.Cells[rowIndex, 8].Value = rtbNumber.Text;
                        worksheet.Cells[rowIndex, 9].Value = rtbJob.Text;   
                        worksheet.Cells[rowIndex, 10].Value = rtbCompany.Text;
                        worksheet.Cells[rowIndex, 11].Value = rtbachange.Text;
                        worksheet.Cells[rowIndex, 12].Value = rtbdchange.Text;
                        worksheet.Cells[rowIndex, 13].Value = rtbichange.Text;
                        worksheet.Cells[rowIndex, 14].Value = rtbTotal.Text;
                        worksheet.Cells[rowIndex, 15].Value = cbxTest.Text;
                        worksheet.Cells[rowIndex, 16].Value = cbxAdmin.Checked ? "Yes" : "No";
                        worksheet.Cells[rowIndex, 17].Value = cbxTest.Text == "Both" ? "Yes" : "No";
                        package.Save();
                    }
                    else
                    {
                        MessageBox.Show("Row not found in Excel.");
                    }
                }

                MessageBox.Show("Data updated successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }
    }
}