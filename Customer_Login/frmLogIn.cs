using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace Customer_Login
{
    public partial class frmLogIn : Form
    {
        public static List<CustomerPassword> passwordList = new List<CustomerPassword>();
        public static string userName = "";
        public frmLogIn()
        {   //Get list of passwords from txt file
            loadInitialPasswordList();
            InitializeComponent();
            Text = "Bank Ltd - Login";
            CenterToScreen();
            //Set textfield to hide input of text in password field
            txtPassword.UseSystemPasswordChar = true;
        }
        private void loadInitialPasswordList()
        {   //Only get new list if list is empty, such as first load
            if (passwordList.Count == 0)
            {
                FileHandler.getPasswordList(passwordList);
            }
        }
        private bool checkIfNotEmpty()
        {
            if (txtUserName.TextLength == 0)
            {   //If username empty
                MessageBox.Show("You must enter a Username to access your account. Please complete both to proceed", "NO USERNAME ENTERED", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtUserName.Select();
                return false;
            }
            else if (txtPassword.TextLength == 0)
            {   //if password empty
                MessageBox.Show("You must enter a Password to access your account. Please complete both to proceed", "NO PASSWORD ENTERED", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPassword.Select();
                return false;
            }
            return true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {   //Check if either field is empty
            if (checkIfNotEmpty())
            {//Set bool holder for username found
                bool nameFound = false;
                //set username to user input to alow sharing with next form - setting to lower case and removing all whitespaces
                userName = txtUserName.Text.Trim().ToLower();
                //Loop through list
                for (int i = 0; i < passwordList.Count; i++)
                {   //if username input is same as a name held on text file (not case sensitive)
                    if (passwordList[i].UserName == userName)
                    {   //check login attempts
                        if (passwordList[i].IncorrectPasswordCount >= 3)
                        {   //Account is locked
                            MessageBox.Show("Your account has been locked due to too many failed login attempt. Please call 1800 555 999 for your account to be unlocked.", "ACCOUNT LOCKED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {    //if password entered matches password on text file (case sensitive)
                            if (passwordList[i].Password == txtPassword.Text)
                            {   //Reset login attempts
                                passwordList[i].IncorrectPasswordCount = 0;
                                //Open balance screen and hide this
                                frmBalanceScreen balanceScreen = new frmBalanceScreen();
                                this.Hide();
                                balanceScreen.Show();
                            }
                            else
                            {   //Update incorrect password attemt
                                passwordList[i].IncorrectPasswordCount += 1;
                                //Show message to advise password not correct & clear password field
                                if (passwordList[i].IncorrectPasswordCount > 2)
                                {   //If third worng atttempt
                                    MessageBox.Show($"Your account is now locked. Please call 1800 555 999 for assistance.",
                                                    "ACCOUNT LOCKED", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                                else
                                {
                                    MessageBox.Show($"The password you have entered is incorrect, please remember the password is case sensative." +
                                                    $" You have {(3 - passwordList[i].IncorrectPasswordCount)} attempt(s) before your account is locked",
                                                    "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                //Highlight password text
                                txtPassword.SelectAll();
                                txtPassword.Focus();
                            }
                        }
                        //Set nameFound to true
                        nameFound = true;
                        //set i to size of list so loop can end
                        i = passwordList.Count;
                    }
                }
                //if name is not found in list
                if (!nameFound)
                {   //Show message advising username does not exist
                    MessageBox.Show("Please ensure you have entered your correct user name. If you have forgotton your user name please call us on 1800 555 999", "User Name Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    //Highlight username textfield text
                    txtUserName.SelectAll();
                    txtUserName.Focus();
                }
            }
        }
        //End application should user close window with 'x' in corner
        private void frmLogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Save updated incorrect passwprd count back to the txt file
            FileHandler.savePassworList(passwordList);
            Application.Exit();
        }
        private void mnuOpenHelp_Click(object sender, EventArgs e)
        {
            string helpFile = "Help.txt";
            //Check file exists before trying to open
            if (File.Exists(helpFile))
            {   //Open text file
                Process.Start(helpFile);
            }
            else
            {   //Show error message of file not found
                MessageBox.Show("It appears the help file is missing. Please call 1800 555 999 and we will assist", "FILE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}