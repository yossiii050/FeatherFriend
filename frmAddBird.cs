using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace BirdManagment
{
    public partial class frmAddBird : Form
    {
        public frmAddBird(string id_f,string spec_f,string subspec_f,string cageId_f)
        {
            InitializeComponent();
           
           
            Application app2 = new Application();

            Workbook wb2 = app2.Workbooks.Open(@"C:\FeatherFriend\DataBased\BirdDB.xlsx", ReadOnly: true);
            Worksheet ws2 = wb2.Worksheets["sheet1"];
            Range usedRange2 = ws2.UsedRange;

            int lastRow = usedRange2.Rows.Count;
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

            if(comboBoxDad.SelectedIndex == 1 || comboBoxMom.SelectedIndex == 1)
            {
                for (int row = 2; row <= lastRow; row++)
                {
                    int id = Convert.ToInt32(ws2.Cells[row, 1].Value);
                    string gender = Convert.ToString(ws2.Cells[row, 5].Value);
                    if (comboBoxDad.SelectedIndex==1 && gender == "Female")
                    {
                        comboBoxMom.Items.Add(id);
                    }
                    if (comboBoxMom.SelectedIndex==1 && gender == "Male")
                    {
                        comboBoxDad.Items.Add(id);
                    }

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
                if (!id_f.Equals(""))
                {
                    if (CageIds == cageId_f)
                    {
                        comboBoxCage.Items.Add(CageIds);
                        comboBoxCage.SelectedIndex = 0;
                    }
                }
                else
                {
                    comboBoxCage.Items.Add(CageIds);
                }

            }


            wbCage.Close();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wbCage);
            wbCage = null;
            wsCage = null;
            app2.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app2);
            app2 = null;
            
           
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
            double birdid;
            string spec = comboBoxSpec.Text;
            string subspec = comboBoxSubSpec.Text;
            string gen = comboBoxGend.Text;
            string date = dateTimePicker1.Value.ToString("dd/MM/yyyy"); ;
            string cageid = comboBoxCage.Text;
            string momid = comboBoxMom.Text;
            string dadid = comboBoxDad.Text;
            string momHeadcolor = "";
            string dadHeadcolor = "";
            string momBreastcolor = "";
            string dadBreastcolor = "";
            string momBodytcolor = "";
            string dadBodycolor = "";
            if (!double.TryParse(serial.Text, out birdid))
            {
                MessageBox.Show("Invalid bird ID. Please use only numbers.", "Error 305");
                return;
            }
            if (comboBoxCage.Items.Count == 0)
            {
                MessageBox.Show("No available cage! Add a cage first", "Error 203");
                return;
            }
            if (cageid=="")
            {
                MessageBox.Show("Cage not selected.", "Error 204");
                return;
            }
            if (momid=="")
            {
                MessageBox.Show("Mom not selected.", "Error 205");
                return;
            }
            if (dadid=="")
            {
                MessageBox.Show("Dad not selected.", "Error 206");
                return;
            }
            if (IsBirdIdUsed(birdid, momid, dadid, ref momHeadcolor, ref dadHeadcolor, ref momBreastcolor, ref dadBreastcolor, ref momBodytcolor, ref dadBodycolor))
            {
                MessageBox.Show("Bird ID already exists. Please choose a different ID.", "Error 202");
                return;
            }

            Application app = new Application();

            Workbook wb = app.Workbooks.Open(@"C:\FeatherFriend\DataBased\BirdDB.xlsx");
            Worksheet ws = wb.Worksheets["sheet1"];

            string BabyHeadColor = "";
            string BabyBreastColor = "";
            string BabyBodyColor = "";
            GeneticCalc(momHeadcolor, dadHeadcolor, momBreastcolor, dadBreastcolor, momBodytcolor, dadBodycolor, gen, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);

            headcolorBird.Text = BabyHeadColor;
            breastcolorBird.Text = BabyBreastColor;
            bodycolorBird.Text = BabyBodyColor;
            //format for image path
            // Gender+Headcolor+BodyColor+BreastColot
            try
            {
                pictureBox1.Image = Image.FromFile(@"C:\FeatherFriend\DataBased\birdphoto\" + gen + BabyHeadColor + BabyBreastColor + BabyBodyColor + ".png");
            }
            catch (FileNotFoundException e1) {
                pictureBox1.Image = Image.FromFile(@"C:\FeatherFriend\DataBased\birdphoto\checkmark.gif");
                pictureBox1.SizeMode=PictureBoxSizeMode.Zoom;
                Console.WriteLine("Catch in the add Bird Picture");
            }
            //pictureBox1.Image = Image.FromFile(@"C:\FeatherFriend\DataBased\birdphoto\MaleRedPurpleGreen.png");
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
            ws.Cells[row, 9].Value = BabyHeadColor;
            ws.Cells[row, 10].Value = BabyBreastColor;
            ws.Cells[row, 11].Value = BabyBodyColor;
            wb.Save();

            wb.Close();
            ws=null;
            MessageBox.Show("Bird add successfully!", "Success 102");
            app.Quit();


            System.Runtime.InteropServices.Marshal.ReleaseComObject(wb);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
            wb=null;
            app=null;

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }



        public void comboBoxSpec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSpec.SelectedIndex == 0)
            {
                comboBoxSubSpec.Items.Clear();
                comboBoxSubSpec.Text = "North America";
                comboBoxSubSpec.Items.Add("North America");
                comboBoxSubSpec.Items.Add("Central America");
                comboBoxSubSpec.Items.Add("South America");
            }
            else if (comboBoxSpec.SelectedIndex == 1)
            {
                comboBoxSubSpec.Items.Clear();
                comboBoxSubSpec.Text = "East Europe";
                comboBoxSubSpec.Items.Add("East Europe");
                comboBoxSubSpec.Items.Add("Western Europe");
            }
            else if (comboBoxSpec.SelectedIndex == 2)
            {
                comboBoxSubSpec.Items.Clear();
                comboBoxSubSpec.Text = "Central Australia";
                comboBoxSubSpec.Items.Add("Central Australia");
                comboBoxSubSpec.Items.Add("Coastal Cities");
            }
        }

        public static bool IsBirdIdUsed(double birdid, string momid, string dadid, ref string momHeadcolorcur, ref string dadHeadcolorcur, ref string momBreastcolorcur, ref string dadBreastcolorcur, ref string momBodycolorcur, ref string dadBodycolorcur)
        {
            Application app1 = new Application();
            Workbook wb1 = app1.Workbooks.Open(@"C:\FeatherFriend\DataBased\BirdDB.xlsx", ReadOnly: true);
            Worksheet ws1 = wb1.Worksheets["sheet1"];

            int row = 2;
            while (ws1.Cells[row, 1].Value != null)
            {
                double existingBirdId = ws1.Cells[row, 1].Value;
                if (existingBirdId == birdid)
                {
                    wb1.Close();
                    app1.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(wb1);
                    ws1=null;
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(app1);
                    wb1=null;
                    app1=null;

                    return true;
                }

                if (existingBirdId.ToString() == momid)
                {
                    string momheadcolor = ws1.Cells[row, 9].Value;
                    string mombreastcolor = ws1.Cells[row, 10].Value;
                    string mombodycolor = ws1.Cells[row, 11].Value;
                    momHeadcolorcur=momheadcolor;
                    momBreastcolorcur=mombreastcolor;
                    momBodycolorcur=mombodycolor;
                }

                if (existingBirdId.ToString() == dadid)
                {
                    string dadheadcolor = ws1.Cells[row, 9].Value;
                    string dadbreastcolor = ws1.Cells[row, 10].Value;
                    string dadbodycolor = ws1.Cells[row, 11].Value;
                    dadHeadcolorcur=dadheadcolor;
                    dadBreastcolorcur=dadbreastcolor;
                    dadBodycolorcur=dadbodycolor;
                }
                row++;
            }

            wb1.Close();
            app1.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wb1);
            ws1=null;
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app1);
            wb1=null;
            app1=null;
            return false;
        }



        public void GeneticCalc(string Headmom, string Headdad, string Breastmom, string Breastdad, string Bodymom, string Bodydad, string gend, ref string BabyHeadColor, ref string BabyBreastColor, ref string BabyBodyColor)
        {
            Application app = new Application();
            Workbook colordwb = app.Workbooks.Open(@"C:\FeatherFriend\DataBased\BirdColorGenetica.xlsx", ReadOnly: true);
            Worksheet colorws = colordwb.Worksheets["sheet1"];
            int genderCp = 0;
            if (gend == "Male")
                genderCp=4;
            if (gend == "Female")
                genderCp=5;

            int row = 2;
            while (row <= 5)
            {
                string dadheadc = Convert.ToString(colorws.Cells[row, 2].Value);
                string mombheadc = Convert.ToString(colorws.Cells[row, 3].Value);

                if (Headmom==mombheadc && Headdad==dadheadc)
                {
                    string temphead = Convert.ToString(colorws.Cells[row, genderCp].Value);
                    BabyHeadColor=temphead;
                    System.Console.WriteLine(BabyHeadColor);

                }
                row++;
            }
            System.Console.WriteLine(row);
            while (row <= 14)
            {
                string dadbreastc = Convert.ToString(colorws.Cells[row, 2].Value);
                string mombreastc = Convert.ToString(colorws.Cells[row, 3].Value);
                if (Breastmom==mombreastc && Breastdad==dadbreastc)
                {
                    string tempbreast = Convert.ToString(colorws.Cells[row, genderCp].Value);
                    BabyBreastColor=tempbreast;
                    System.Console.WriteLine(BabyBreastColor);
                }

                row++;
            }

            System.Console.WriteLine(row);
            while (row <= 29)
            {
                string dadbodyc = Convert.ToString(colorws.Cells[row, 2].Value);
                string mombodyc = Convert.ToString(colorws.Cells[row, 3].Value);

                if (Bodymom==mombodyc && Bodydad==dadbodyc)
                {
                    string tempbreast = Convert.ToString(colorws.Cells[row, genderCp].Value);
                    BabyBodyColor=tempbreast;
                    System.Console.WriteLine(BabyBodyColor);
                }

                row++;
            }
            System.Console.WriteLine(row);
            colordwb.Close();
            //System.Runtime.InteropServices.Marshal.ReleaseComObject(colordwb);
            colordwb=null;

            app.Quit();
            app=null;
            //System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
            colorws=null;

           
        }

        private void breastcolorBird_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

