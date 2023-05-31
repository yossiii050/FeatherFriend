using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace BirdManagment
{
    public partial class Login_v1 : Form
    {
        private Dictionary<string, string> userCredentials;
        public Login_v1()
        {
            InitializeComponent();
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

       // private void TextBox1_TextChanged(object sender, EventArgs e)
       // {
       // }

      //  private void Button1_Click(object sender, EventArgs e)
       // {}

        private void Login_v1_Load(object sender, EventArgs e)
        {
            
            string excelFilePath = @"C:\FeatherFriend\DataBased\UsersDB.xlsx";
            Application app = new Application();
            Workbook wb = app.Workbooks.Open(excelFilePath);
            Worksheet ws = wb.Worksheets["sheet1"];
            
            int rowCount = ws.Cells.SpecialCells(XlCellType.xlCellTypeLastCell).Row;
            userCredentials = new Dictionary<string, string>();
            for (int i = 2; i <= rowCount; i++)
            {
                string username = ws.Cells[i, 1].Value.ToString();
                string password = ws.Cells[i, 2].Value.ToString();
                userCredentials.Add(username, password);
            }
            wb.Close();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(wb);
            wb=null;
            app.Quit();
            ws = null;
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
            app= null;

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();

            
        }



        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtLoginUsername.Text = "";
            txtLoginPassword.Text = "";
        }

        private void ChkBxShowPW_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxShowPW.Checked)
            {
                pictureBox4.Image = BirdManagment.Properties.Resources.eye;
                txtLoginPassword.PasswordChar = '\0';
            }
            else
            {
                pictureBox4.Image = BirdManagment.Properties.Resources.closedeye;
                txtLoginPassword.PasswordChar = '•';

            }

        }

        private void BtnToRegister_Click(object sender, EventArgs e)
        {
            var myForm = new Regiter_v1();
            myForm.Show();
            this.Hide();

        }

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtLoginUsername.Text.Trim();
            string password = txtLoginPassword.Text.Trim();

            // check if the username and password are not empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
               
                MessageBox.Show("Empty fields! Please fill required fields.", "Exception 306", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                return;
            }

            // Validate username
            if (username.Length < 6 || username.Length > 8)
            {
                MessageBox.Show("Username must contain between 6 and 8 characters.", "Exception 307", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                return;
            }

            int digitCount = 0;
            foreach (char c in username)
            {
                if (Char.IsDigit(c))
                {
                    digitCount++;
                }
                
            }

            if (digitCount > 2)
            {
                MessageBox.Show("Username must contain at most 2 digits.", "Exception 308", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                return;
            }

            if (!IsPasswordValid(password))
            {
                MessageBox.Show("Password must be between 8 and 10 characters, and contain at least one letter, one digit, and one special character.", "Exception 309", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                return;
            }

            string hashedPassword = GetHashedPassword(password); 


            string filePath = @"C:\FeatherFriend\DataBased\UsersDB.xlsx";
            Application app = new Application();
            Workbook wb = app.Workbooks.Open(filePath);
            Worksheet ws = wb.Worksheets["sheet1"];

            
            int rowCount = ws.Cells.SpecialCells(XlCellType.xlCellTypeLastCell).Row;
           
            for (int i = 2; i <= rowCount; i++)
            {
                string rowUsername = ws.Cells[i, 1].Value.ToString().Trim();
                string rowPassword = ws.Cells[i, 2].Value.ToString();
                Console.WriteLine(rowUsername + " " + rowPassword);
                if (CompareStrings(rowUsername, username) == 0) {
                    if (CompareStrings(rowPassword, hashedPassword) == 0)
                    {

                        wb.Close();

                        System.Runtime.InteropServices.Marshal.ReleaseComObject(wb);
                        wb=null;
                        ws=null;
                        app.Quit();

                        System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
                        app= null;


                        MessageBox.Show("Login successful!", "Success 103", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var myForm = new Dashboard(rowUsername);
                        myForm.Show();
                        this.Hide();

                        System.GC.Collect();
                        System.GC.WaitForPendingFinalizers();

                        return;
                    }
                    MessageBox.Show("Password doesn't match the username.", "Error 218", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();
                    return;

                }
                
                
            }

           
            wb.Close();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(wb);
            wb=null;
            ws=null;
            app.Quit();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
            app= null;
            
            MessageBox.Show("Invalid username or password.", "Error 207", MessageBoxButtons.OK, MessageBoxIcon.Error);
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();

        }
        private string GetHashedPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtLoginUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtLoginPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private bool IsUsernameValid(string username)
        {
            // check if the username contains between 6 and 8 characters, with at most 2 digits and all the rest letters
            return Regex.IsMatch(username, @"^[a-zA-Z]{4}[0-9]{0,2}$");
        }

        private bool IsPasswordValid(string password)
        {
            // check if the password contains at least one letter, one digit, and one special character
            return Regex.IsMatch(password, @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,10}$");
        }

        public int CompareStrings(string str1, string str2)
        {

            int result = string.Compare(str1, str2, true);

            // The return value will be:
            //     0 if the strings are equal
            //     a negative integer if str1 is less than str2
            //     a positive integer if str1 is greater than str2
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }
    }
}
