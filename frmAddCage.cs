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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace BirdManagment
{
    public partial class frmAddCage : Form
    {

        public frmAddCage()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string cageid = serial.Text;
            string len = length.Text;
            string wid = width.Text;
            string hei = height.Text;
            string mat = comboBox1.Text;
            

            
            if (cageid.All(char.IsLetterOrDigit)==false || string.IsNullOrEmpty(cageid))
            {
                MessageBox.Show("Invalid cage ID. Please use only letters or numbers.", "Error 301");
                return;
            }
            
            if (!IsValidDimension(len))
            {
                MessageBox.Show("Invalid length. Please enter numeric values.", "Exception 302");
                return;
            }

            if (!IsValidDimension(wid))
            {
                MessageBox.Show("Invalid width. Please enter numeric values.", "Exception 303");
                return;
            }

            if (!IsValidDimension(hei))
            {
                MessageBox.Show("Invalid height. Please enter numeric values.", "Exception 304");
                return;
            }

            if (IsCageIdUsed(cageid))
            {
                MessageBox.Show("Cage ID already exists. Please choose a different ID.", "Error 201");
                return;
            }
            Application app = new Application();
            Workbook wb1 = app.Workbooks.Open(@"C:\FeatherFriend\DataBased\CageDB.xlsx");
            Worksheet ws1 = wb1.ActiveSheet;



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
            
            
            MessageBox.Show("Cage add successfully!", "Success 101");
            app.Quit();


            System.Runtime.InteropServices.Marshal.ReleaseComObject(wb1);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
            wb1=null;
            app=null;

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();

            //this.Hide();
        }

        private bool IsCageIdUsed(string cageId)
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

        private bool IsValidDimension(string dimension)
        {
            double value;
            return double.TryParse(dimension, out value);
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
