using System;
using System.Windows.Forms;

namespace user_login_NEA
{
    static class Program
    {
        //Used to start up the Form
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Create and run your login form
            Application.Run(new LoginForm());
        }
    }
}
