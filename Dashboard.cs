﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace BirdManagment
{
    public partial class Dashboard : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
   (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
       int nHeightEllipse

    );
        public Dashboard(String rowUsername)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
            panel3.Left = button1.Left;
            button1.BackColor = Color.Thistle;
            label1.Text=rowUsername;
            lblTitle.Text = "Dashboard";
            this.frmLoader.Controls.Clear();
            frmDash frmDash_Vrb = new frmDash() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDash_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.frmLoader.Controls.Add(frmDash_Vrb);
            frmDash_Vrb.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
            panel3.Left = button1.Left;
            button1.BackColor=Color.Thistle;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;

            lblTitle.Text = "Dashboard";
            this.frmLoader.Controls.Clear();
            frmDash frmDash_Vrb = new frmDash() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDash_Vrb.FormBorderStyle=FormBorderStyle.None;
            this.frmLoader.Controls.Add(frmDash_Vrb);
            frmDash_Vrb.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            panel3.Height = button2.Height;
            panel3.Top = button2.Top;
            panel3.Left = button2.Left;
            button2.BackColor = Color.Thistle;
            button1.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;

            lblTitle.Text = "Add Bird";
            this.frmLoader.Controls.Clear();
            frmAddBird frmAddBird_Vrb = new frmAddBird("","","","") { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAddBird_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.frmLoader.Controls.Add(frmAddBird_Vrb);
            frmAddBird_Vrb.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            panel3.Height = button3.Height;
            panel3.Top = button3.Top;
            panel3.Left = button3.Left;
            button3.BackColor = Color.Thistle;
            button2.BackColor = Color.White;
            button1.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;


            lblTitle.Text = "Add Cage";
            this.frmLoader.Controls.Clear();
            frmAddCage frmAddCage_Vrb = new frmAddCage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAddCage_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.frmLoader.Controls.Add(frmAddCage_Vrb);
            frmAddCage_Vrb.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Height = button4.Height;
            panel3.Top = button4.Top;
            panel3.Left = button3.Left;
            button4.BackColor = Color.Thistle;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button1.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;


            lblTitle.Text = "Search Bird";
            this.frmLoader.Controls.Clear();
            frmSearchBird frmSearchBird_Vrb = new frmSearchBird() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmSearchBird_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.frmLoader.Controls.Add(frmSearchBird_Vrb);
            frmSearchBird_Vrb.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Height = button5.Height;
            panel3.Top = button5.Top;
            panel3.Left = button5.Left;
            button5.BackColor = Color.Thistle;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button1.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;


            lblTitle.Text = "Search Cage";
            this.frmLoader.Controls.Clear();
            frmSearchCage frmSearchCage_Vrb = new frmSearchCage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmSearchCage_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.frmLoader.Controls.Add(frmSearchCage_Vrb);
            frmSearchCage_Vrb.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            panel3.Height = button6.Height;
            panel3.Top = button6.Top;
            panel3.Left = button6.Left;
            button6.BackColor = Color.Thistle;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button1.BackColor = Color.White;
            button7.BackColor = Color.White;


            lblTitle.Text = "Bird info";
            this.frmLoader.Controls.Clear();
            frmBirdInfo frmBirdInfo_Vrb = new frmBirdInfo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmBirdInfo_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.frmLoader.Controls.Add(frmBirdInfo_Vrb);
            frmBirdInfo_Vrb.Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel3.Height = button7.Height;
            panel3.Top = button7.Top;
            panel3.Left = button7.Left;
            button7.BackColor = Color.Thistle;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button1.BackColor = Color.White;


            lblTitle.Text = "Cage info";
            this.frmLoader.Controls.Clear();
            frmCageInfo frmCageInfo_Vrb = new frmCageInfo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmCageInfo_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.frmLoader.Controls.Add(frmCageInfo_Vrb);
            frmCageInfo_Vrb.Show();
        }

        public void ReloadFrmLoaderForNewFled(Form form)
        {
            button2.BackColor = Color.Thistle;
            button1.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            lblTitle.Text = "Add Bird";
        
            this.frmLoader.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.frmLoader.Controls.Add(form);
            form.Show();
        }
        
        private void Button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Lavender;
        }
        private void Button2_Leave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Lavender;
        }
        private void Button3_Leave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Lavender;
        }
        private void Button4_Leave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Lavender;
        }
        private void Button5_Leave(object sender, EventArgs e)
        {
            button5.BackColor = Color.Lavender;
        }
        private void Button6_Leave(object sender, EventArgs e)
        {
            button6.BackColor = Color.Lavender;
        }
        private void Button7_Leave(object sender, EventArgs e)
        {
            button7.BackColor = Color.Lavender;
        }

        private void frmLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var myForm = new FeatherFriend();
            myForm.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
