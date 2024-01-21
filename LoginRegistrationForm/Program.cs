using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegistrationForm
{
    static class Program
    {
        /// The main entry point for the application.
        [STAThread]
        static void Main()
        {
            //login form load
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginForm());
        }
    }
}
