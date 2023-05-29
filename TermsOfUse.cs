using System;
using System.Windows.Forms;

namespace BirdManagment
{
    public partial class TermsOfUse : Form
    {
        public TermsOfUse()
        {
            InitializeComponent();
        }

        public void SetGif(string gifFilePath)
        {
            pictureBox1.ImageLocation = gifFilePath;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();


        }
    }
}
