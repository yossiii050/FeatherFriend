﻿using Microsoft.Office.Interop.Excel;
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
using System.Security.Cryptography;

namespace BirdManagment
{
    public partial class frmCageInfo : Form
    {
      
        public frmCageInfo()
        {
            InitializeComponent();
            Application app2 = new Application();
            Workbook wbCage = app2.Workbooks.Open(@"C:\FeatherFriend\DataBased\CageDB.xlsx", ReadOnly: true);
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

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }

       

        private void frmCageInfo_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals(""))
            {
                MessageBox.Show("Choose Cage first to show info.", "Error 215", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string cageID = comboBox1.Text;
                Application app2 = new Application();
                Workbook wbCage = app2.Workbooks.Open(@"C:\FeatherFriend\DataBased\CageDB.xlsx", ReadOnly: true);
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
                button3.Enabled = true;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                comboBox2.Visible = false;
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            comboBox2.Visible = true;
            comboBox2.SelectedIndex = 1;
            MessageBox.Show("Editing enabled!\n Choose Object first and save.", "Error 212", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            string cageID = comboBox1.Text;
            Application app2 = new Application();
            Workbook wbCage = app2.Workbooks.Open(@"C:\FeatherFriend\DataBased\CageDB.xlsx");
            Worksheet wsCage = wbCage.Worksheets["sheet1"];
            Range usedRangeCage = wsCage.UsedRange;
            if (!IsValidDimension(textBox1.Text))
            {
                MessageBox.Show("Invalid width. Please enter numeric values.", "Exception 303", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                return;
            }

            if (!IsValidDimension(textBox2.Text))
            {
                MessageBox.Show("Invalid height. Please enter numeric values.", "Exception 304", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                return;
            }

            if (!IsValidDimension(textBox3.Text))
            {
                MessageBox.Show("Invalid length. Please enter numeric values.", "Exception 302", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                return;
            }
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
            button2.Enabled = false;
            button3.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            comboBox2.Visible = false;
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
