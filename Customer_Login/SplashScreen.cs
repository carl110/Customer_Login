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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        //Use timer class
        Timer tmr;
        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            //set tmr as timer call
            tmr = new Timer();
            //set time interval 3 sec
            tmr.Interval = 3000;
            //start the timer
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }
        void tmr_Tick(object sender, EventArgs e)
        {   //stop the time
            tmr.Stop();
            //display LogIn
            frmLogIn logIn = new frmLogIn();
            logIn.Show();
            //get rid of this form
            this.Hide();
        }
    }
}
