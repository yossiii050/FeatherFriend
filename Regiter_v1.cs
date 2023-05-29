using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace BirdManagment
{
    public partial class Regiter_v1 : Form
    {
        public Regiter_v1()
        {
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtRegisterUsername.Text = "";
            txtRegisterPassword.Text = "";
            txtRegisterConfirmPW.Text = "";
            idTxt.Text = "";
        }

        private void Regiter_v1_Load(object sender, EventArgs e)
        {

        }

        private void ChkBxShowPW_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxShowPW.Checked) {
                pictureBox1.Image = BirdManagment.Properties.Resources.eye;
                pictureBox4.Image = BirdManagment.Properties.Resources.eye;
                txtRegisterPassword.PasswordChar = '\0';
                txtRegisterConfirmPW.PasswordChar = '\0'; 
            }
            else
            {
                pictureBox1.Image = BirdManagment.Properties.Resources.closedeye;
                pictureBox4.Image = BirdManagment.Properties.Resources.closedeye;
                txtRegisterPassword.PasswordChar = '•';
                txtRegisterConfirmPW.PasswordChar = '•'; ;

            }
        }
        
        private void TxtRegisterConfirmPW_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtRegisterPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            
            string username = txtRegisterUsername.Text;
            string password = txtRegisterPassword.Text;
            string confirmPW = txtRegisterConfirmPW.Text;
            string ID = idTxt.Text;

            // check if the username and password are not empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)|| string.IsNullOrEmpty(confirmPW)|| string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Empty fields! Please fill required fields.", "Exception 306", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate username
            if (username.Length < 6 || username.Length > 8)
            {
                MessageBox.Show("Username must contain between 6 and 8 characters.", "Exception 307", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(ID.Length!=9)
            {
                MessageBox.Show("ID must contain 9 numbers.", "Exception 311", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (char c in ID)
            {
                if (!Char.IsDigit(c))
                {
                    MessageBox.Show("ID must contain only digits.", "Exception 312", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            int digitCount = 0;
            foreach (char c in username)
            {
                if (Char.IsDigit(c))
                {
                    digitCount++;
                }
                else if (!Char.IsLetter(c))
                {
                    MessageBox.Show("Username must contain only letters and digits.", "Exception 310", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (digitCount > 2)
            {
                MessageBox.Show("Username must contain at most 2 digits.", "Exception 308", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (TermsCheckBox.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("You must accept the terms of use. ", "Exception 216", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            // check if the username already exists in the Excel file
            Application app = new Application();
            app.Visible = false;
            Workbook wb = app.Workbooks.Open(@"C:\FeatherFriend\DataBased\UsersDB.xlsx");
            Worksheet ws = wb.Worksheets["sheet1"];

            int lastRow = ws.Cells.SpecialCells(XlCellType.xlCellTypeLastCell).Row;
            for (int i = 2; i <= lastRow; i++)
            {
                string existingUsername = ws.Cells[i, 1].Value;
                if (existingUsername == username)
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Error 208", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    wb.Close(false);
                    app.Quit();
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();
                    return;
                }
                string existingID = ws.Cells[i, 3].Value.ToString();
                if (existingID == ID)
                {
                    MessageBox.Show("ID already exists. Please choose a different id.", "Error 209", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    wb.Close(false);
                    app.Quit();
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();
                    return;
                }
            }

            if (!IsPasswordValid(password))
            {
                MessageBox.Show("Password must be between 8 and 10 characters, and contain at least one letter, one digit, and one special character.", "Exception 309", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPW)
            {
                MessageBox.Show("Password and confirm password do not match!", "Error 210", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            
            int row = 2;
            while (ws.Cells[row, 1].Value != null)
            {
                row++;
            }

            
            ws.Cells[row, 1].Value = username;
            ws.Cells[row, 2].Value = password;
            ws.Cells[row, 3].Value = ID;


            wb.Save();
            
            wb.Close();
           
            MessageBox.Show("User registered successfully!", "Success 104", MessageBoxButtons.OK, MessageBoxIcon.Information);


            var myForm = new Dashboard(username);
            myForm.Show();
            this.Hide();


            System.Runtime.InteropServices.Marshal.ReleaseComObject(wb);
            wb = null;

            System.Runtime.InteropServices.Marshal.ReleaseComObject(ws);
            ws = null;

            app.Quit();
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var myForm = new Login_v1();
            myForm.Show();
            this.Hide();

           
        }

        public bool IsUsernameValid(string username)
        {
            // check if the username contains between 6 and 8 characters, with at most 2 digits and all the rest letters
            return Regex.IsMatch(username, @"^[a-zA-Z]{4}[0-9]{0,2}$");
        }

        private bool IsPasswordValid(string password)
        {
            // check if the password contains at least one letter, one digit, and one special character
            return Regex.IsMatch(password, @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,10}$");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var dialog = new TermsOfUse())
            {
                string gifFilePath = @"C:\FeatherFriend\DataBased\birdphoto\giphy.gif";  // Replace with the actual path to your GIF file
                dialog.SetGif(gifFilePath);
                dialog.ShowDialog();
            }

            
        }

        private void TermsCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
 