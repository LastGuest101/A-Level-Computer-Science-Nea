using System;
using System.Windows.Forms;

namespace user_login_NEA
{
    static class Program
    {
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Create and run your login form
            Application.Run(new LoginForm());
          

        }
      public static int Value()
        {
            return 69 ;
        }
        
    }
}
