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

            Application app = new Application();

            Workbook wb = app.Workbooks.Open(@"C:\Users\yossi\source\repos\yossiii050\FeatherFriend\DataBased\CageDB.xlsx");
            Worksheet ws = wb.Worksheets["sheet1"];

            

            int row = 2;
            while (ws.Cells[row, 1].Value != null)
            {
                row++;
            }
            ws.Cells[row, 1].Value = cageid;
            ws.Cells[row, 2].Value = len;
            ws.Cells[row, 3].Value = wid;
            ws.Cells[row, 4].Value = hei;
            ws.Cells[row, 5].Value = mat;

            wb.Save();

            wb.Close();

            MessageBox.Show("Cage add successfully!","add");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
