using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name:Zilang Liang
 * Date:August 17,2017
 * StudentID:300794883
 * Description:This is Program class
 * Version:version 0.2 - Created an instance of the PickHighestCardForm object
 */

namespace COMP123_S2017_FinalExam_300794883
{
    public static class Program
    {
        //Created Reference to Forms
        public static PickHighestCardForm pickhighestcardForm;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Instantiate a new object of type PickHighestCardForm
            pickhighestcardForm = new PickHighestCardForm();
            Application.Run(new PickHighestCardForm());
        }
    }
}
