using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
            // Load the Excel file containing the usernames and passwords
            string excelFilePath = @"C:\FeatherFriend\DataBased\UsersDB.xlsx";
            Application app = new Application();
            Workbook wb = app.Workbooks.Open(excelFilePath);
            Worksheet ws = wb.Worksheets["sheet1"];

            // Read the data from the Excel file and store it in memory
            int rowCount = ws.Cells.SpecialCells(XlCellType.xlCellTypeLastCell).Row;
            userCredentials = new Dictionary<string, string>();
            for (int i = 2; i <= rowCount; i++)
            {
                string username = ws.Cells[i, 1].Value.ToString();
                string password = ws.Cells[i, 2].Value.ToString();
                userCredentials.Add(username, password);
            }

           /** wb.Close();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(wb);
            wb=null;
            app.Quit();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
            app= null;

            // Close the Excel file
            // wb.Close();
            // app.Quit();
        **/
            }

        //private void btnLogin_Click(object sender, EventArgs e)
       // {
       // }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtLoginUsername.Text = "";
            txtLoginPassword.Text = "";
        }

        private void ChkBxShowPW_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxShowPW.Checked)
            {
                txtLoginPassword.PasswordChar = '\0';
            }
            else
            {
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
                MessageBox.Show("Please enter username and password.");
                return;
            }

            // Validate username
            if (username.Length < 6 || username.Length > 8)
            {
                MessageBox.Show("Username must contain between 6 and 8 characters.");
                return;
            }

            int digitCount = 0;
            foreach (char c in username)
            {
                if (Char.IsDigit(c))
                {
                    digitCount++;
                }
                /*else if (!Char.IsLetter(c))
                {
                   // MessageBox.Show("Username must contain only letters and digits.");
                    return;
                }*/
            }

            if (digitCount > 2)
            {
                MessageBox.Show("Username must contain at most 2 digits.");
                return;
            }
            /*
            if (!IsUsernameValid(username))
            {
                MessageBox.Show("Username must contain between 6 and 8 characters. Of the characters, at most 2 digits and all the rest letters.");
                return;
            }
            */
            if (!IsPasswordValid(password))
            {
                MessageBox.Show("Password must be between 8 and 10 characters, and contain at least one letter, one digit, and one special character.");
                return;
            }


            // load the Excel file
            string filePath = @"C:\FeatherFriend\DataBased\UsersDB.xlsx";
            Application app = new Application();
            Workbook wb = app.Workbooks.Open(filePath);
            Worksheet ws = wb.Worksheets["sheet1"];

            // Read the data from the Excel file and store it in memory
            int rowCount = ws.Cells.SpecialCells(XlCellType.xlCellTypeLastCell).Row;
           // userCredentials = new Dictionary<string, string>();
            for (int i = 2; i <= rowCount; i++)
            {
                string rowUsername = ws.Cells[i, 1].Value.ToString().Trim();
                string rowPassword = ws.Cells[i, 2].Value.ToString().Trim();

                if (CompareStrings(rowUsername, username) == 0)
                    if (CompareStrings(rowPassword, password) == 0)
                    {
                        MessageBox.Show("Login successful!");
                        var myForm = new Dashboard(rowUsername);
                        myForm.Show();
                        this.Hide();
                        wb.Close();

                        System.Runtime.InteropServices.Marshal.ReleaseComObject(wb);
                        wb=null;
                        app.Quit();

                        System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
                        app= null;

                        System.GC.Collect();
                        System.GC.WaitForPendingFinalizers();
                        return;
                    }
                //if((rowUsername==username) && (rowPassword==password))
                   // Console.WriteLine(username + " " + password);

                //userCredentials.Add(rowUsername, rowPassword);
            }

            /*foreach (KeyValuePair<string, string> entry in userCredentials)
            {
                Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
            }*/

            // Close the Excel file
            wb.Close();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(wb);
            wb=null;
            app.Quit();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
            app= null;

            // Console.WriteLine(userCredentials[username]);

            // Check if the entered username and password match any in the dictionary
            /* if (userCredentials[username] == password)
             {
                 MessageBox.Show("Login successful!");
                 var myForm = new Dashboard();
                 myForm.Show();
                 this.Hide();
                 return;
             }*/

            // If no match is found, show an error message
            MessageBox.Show("Invalid username or password.");
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
            // Use regular expressions to check if the username contains between 6 and 8 characters, with at most 2 digits and all the rest letters
            return Regex.IsMatch(username, @"^[a-zA-Z]{4}[0-9]{0,2}$");
        }

        private bool IsPasswordValid(string password)
        {
            // Use regular expressions to check if the password contains at least one letter, one digit, and one special character
            return Regex.IsMatch(password, @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,10}$");
        }

        public int CompareStrings(string str1, string str2)
        {
            // Compare the two strings using the string.Compare() method
            // The third parameter "true" specifies that the comparison should ignore case sensitivity
            int result = string.Compare(str1, str2, true);

            // The return value will be:
            //     0 if the strings are equal
            //     a negative integer if str1 is less than str2
            //     a positive integer if str1 is greater than str2
            return result;
        }
    }
}
