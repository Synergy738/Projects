using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using Font = System.Drawing.Font;

namespace TitanicSyndrome
{
    public partial class DatabaseUI : Form
    {
        public DatabaseUI()
        {
            InitializeComponent();
        }

        private static System.Data.DataTable db = new System.Data.DataTable();

        private void DatabaseUI_Load(object sender, EventArgs e)
        {
            load(Program.filepath);
            ResetTable();
            CalculateAverages();
        }

        private void ChangePieChart(float aav, float dav, float iav)
        {
            chart1.Series.Clear();

            if (chart1.Titles.Count == 0)
            {
                Title title = new Title("Average Scores for each change type");
                title.Font = new Font("Arial", 20, FontStyle.Bold);
                chart1.Titles.Add(title);
            }
            else
            {
                chart1.Titles[0].Font = new Font("Arial", 20, FontStyle.Bold);
            }

            chart1.Series.Add("s1");
            chart1.Series["s1"].ChartType = SeriesChartType.Pie;
            chart1.Series["s1"].Font = new Font("Arial", 15, FontStyle.Regular);
            chart1.Series["s1"].Points.AddXY($"{aav:F2}", aav);
            chart1.Series["s1"].Points.AddXY($"{dav:F2}", dav);
            chart1.Series["s1"].Points.AddXY($"{iav:F2}", iav);

            chart1.Series["s1"].Points[0].Color = Color.RoyalBlue;
            chart1.Series["s1"].Points[0].LegendText = "Anticipating change";
            chart1.Series["s1"].Points[1].Color = Color.IndianRed;
            chart1.Series["s1"].Points[1].LegendText = "Designing change";
            chart1.Series["s1"].Points[2].Color = Color.DarkGreen;
            chart1.Series["s1"].Points[2].LegendText = "Implementing change";
            // Set font size for labels
            foreach (var point in chart1.Series["s1"].Points)
            {
                point.Font = new Font("Arial", 13, FontStyle.Regular);
                point.LabelForeColor = Color.White;
            }            
        }


        private void SearchUser(string input)
        {
            DataView dv = new DataView(db);
            dv.RowFilter = $"Name LIKE '%{input}%' OR Company LIKE '%{input}%' OR Surname LIKE '%{input}%'";
            dgvusers.DataSource = dv;
        }

        private void SortByTestType(string testType)
        {
            DataView dv = new DataView(db);
            dv.RowFilter = $"Test_Type = '{testType}'";
            dgvusers.DataSource = dv;
        }

        private void SortBoth()
        {
            DataView dv = new DataView(db);
            dv.RowFilter = "Took_both_tests = 'Yes'";
            dgvusers.DataSource = dv;
        }

        private void ResetTable()
        {
            dgvusers.DataSource = db;
            CheckItems(0);
            dgvusers.Rows[0].Selected = true;
            CalculateAverages();
            edtSearhPerson.Clear();
        }

        private void CalculateAverages()
        {
            // Lists to store scores
            var aChangeScores = new List<int>();
            var dChangeScores = new List<int>();
            var iChangeScores = new List<int>();
            var totalScores = new List<int>();

            // Iterate over only the visible rows in the DataGridView
            foreach (DataGridViewRow row in dgvusers.Rows)
            {
                if (row.Visible) // Ensure the row is actually displayed
                {
                    if (int.TryParse(row.Cells["aChange_Score"].Value?.ToString(), out int aChange))
                        aChangeScores.Add(aChange);

                    if (int.TryParse(row.Cells["dChange_Score"].Value?.ToString(), out int dChange))
                        dChangeScores.Add(dChange);

                    if (int.TryParse(row.Cells["iChange_Score"].Value?.ToString(), out int iChange))
                        iChangeScores.Add(iChange);

                    if (int.TryParse(row.Cells["Total_Score"].Value?.ToString(), out int total))
                        totalScores.Add(total);
                }
            }

            // Calculate averages, handling empty lists gracefully
            double aChangeAvg = aChangeScores.Any() ? aChangeScores.Average() : 0;
            double dChangeAvg = dChangeScores.Any() ? dChangeScores.Average() : 0;
            double iChangeAvg = iChangeScores.Any() ? iChangeScores.Average() : 0;
            double totalScoreAvg = totalScores.Any() ? totalScores.Average() : 0;

            // updating pie chart
            ChangePieChart((float)aChangeAvg, (float)dChangeAvg, (float)iChangeAvg);

            // Update UI labels
            lblTotal.Text = $"Overall Average Score: {totalScoreAvg:F2}";
        }




        private void load(string path)
        {
            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;

            try
            {
                excelApp = new Excel.Application();
                workbook = excelApp.Workbooks.Open(path);
                worksheet = workbook.Sheets[1];

                db.Clear();
                db.Columns.Clear();

                int rowCount = worksheet.UsedRange.Rows.Count;
                int colCount = worksheet.UsedRange.Columns.Count;

                // Add column headers from first row
                for (int col = 1; col <= colCount; col++)
                {
                    db.Columns.Add((string)(worksheet.Cells[1, col] as Excel.Range).Value);
                }

                // Add data rows
                for (int row = 2; row <= rowCount; row++)
                {
                    DataRow dataRow = db.NewRow();
                    for (int col = 1; col <= colCount; col++)
                    {
                        dataRow[col - 1] = Convert.ToString((worksheet.Cells[row, col] as Excel.Range).Value);
                    }
                    db.Rows.Add(dataRow);
                }

                dgvusers.DataSource = db;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (worksheet != null) Marshal.ReleaseComObject(worksheet);
                if (workbook != null)
                {
                    workbook.Close(false);
                    Marshal.ReleaseComObject(workbook);
                }
                if (excelApp != null)
                {
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                }
            }
        }


        private void dgvper_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rjbPerUser_Click(object sender, EventArgs e)
        {
            SearchUser(edtSearhPerson.Text);
            CalculateAverages();
        }

        private void rjbPerComapny_Click(object sender, EventArgs e)
        {
            CalculateAverages();
        }

        private void rjbBoth_Click(object sender, EventArgs e)
        {
            SortBoth();
            CalculateAverages();
        }

        private void rjbPer_Click(object sender, EventArgs e)
        {
            SortByTestType("Personal");
            CalculateAverages();
        }

        private void rjbOrg_Click(object sender, EventArgs e)
        {
            SortByTestType("Organization");
            CalculateAverages();
        }

        private void tlpAverages_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            ResetTable();
        }

        private void rjbReturn_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
            login.FormClosed += (s, args) => this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmSurveyorg frmSurveyorg = new frmSurveyorg();
            this.Hide();
            frmSurveyorg.Show();
            frmSurveyorg.FormClosed += (s, args) => this.Close();
        }

        private void CheckItems(int num)
        {
            for (int i = 0; i < 5; i++)
            {
                if (i != num)
                {
                    cbxSort.SetItemChecked(i, false);
                } else
                {
                    cbxSort.SetItemChecked(i, true);
                }
            }
        }

        private void sortAdmin()
        {
            DataView dv = new DataView(db);
            dv.RowFilter = $"Is_Admin = 'Yes'";
            dgvusers.DataSource = dv;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxSort.SelectedIndex)
            {
                case 0:
                    ResetTable();
                    CheckItems(0);
                    CalculateAverages();
                    break;
                case 1:
                    SortBoth();
                    CheckItems(1);
                    CalculateAverages();
                    break;
                case 2:
                    SortByTestType("Personal");
                    CheckItems(2);
                    CalculateAverages();
                    break;
                case 3:
                    SortByTestType("Organization");
                    CheckItems(3);
                    CalculateAverages();
                    break;
                case 4:
                    sortAdmin();
                    CheckItems(4);
                    CalculateAverages();
                    break;
                    
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            if (dgvusers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvusers.SelectedRows[0];
                frmEdit editForm = new frmEdit(selectedRow);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    load(Program.filepath);
                }
                dgvusers.Rows[0].Selected = true;
            } else
            {
                MessageBox.Show("Please select an entry to edit", "Select entry", MessageBoxButtons.OK);
            }
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            // moving pointer up            
            int rowIndex = dgvusers.SelectedRows[0].Index;
            if (rowIndex > 0)
            {
                dgvusers.ClearSelection();
                dgvusers.Rows[rowIndex - 1].Selected = true;
                dgvusers.CurrentCell = dgvusers.Rows[rowIndex - 1].Cells[0];
            }
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            //moving pointer down
            if (dgvusers.SelectedRows.Count > 0)
            {
                int rowIndex = dgvusers.SelectedRows[0].Index;
                if (rowIndex < dgvusers.Rows.Count - 1)
                {
                    dgvusers.ClearSelection();
                    dgvusers.Rows[rowIndex + 1].Selected = true;
                    dgvusers.CurrentCell = dgvusers.Rows[rowIndex + 1].Cells[0]; // Move focus
                }
            }
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            // Confirm deletion
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete the selected user?",
                "Delete Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    int rowIndex = dgvusers.SelectedRows[0].Index; // Get the selected row index

                    // Remove the row from the DataGridView
                    dgvusers.Rows.RemoveAt(rowIndex);

                    // Update the Excel file to remove the deleted row
                    DeleteRowFromExcel(Program.filepath, rowIndex + 2); // +2 to account for header row (Excel is 1-based index)

                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvusers.Rows[0].Selected = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Function to delete a row from Excel and save changes
        private void DeleteRowFromExcel(string filePath, int excelRowIndex)
        {
            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;

            try
            {
                excelApp = new Excel.Application();
                workbook = excelApp.Workbooks.Open(filePath);
                worksheet = workbook.Sheets[1];

                Excel.Range row = worksheet.Rows[excelRowIndex];
                row.Delete(XlDeleteShiftDirection.xlShiftUp); // Shift rows up after deletion

                // Save and close
                workbook.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Excel error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (worksheet != null) Marshal.ReleaseComObject(worksheet);
                if (workbook != null)
                {
                    workbook.Close(false);
                    Marshal.ReleaseComObject(workbook);
                }
                if (excelApp != null)
                {
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                }
            }
        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            //saves any changes made to the db
        }
    }
}
