using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Login
{
    public partial class frmLogIn : Form
    {
        public static List<CustomerPassword> passwordList = new List<CustomerPassword>();
        public static string userName = "";
        public frmLogIn()
        {
            //Get list of passwords from txt file
            FileHandler.getPasswordList(passwordList);
            InitializeComponent();
            Text = "Bank Ltd - Login";
            CenterToScreen();
            //Set textfield to hide input of text in password field
            txtPassword.UseSystemPasswordChar = true;
        }
        private void checkIfEmpty(object sender)
        {
            if ((sender as TextBox).TextLength == 0)
            {
                MessageBox.Show("You must enter both a Useername and Password to access your account", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {   //Set bool holder for username found
            bool nameFound = false;
            //set username to user input to alow sharing with next form
            userName = txtUserName.Text.ToLower();
            //Loop through list
            for (int i = 0; i < passwordList.Count; i++)
            {   //if username input is same as a name held on text file (not case sensitive)
                if (passwordList[i].Surname == userName)
                    //check login attempts
                {   if (passwordList[i].IncorrectPasswordCount < 3)
                    {
                        //if password entered matches password on text file (case sensitive)
                        if (passwordList[i].Password == txtPassword.Text)
                        {   //Reset login attempts
                            passwordList[i].IncorrectPasswordCount = 0;
                            FileHandler.savePassworList(passwordList);
                            //Open balance screen and hide this
                            frmBalanceScreen balanceScreen = new frmBalanceScreen();
                            this.Hide();
                            balanceScreen.Show();
                        }
                        else
                        {   //UUpdate incorrect password attemt
                            passwordList[i].IncorrectPasswordCount += 1;
                            FileHandler.savePassworList(passwordList);
                            //Show message to advise password not correct & clear password field
                            if (passwordList[i].IncorrectPasswordCount > 2)
                            {   //If third worng atttempt
                                MessageBox.Show($"Your account is now locked. Please call 1800 555 999 for assistance.", "ACCOUNT LOCKED", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            } else
                            {
                                MessageBox.Show($"The password you have entered is incorrect, please remember the password is case sensative. You have {(3 - passwordList[i].IncorrectPasswordCount)} attempt(s) before your account is locked",
                                                "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            //Highlight password text
                            txtPassword.SelectAll();
                            txtPassword.Focus();
                        }
                    } else
                    {
                        MessageBox.Show("Your account has been locked due to too many failed login attempt. Please call 1800 555 999 for your account to be unlocked.", "ACCOUNT LOCKED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //Set nameFound to tru
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
        //End application should user close window with 'x' in corner
        private void frmLogIn_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
    }
}