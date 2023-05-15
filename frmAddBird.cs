using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace BirdManagment
{
    public partial class frmAddBird : Form
    {
        public frmAddBird()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string birdid = serial.Text;
            string spec = species.Text;
            string subspec = sub_species.Text;
            string gen = gender.Text;
            string date = dateTimePicker1.Text;
            string cageid = cage_no.Text;
            string momid = mom_serial.Text;
            string dadid = dad_serial.Text;


            Application app = new Application();

            Workbook wb = app.Workbooks.Open(@"C:\Users\yossi\source\repos\yossiii050\FeatherFriend\DataBased\BirdDB.xlsx");
            Worksheet ws = wb.Worksheets["sheet1"];

            int lastRow = ws.Cells.SpecialCells(XlCellType.xlCellTypeLastCell).Row;
            for (int i = 2; i <= lastRow; i++)
            {
                string existingcageID = ws.Cells[i, 1].Value;
                if (existingcageID == birdid)
                {
                    MessageBox.Show("Bird ID already exists. Please choose a different ID.");
                    wb.Close(false);
                    app.Quit();
                    return;
                }
            }

            int row = 2;
            while (ws.Cells[row, 1].Value != null)
            {
                row++;
            }
            ws.Cells[row, 1].Value = birdid;
            ws.Cells[row, 2].Value = spec;
            ws.Cells[row, 3].Value = subspec;
            ws.Cells[row, 4].Value = cageid;
            ws.Cells[row, 5].Value = gen;
            ws.Cells[row, 6].Value = momid;
            ws.Cells[row, 7].Value = dadid;
            ws.Cells[row, 8].Value = date;

            wb.Save();

            wb.Close();

            MessageBox.Show("Bird add successfully!", "add");
        }
    }
}
