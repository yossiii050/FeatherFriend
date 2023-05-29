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
    public partial class frmDash : Form
    {
        public frmDash()
        {
            InitializeComponent();
            string filePath = @"C:\FeatherFriend\DataBased\CageDB.xlsx";
            LoadExcelData(filePath);
            string filePath1 = @"C:\FeatherFriend\DataBased\BirdDB.xlsx";
            LoadExcelData1(filePath1);

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();

        }
        private void LoadExcelData(string filePath)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
            Excel.Worksheet worksheet = workbook.Worksheets["sheet1"];
            Excel.Range range = worksheet.UsedRange;
            System.Console.WriteLine(range.Columns.Count);
            System.Console.WriteLine(range.Rows.Count);
            // Get the data into a DataTable
            DataTable dt = new DataTable();

            for (int i = 1; i <=range.Columns.Count; i++)
            {
                dt.Columns.Add((range.Cells[1, i] as Excel.Range).Value2.ToString());
            }

            for (int row = 2; row <= range.Rows.Count; row++)
            {
                DataRow dr = dt.NewRow();
                for (int col = 1; col <= range.Columns.Count; col++)
                {
                    dr[col - 1] = (range.Cells[row, col] as Excel.Range).Value2.ToString();
                }
                dt.Rows.Add(dr);
            }

            // Bind the DataTable to the DataGridView

            dataGridView1.DataSource = dt;


            // Clean up Excel objects
            workbook.Close();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            workbook = null;
            worksheet = null;
            excelApp.Quit();
            

            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
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
            System.Console.WriteLine(range.Columns.Count);
            System.Console.WriteLine(range.Rows.Count);
            // Get the data into a DataTable
            DataTable dt = new DataTable();
            // range.Columns.Count
            for (int i = 1; i <=range.Columns.Count; i++)
            {
                
                dt.Columns.Add((range.Cells[1, i] as Excel.Range).Value2.ToString());
            }

            for (int row = 2; row <= range.Rows.Count; row++)
            {
                DataRow dr = dt.NewRow();
                for (int col = 1; col <= range.Columns.Count; col++)
                {
                    
                    dr[col - 1] = (range.Cells[row, col] as Excel.Range).Value2.ToString();
                }
                dt.Rows.Add(dr);
            }

            // Bind the DataTable to the DataGridView

            dataGridView2.DataSource = dt;


            workbook.Close();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            workbook = null;
            worksheet = null;
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

            excelApp = null;


            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }


        
    }

}
