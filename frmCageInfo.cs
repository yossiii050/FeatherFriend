using Microsoft.Office.Interop.Excel;
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
using System.Security.Cryptography;


namespace BirdManagment
{
    public partial class frmCageInfo : Form
    {
        private System.Data.DataTable originalTable1;
        string w, h, l, m;
        public frmCageInfo()
        {
            InitializeComponent();
            LoadExcelData(@"C:\FeatherFriend\DataBased\BirdDB.xlsx");
            Excel. Application app2 = new Excel.Application();
            Workbook wbCage = app2.Workbooks.Open(@"C:\FeatherFriend\DataBased\CageDB.xlsx");
            Worksheet wsCage = wbCage.Worksheets["sheet1"];
            Range usedRangeCage = wsCage.UsedRange;

            int lastRowCage = usedRangeCage.Rows.Count;
            for (int row = 2; row <= lastRowCage; row++)
            {
                string CageIds = Convert.ToString(wsCage.Cells[row, 1].Value);

                comboBox1.Items.Add(CageIds);

            }


            wbCage.Close();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wbCage);
            wbCage = null;
            wsCage = null;
            app2.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app2);
            app2 = null;

            //System.GC.Collect();
           // System.GC.WaitForPendingFinalizers();
        }

       

        public void frmCageInfo_Load(object sender, EventArgs e)
        {
           
        }

        private void LoadExcelData(string filePath)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(filePath, ReadOnly: true);
            Excel.Worksheet worksheet = workbook.Worksheets["sheet1"];
            Excel.Range range = worksheet.UsedRange;

            // Get the data into a DataTable
            originalTable1 = new System.Data.DataTable(); // Initialize the original DataTable

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

        public void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals(""))
            {
                MessageBox.Show("Choose Cage first to show info.", "Error 204", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string cageID = comboBox1.Text;
                Excel. Application app2 = new Excel.Application();
                Workbook wbCage = app2.Workbooks.Open(@"C:\FeatherFriend\DataBased\CageDB.xlsx");
                Worksheet wsCage = wbCage.Worksheets["sheet1"];
                Range usedRangeCage = wsCage.UsedRange;

                int lastRowCage = usedRangeCage.Rows.Count;
                for (int row = 2; row <= lastRowCage; row++)
                {
                    if (string.Equals(cageID, Convert.ToString(wsCage.Cells[row, 1].Value)))
                    {
                        textBox1.Text = Convert.ToString(wsCage.Cells[row, 2].Value);
                        textBox2.Text = Convert.ToString(wsCage.Cells[row, 3].Value);
                        textBox3.Text = Convert.ToString(wsCage.Cells[row, 4].Value);
                        textBox4.Text = Convert.ToString(wsCage.Cells[row, 5].Value);
                       
                    }

                }


                wbCage.Close();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(wbCage);
                wbCage = null;
                wsCage = null;
                app2.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(app2);
                app2 = null;
                button2.Enabled = true;
                
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                comboBox2.Visible = false;
                System.Data.DataTable filteredBirdsTable = originalTable1.Clone();
                
         
                foreach (DataRow birdRow in originalTable1.Rows)
                {
                    if (Convert.ToString(birdRow["CageID"]) == cageID)
                    {
                       filteredBirdsTable.ImportRow(birdRow);
                    }
                }
                

                dataGridView2.DataSource = filteredBirdsTable;
                dataGridView2.Visible = true;
            
            }
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            w = textBox1.Text;
            h = textBox2.Text;
            l = textBox3.Text;
            m = textBox4.Text;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            comboBox2.Visible = true;
            comboBox2.SelectedIndex = 1;
            button3.Enabled = true;
            button2.Enabled = false;
            //MessageBox.Show("Editing enabled!\n Choose cage first and save.", "Error 212", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        public void button3_Click(object sender, EventArgs e)
        {
            if (w==textBox1.Text && h==textBox2.Text && l==textBox3.Text && m==comboBox2.Text)
            {
                DialogResult dialogResult = MessageBox.Show("Save witouht changes?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Data saved.", "Success 105", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBox2.Visible = false;
                    button2.Enabled = true;
                    button3.Enabled = false;
                } 
            }
            else
            {
               
                if (!IsValidDimension(textBox1.Text))
                {
                    MessageBox.Show("Invalid width. Please enter numeric values.", "Exception 303", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidDimension(textBox2.Text))
                {
                    MessageBox.Show("Invalid height. Please enter numeric values.", "Exception 304", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidDimension(textBox3.Text))
                {
                    MessageBox.Show("Invalid length. Please enter numeric values.", "Exception 302", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string cageID = comboBox1.Text;
                Excel. Application app2 = new Excel.Application();
                Workbook wbCage = app2.Workbooks.Open(@"C:\FeatherFriend\DataBased\CageDB.xlsx");
                Worksheet wsCage = wbCage.Worksheets["sheet1"];
                Range usedRangeCage = wsCage.UsedRange;
                int lastRowCage = usedRangeCage.Rows.Count;
                for (int row = 2; row <= lastRowCage; row++)
                {
                    if (string.Equals(cageID, Convert.ToString(wsCage.Cells[row, 1].Value)))
                    {
                        wsCage.Cells[row, 2].Value = textBox1.Text;
                        wsCage.Cells[row, 3].Value = textBox2.Text;
                        wsCage.Cells[row, 4].Value = textBox3.Text;
                        wsCage.Cells[row, 5].Value = comboBox2.Text;
                        textBox4.Text = comboBox2.Text;
                        break;
                    }

                }
                MessageBox.Show("Data saved.", "Success 105", MessageBoxButtons.OK, MessageBoxIcon.Information);
                wbCage.Save();
                wbCage.Close();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(wbCage);
                wbCage = null;
                wsCage = null;
                app2.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(app2);
                app2 = null;
                button2.Enabled = true;
                button3.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                comboBox2.Visible = false;
            }
            
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }

        public bool IsValidDimension(string dimension)
        {
            double value;
            if (double.TryParse(dimension, out value))
            {
                if (value > 0)
                {
                    return true;
                }
            }
            return false;
        }

    }

}
