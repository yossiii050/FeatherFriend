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
    public partial class FeatherFriend : Form
    {
        public FeatherFriend()
        {
            InitializeComponent();
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            var myForm = new Login_v1();
            myForm.Show();
            this.Hide();

        }

        private void REGISTER_Click(object sender, EventArgs e)
        {
            var myForm = new Regiter_v1();
            myForm.Show();
            this.Hide();

        }

        private void StartPage_Load(object sender, EventArgs e)
        {

        }
    }
}
