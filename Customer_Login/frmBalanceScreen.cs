using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Login
{
    public partial class frmBalanceScreen : Form
    {
        public static List<CustomerAccount> balanceList = new List<CustomerAccount>();
        //Set userName as input from previouse form
        private string userName = frmLogIn.userName;
        public frmBalanceScreen()
        {   //Get list of balances from txt files
            FileHandler.getBalanceList(balanceList);
            InitializeComponent();
            setUpLabels();
        }
        private void setUpLabels()
        {   //set name label to title text of username
            lblName.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(userName.ToLower());
            //Loop list of balances
            for (int i = 0; i < balanceList.Count; i++)
            {   //if username is same as name on list
                if (balanceList[i].CustomerSurname == userName)
                {   //set balance label to balance from txt fil in format of £0.00
                    lblBalance.Text = String.Format(new CultureInfo("en-GB"), "{0:C}", balanceList[i].CustomerAccountBalance, 2);
                }
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {   //Close form and open login form
            frmLogIn login = new frmLogIn();
            Dispose();
            login.Show();
        }
        //Close program if exit button clicked
        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();
        //Close program if 'x' button in corner clicked
        private void frmBalanceScreen_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
    }
}
