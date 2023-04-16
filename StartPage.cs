using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdManagment
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            var myForm = new Login();
            myForm.Show();
            this.Hide();

        }

        private void REGISTER_Click(object sender, EventArgs e)
        {
            var myForm = new Dashboard();
            myForm.Show();
            this.Hide();

        }

        private void StartPage_Load(object sender, EventArgs e)
        {

        }
    }
}
