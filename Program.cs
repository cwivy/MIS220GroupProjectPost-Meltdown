//--------------------------------------------
//              Team 6 MIS 220 Project
//                December 1, 2015

// Team Lead: Carlton Ivy
// Team Members: Christian Getsinger, Lauryn Day, Dallas Locke
//
// Code managed and Collab. on GitHub - Repository: https://github.com/cwivy/MIS220GroupProjectPost-Meltdown.git
//
// -------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MIS220GroupProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginScreen());
            
        }
    }


}
