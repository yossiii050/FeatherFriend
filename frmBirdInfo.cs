﻿using Microsoft.Office.Interop.Excel;
using System;
using System.Drawing;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Excel.Application;
using System.IO;

namespace BirdManagment
{
    public partial class frmBirdInfo : Form
    {
     
        public frmBirdInfo()
        {
           
            InitializeComponent();
            Application app2 = new Application();
            Workbook wbBird = app2.Workbooks.Open(@"C:\FeatherFriend\DataBased\BirdDB.xlsx", ReadOnly: true);
            Worksheet wsBird = wbBird.Worksheets["sheet1"];
            Range usedRangeCage = wsBird.UsedRange;

            int lastRowCage = usedRangeCage.Rows.Count;
            for (int row = 2; row <= lastRowCage; row++)
            {
                string BirdIds = Convert.ToString(wsBird.Cells[row, 1].Value);

                comboBox1.Items.Add(BirdIds);

            }


            wbBird.Close();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wbBird);
            wbBird = null;
            wsBird = null;
            app2.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app2);
            app2 = null;

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }



        public void frmBirdInfo_Load(object sender, EventArgs e)
        {
           
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals(""))
            {
                MessageBox.Show("Choose Bird first to show info.", "Error 217", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            else
            {
                string birdID = comboBox1.Text;
                Application app2 = new Application();
                Workbook wbBird = app2.Workbooks.Open(@"C:\FeatherFriend\DataBased\BirdDB.xlsx", ReadOnly: true);
                Worksheet wsBird = wbBird.Worksheets["sheet1"];
                Range usedRangeCage = wsBird.UsedRange;
                string gend, head, breast, body;
                int lastRowCage = usedRangeCage.Rows.Count;
                for (int row = 2; row <= lastRowCage; row++)
                {
                    if (string.Equals(birdID, Convert.ToString(wsBird.Cells[row, 1].Value)))
                    {

                        textBox2.Text = Convert.ToString(wsBird.Cells[row, 2].Value);
                        textBox3.Text = Convert.ToString(wsBird.Cells[row, 3].Value);
                        textBox6.Text = Convert.ToString(wsBird.Cells[row, 4].Value);
                        textBox4.Text = Convert.ToString(wsBird.Cells[row, 5].Value);
                        textBox7.Text = Convert.ToString(wsBird.Cells[row, 6].Value);
                        textBox8.Text = Convert.ToString(wsBird.Cells[row, 7].Value);
                        textBox5.Text = Convert.ToString(wsBird.Cells[row, 8].Value);
                        textBox9.Text = Convert.ToString(wsBird.Cells[row, 9].Value);
                        textBox10.Text = Convert.ToString(wsBird.Cells[row, 10].Value);
                        textBox11.Text = Convert.ToString(wsBird.Cells[row, 11].Value);
                        gend = Convert.ToString(wsBird.Cells[row, 5].Value);
                        head = Convert.ToString(wsBird.Cells[row, 9].Value);
                        breast = Convert.ToString(wsBird.Cells[row, 10].Value);
                        body = Convert.ToString(wsBird.Cells[row, 11].Value);
                        try
                        {
                            pictureBox1.Image = Image.FromFile(@"C:\FeatherFriend\DataBased\birdphoto\" + gend + head + breast + body + ".png");
                        }
                        catch (FileNotFoundException e1)
                        {
                            pictureBox1.Image = Image.FromFile(@"C:\FeatherFriend\DataBased\birdphoto\checkmark.gif");
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            Console.WriteLine("Catch in the add Bird Picture");
                        }


                    }


                }

                wbBird.Close();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(wbBird);
                wbBird = null;
                wsBird = null;
                app2.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(app2);
                app2 = null;
                button2.Enabled = true;
                
                button4.Enabled = true;
                comboBox2.Visible = false;
                comboBox3.Visible= false;
                comboBox4.Visible= false;
                comboBox5.Visible= false;
            }
            
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
           
        }

        public void button2_Click(object sender, EventArgs e)
        {
                button2.Enabled = false;
                button3.Enabled = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                comboBox5.Visible = true;
                
                comboBox3.Text=textBox9.Text;
                comboBox4.Text=textBox10.Text;
                comboBox5.Text=textBox11.Text;

            // MessageBox.Show("Editing enabled!\n Choose cage first and save.", "Error 212", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application app2 = new Application();
                Workbook wbCage = app2.Workbooks.Open(@"C:\FeatherFriend\DataBased\CageDB.xlsx", ReadOnly: true);
                Worksheet wsCage = wbCage.Worksheets["sheet1"];
                Range usedRangeCage = wsCage.UsedRange;

                int lastRowCage = usedRangeCage.Rows.Count;
                for (int row = 2; row <= lastRowCage; row++)
                {
                    string CageIds = Convert.ToString(wsCage.Cells[row, 1].Value);

                    comboBox2.Items.Add(CageIds);

                }
                comboBox2.Text=textBox6.Text.ToString();
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

        public void button3_Click(object sender, EventArgs e)
        {
            string gend, head, breast, body;
            if (comboBox2.Text.Equals(textBox6.Text) && comboBox3.Text.Equals(textBox9.Text) && comboBox4.Text.Equals(textBox10.Text) && comboBox5.Text.Equals(textBox11.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Save witouht changes?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                { 
                    MessageBox.Show("Data saved.", "Success 105", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBox2.Visible= false;
                    comboBox3.Visible= false;
                    comboBox4.Visible= false;
                    comboBox5.Visible= false;
                    button2.Enabled = true;
                    button3.Enabled = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Editing enabled!\n Fill in all fileds", "Error 219", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                string cageID = comboBox1.Text;
                Application app2 = new Application();
                Workbook wbBird = app2.Workbooks.Open(@"C:\FeatherFriend\DataBased\BirdDB.xlsx");
                Worksheet wsBird = wbBird.Worksheets["sheet1"];
                Range usedRangeCage = wsBird.UsedRange;

                int lastRowCage = usedRangeCage.Rows.Count;
                for (int row = 2; row <= lastRowCage; row++)
                {
                    if (string.Equals(cageID, Convert.ToString(wsBird.Cells[row, 1].Value)))
                    {
                        wsBird.Cells[row, 4].Value = comboBox2.Text;
                        wsBird.Cells[row, 9].Value = comboBox3.Text;
                        wsBird.Cells[row, 10].Value = comboBox4.Text;
                        wsBird.Cells[row, 11].Value = comboBox5.Text;
                        textBox6.Text = Convert.ToString(wsBird.Cells[row, 4].Value);
                        textBox9.Text = Convert.ToString(wsBird.Cells[row, 9].Value);
                        textBox10.Text = Convert.ToString(wsBird.Cells[row, 10].Value);
                        textBox11.Text = Convert.ToString(wsBird.Cells[row, 11].Value);
                        gend = Convert.ToString(wsBird.Cells[row, 5].Value);
                        head = Convert.ToString(wsBird.Cells[row, 9].Value);
                        breast = Convert.ToString(wsBird.Cells[row, 10].Value);
                        body = Convert.ToString(wsBird.Cells[row, 11].Value);
                        try
                        {
                            pictureBox1.Image = Image.FromFile(@"C:\FeatherFriend\DataBased\birdphoto\" + gend + head + breast + body + ".png");
                        }
                        catch (FileNotFoundException e1)
                        {
                            pictureBox1.Image = Image.FromFile(@"C:\FeatherFriend\DataBased\birdphoto\checkmark.gif");
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            Console.WriteLine("Catch in the add Bird Picture");
                        }
                        break;
                    }

                }
               
                button3.Enabled = false;
                button2.Enabled = true;
                wbBird.Save();
                wbBird.Close();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(wbBird);
                wbBird = null;
                wsBird = null;
                app2.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(app2);
                app2 = null;
                comboBox2.Visible = false;
                comboBox3.Visible= false;
                comboBox4.Visible= false;
                comboBox5.Visible= false;
                MessageBox.Show("Data saved.", "Success 105", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            string cageID = textBox6.Text;
            string spec = textBox2.Text;
            string subspec = textBox3.Text;
            string thisBirdID = comboBox1.Text;
            Dashboard dashboard = (Dashboard)this.ParentForm;
            dashboard.ReloadFrmLoaderForNewFled(new frmAddBird(thisBirdID,spec,subspec,cageID));

        }

        
    }

}
