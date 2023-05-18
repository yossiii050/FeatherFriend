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
using Application = Microsoft.Office.Interop.Excel.Application;

namespace BirdManagment
{
    public partial class frmBirdInfo : Form
    {
      
        public frmBirdInfo()
        {
           
            InitializeComponent();

            Application app2 = new Application();

            Workbook wb2 = app2.Workbooks.Open(@"C:\FeatherFriend\DataBased\BirdDB.xlsx", ReadOnly: true);
            Worksheet ws2 = wb2.Worksheets["sheet1"];
            Range usedRange2 = ws2.UsedRange;

            int lastRow = usedRange2.Rows.Count;
            comboBox1.Items.Add(0); // Add a default option if needed

            for (int row = 2; row <= lastRow; row++)
            {
                int id = Convert.ToInt32(ws2.Cells[row, 1].Value);
                comboBox1.Items.Add(id);
            }

            comboBoxDad.Items.Add(0);
            comboBoxMom.Items.Add(0);
            for (int row = 2; row <= lastRow; row++)
            {
                int id = Convert.ToInt32(ws2.Cells[row, 1].Value);
                string gender = Convert.ToString(ws2.Cells[row, 5].Value);

                if (gender == "Male")
                {
                    comboBoxDad.Items.Add(id);
                }
                else if (gender == "Female")
                {
                    comboBoxMom.Items.Add(id);
                }
            }


            wb2.Close();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wb2);
            ws2 = null;
            wb2 = null;

            Workbook wbCage = app2.Workbooks.Open(@"C:\FeatherFriend\DataBased\CageDB.xlsx", ReadOnly: true);
            Worksheet wsCage = wbCage.Worksheets["sheet1"];
            Range usedRangeCage = wsCage.UsedRange;

            int lastRowCage = usedRangeCage.Rows.Count;
            for (int row = 2; row <= lastRowCage; row++)
            {
                string CageIds = Convert.ToString(wsCage.Cells[row, 1].Value);

                comboBoxCage.Items.Add(CageIds);

            }


            wbCage.Close();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wbCage);
            wbCage = null;
            wsCage = null;
            app2.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app2);
            app2 = null;
        }

       

        private void frmBirdInfo_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            string birdID = comboBox1.Text.ToString();
            comboBoxCage.Enabled = false;
            comboBoxGend.Enabled = false;
            comboBoxDad.Enabled = false;
            comboBoxMom.Enabled = false;
            comboBoxSpec.Enabled = false;
            comboBoxSubSpec.Enabled = false;
            dateTimePicker1.Enabled=false;
            Application app2 = new Application();
            Workbook wb2 = app2.Workbooks.Open(@"C:\FeatherFriend\DataBased\BirdDB.xlsx", ReadOnly: true);
            Worksheet ws2 = wb2.Worksheets["sheet1"];
            Range usedRange2 = ws2.UsedRange;

            int lastRow = usedRange2.Rows.Count;

            for (int row = 2; row <= lastRow; row++)
            {
                int id = Convert.ToInt32(ws2.Cells[row, 1].Value);
                if (string.Equals(birdID,id.ToString()))
                {
                    comboBoxSpec.Text = ws2.Cells[row, 2].Value;
                    comboBoxSubSpec.Text= ws2.Cells[row, 3].Value;
                    textBox1.Text = ws2.Cells[row, 4].Value;
                    comboBoxGend.Text= ws2.Cells[row, 5].Value;
                    textBox2.Text = ws2.Cells[row, 6].Value.ToString();
                    textBox3.Text = ws2.Cells[row, 7].Value.ToString();
                    string cellValue = ws2.Cells[row, 8].Value.ToString();
                    DateTime dateTimeValue;
                    if (DateTime.TryParse(cellValue, out dateTimeValue)){
                        dateTimePicker1.Value = dateTimeValue;
                    }
                    headcolorBird.Text = ws2.Cells[row, 9].Value;
                    breastcolorBird.Text = ws2.Cells[row, 10].Value;
                    bodycolorBird.Text = ws2.Cells[row, 11].Value;
                }
            }

            wb2.Close();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wb2);
            wb2 = null;
            app2.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app2);
            app2 = null;
            ws2 = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBoxCage.Enabled = true; 
            comboBoxGend.Enabled = true;
            comboBoxDad.Enabled = true;
            comboBoxMom.Enabled = true;
            comboBoxSpec.Enabled = true;
            comboBoxSubSpec.Enabled = true;
            dateTimePicker1.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string birdID = comboBox1.Text.ToString();
            Application app2 = new Application();
            Workbook wb2 = app2.Workbooks.Open(@"C:\FeatherFriend\DataBased\BirdDB.xlsx", ReadOnly: true);
            Worksheet ws2 = wb2.Worksheets["sheet1"];
            Range usedRange2 = ws2.UsedRange;

            int lastRow = usedRange2.Rows.Count;

            for (int row = 2; row <= lastRow; row++)
            {
                int id = Convert.ToInt32(ws2.Cells[row, 1].Value);
                if (string.Equals(birdID, id.ToString()))
                {
                    ws2.Cells[row, 2].Value= comboBoxSpec.Text;
                    ws2.Cells[row, 3].Value= comboBoxSubSpec.Text;
                    ws2.Cells[row, 4].Value=comboBoxCage.SelectedItem;
                    textBox1.Text = ws2.Cells[row, 4].Value;
                    ws2.Cells[row, 5].Value= comboBoxGend.Text;
                    ws2.Cells[row, 6].Value= comboBoxMom.Text;
                    ws2.Cells[row, 7].Value= comboBoxDad.Text;
                    textBox2.Text = ws2.Cells[row, 6].Value.ToString();
                    textBox3.Text = ws2.Cells[row, 7].Value.ToString();
                    string date = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                    ws2.Cells[row, 8].Value = date;
                    headcolorBird.Text = ws2.Cells[row, 9].Value;
                    breastcolorBird.Text = ws2.Cells[row, 10].Value;
                    bodycolorBird.Text = ws2.Cells[row, 11].Value;
                }
            }

            wb2.Close();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wb2);
            wb2 = null;
            app2.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app2);
            app2 = null;
            ws2 = null;
        }
    }

}
