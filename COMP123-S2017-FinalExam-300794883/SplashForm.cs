using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Zilang Liang
 * Date: August 17, 2017
 * Description: This is the Splash Form
 * Version: 0.2 - Added Public property, and let the timer method shows PickHighestCard Form
 */

namespace COMP123_S2017_FinalExam_300794883
{
    public partial class SplashForm : Form
    {
        //PUBLIC PROPERTIES
        public PickHighestCardForm PickHighestCardForm
        {
            get
            {
                return Program.pickhighestcardForm;
            }
        }


        public SplashForm()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.PickHighestCardForm.Show();

            this.Hide();

            Timer.Enabled = false;
        }
    }
}
