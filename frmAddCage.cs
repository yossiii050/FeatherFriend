﻿using Microsoft.Office.Interop.Excel;
using System;
using System.Linq;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace BirdManagment
{
    public partial class frmAddCage : Form
    {

        public frmAddCage()
        {
            InitializeComponent();
        }

        public void add_btn_Click(object sender, EventArgs e)
        {
            string cageid = serial.Text;
            string len = length.Text;
            string wid = width.Text;
            string hei = height.Text;
            string mat = comboBox1.Text;
            

            
            if (cageid.All(char.IsLetterOrDigit)==false || string.IsNullOrEmpty(cageid))
            {
                MessageBox.Show("Invalid cage ID. Please use only letters or numbers.", "Exception 301", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidDimension(wid))
            {
                MessageBox.Show("Invalid width. Please enter numeric values.", "Exception 303", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidDimension(hei))
            {
                MessageBox.Show("Invalid height. Please enter numeric values.", "Exception 304", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidDimension(len))
            {
                MessageBox.Show("Invalid length. Please enter numeric values.", "Exception 302", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(mat=="")
            {
                MessageBox.Show("Invalid Material. Please choose from option.", "Exception 313", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsCageIdUsed(cageid))
            {
                MessageBox.Show("Cage ID already exists. Please choose a different ID.", "Error 201", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Application app = new Application();
            Workbook wb1 = app.Workbooks.Open(@"C:\FeatherFriend\DataBased\CageDB.xlsx");
            Worksheet ws1 = wb1.ActiveSheet;

            pictureBox1.Visible = true;
            pictureBox2.Visible = false;

            int row = 2;
            while (ws1.Cells[row, 1].Value != null)
            {
                row++;
            }
            ws1.Cells[row, 1].Value = cageid;
            ws1.Cells[row, 2].Value = len;
            ws1.Cells[row, 3].Value = wid;
            ws1.Cells[row, 4].Value = hei;
            ws1.Cells[row, 5].Value = mat;

            wb1.Save();

            wb1.Close();
            ws1=null;
            
            
            MessageBox.Show("Cage add successfully!", "Success 101", MessageBoxButtons.OK, MessageBoxIcon.Information);
            app.Quit();


            System.Runtime.InteropServices.Marshal.ReleaseComObject(wb1);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
            wb1=null;
            app=null;

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();

            //this.Hide();
        }

        public bool IsCageIdUsed(string cageId)
        {
            Application app = new Application();
            Workbook wb = app.Workbooks.Open(@"C:\FeatherFriend\DataBased\CageDB.xlsx",ReadOnly: true);
            Worksheet ws = wb.Worksheets["sheet1"];

            int row = 2;
            while (ws.Cells[row, 1].Value != null)
            {
                string existingCageId = ws.Cells[row, 1].Value.ToString();
                if (existingCageId == cageId)
                {
                    wb.Close();
                    app.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(wb);
                    ws=null;
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
                    wb=null;
                    app=null;

                    return true;
                }
                row++;
            }

            wb.Close();
            app.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wb);
            ws=null;
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
            wb=null;
            app=null;
            return false;
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
