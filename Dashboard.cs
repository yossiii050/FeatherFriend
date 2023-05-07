using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public Dashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
            panel3.Left = button1.Left;
            button1.BackColor = Color.FromArgb(46, 51, 73);

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

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
            panel3.Left = button1.Left;
            button1.BackColor=Color.FromArgb(46,51,73);

            lblTitle.Text = "Dashboard";
            this.frmLoader.Controls.Clear();
            frmDash frmDash_Vrb = new frmDash() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDash_Vrb.FormBorderStyle=FormBorderStyle.None;
            this.frmLoader.Controls.Add(frmDash_Vrb);
            frmDash_Vrb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Height = button2.Height;
            panel3.Top = button2.Top;
            panel3.Left = button2.Left;
            button2.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Add Bird";
            this.frmLoader.Controls.Clear();
            frmAddBird frmAddBird_Vrb = new frmAddBird() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAddBird_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.frmLoader.Controls.Add(frmAddBird_Vrb);
            frmAddBird_Vrb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Height = button3.Height;
            panel3.Top = button3.Top;
            panel3.Left = button3.Left;
            button3.BackColor = Color.FromArgb(46, 51, 73);


            lblTitle.Text = "Add Cage";
            this.frmLoader.Controls.Clear();
            frmAddCage frmAddCage_Vrb = new frmAddCage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAddCage_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.frmLoader.Controls.Add(frmAddCage_Vrb);
            frmAddCage_Vrb.Show();
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void button2_Leave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void button3_Leave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(24, 30, 54);
        }

      
    }
}
