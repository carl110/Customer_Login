using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Login
{
    public partial class SplashScreen : Form
    {
        string[] images = null;
        int counter = 0;
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
        //Rotate pictures on start
        private void SplashScreen_Load(object sender, EventArgs e)
        {   //Locate file containing images
            images = Directory.GetFiles(@"Money");
            //Set new timer class with interval of 0.5 seconds
            Timer T = new Timer();
            T.Interval = 500;
            T.Tick += new EventHandler(PlayTime);
            T.Start();
        }
        void PlayTime(object sender, EventArgs e)
        {   //run through pictures to display
            imgMoney.ImageLocation = images[counter++];
            //Go back to start when picture list exhausted
            if (counter >= images.Length) counter = 0;
        }
    }
}
