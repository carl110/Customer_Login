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
                MessageBox.Show("You must enter both a Useername and Password to access your account", "Empty Field");
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
                {   //if password entered matches password on text file (case sensitive)
                    if (passwordList[i].Password == txtPassword.Text)
                    {   //Open balance screen and hide this
                        frmBalanceScreen balanceScreen = new frmBalanceScreen();
                        this.Hide();
                        balanceScreen.Show();
                    }
                    else
                    {   //Show message to advise password not correct & clear password field
                        MessageBox.Show("The password you have entered is incorrect, please remember the password is case sensative.",
                                        "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //Highlight password text
                        txtPassword.SelectAll();
                        txtPassword.Focus();
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