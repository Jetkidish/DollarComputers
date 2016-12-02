using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// SplashFormTimer_Tick Event Handler
        /// This displays the splash form for 3 seconds, then moves on to the start form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            //this is so that the timer only goes once, otherwise it will open a billion forms
            SplashFormTimer.Enabled = false;
            //this is where the start form opens
            StartForm startform = new StartForm();
            startform.Show();
            //this hides the splash screen
            this.Hide();
        }
    }
}
