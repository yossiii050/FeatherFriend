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

namespace BirdManagment
{
    public partial class frmSearchCage : Form
    {
        private DataTable originalTable;
        private DataTable originalTable1;
        public frmSearchCage()
        {
            InitializeComponent();
            string filePath = @"C:\FeatherFriend\DataBased\CageDB.xlsx";
            string filePath1 = @"C:\FeatherFriend\DataBased\BirdDB.xlsx";
            LoadExcelData(filePath);
            LoadExcelData1(filePath1);

        }

        private void LoadExcelData(string filePath)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
            Excel.Worksheet worksheet = workbook.Worksheets["sheet1"];
            Excel.Range range = worksheet.UsedRange;

            // Get the data into a DataTable
            originalTable = new DataTable(); // Initialize the original DataTable

            for (int i = 1; i <= range.Columns.Count; i++)
            {
                originalTable.Columns.Add((range.Cells[1, i] as Excel.Range).Value2.ToString());
            }

            for (int row = 2; row <= range.Rows.Count; row++)
            {
                DataRow dr = originalTable.NewRow();
                for (int col = 1; col <= range.Columns.Count; col++)
                {
                    var cell = range.Cells[row, col] as Excel.Range;
                    dr[col - 1] = cell != null ? cell.Value2?.ToString() : string.Empty;
                }
                originalTable.Rows.Add(dr);
            }

            // Bind the DataTable to the DataGridView

            dataGridView1.DataSource = originalTable;


            // Clean up Excel objects
            workbook.Close();
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            worksheet = null;
            workbook = null;
            excelApp = null;

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }

        private void LoadExcelData1(string filePath)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
            Excel.Worksheet worksheet = workbook.Worksheets["sheet1"];
            Excel.Range range = worksheet.UsedRange;

            // Get the data into a DataTable
            originalTable1 = new DataTable(); // Initialize the original DataTable

            for (int i = 1; i <= range.Columns.Count; i++)
            {
                originalTable1.Columns.Add((range.Cells[1, i] as Excel.Range).Value2.ToString());
            }

            for (int row = 2; row <= range.Rows.Count; row++)
            {
                DataRow dr = originalTable1.NewRow();
                for (int col = 1; col <= range.Columns.Count; col++)
                {
                    var cell = range.Cells[row, col] as Excel.Range;
                    dr[col - 1] = cell != null ? cell.Value2?.ToString() : string.Empty;
                }
                originalTable1.Rows.Add(dr);
            }

            // Bind the DataTable to the DataGridView

            dataGridView2.DataSource = originalTable1;
            dataGridView2.Visible = false;

            // Clean up Excel objects
            workbook.Close();
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            worksheet = null;
            workbook = null;
            excelApp = null;

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }

        private void frmSearchCage_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
          
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please choose search option.");
            }
            else
            {
                dataGridView2.Visible = true;
                string searchBy = comboBox1.SelectedItem.ToString();
                string searchTerm = textBox1.Text;

                DataTable filteredTable = originalTable.Clone();

                foreach (DataRow row in originalTable.Rows)
                {
                    if (row[searchBy].ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        filteredTable.ImportRow(row);
                    }
                }

                if (filteredTable.Rows.Count > 1)
                {
                    DataRow[] results = filteredTable.Select($"[CageID] = '{searchTerm}%'");
                    filteredTable = results.Any() ? results.CopyToDataTable() : filteredTable;
                }

                DataView dv = filteredTable.DefaultView;
                dv.Sort = "CageID ASC";
                filteredTable = dv.ToTable();
                dataGridView1.DataSource = filteredTable;


                DataTable filteredBirdsTable = originalTable1.Clone();

                foreach (DataRow row in filteredTable.Rows)
                {
                    string selectedCageID = row["CageID"].ToString();

                    foreach (DataRow birdRow in originalTable1.Rows)
                    {
                        if (birdRow["CageID"].ToString() == selectedCageID)
                        {
                            filteredBirdsTable.ImportRow(birdRow);
                        }
                    }
                }

                dataGridView2.DataSource = filteredBirdsTable;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = originalTable;
            dataGridView2.DataSource = originalTable1;
            dataGridView2.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
