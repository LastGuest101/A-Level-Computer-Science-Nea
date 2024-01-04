using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace user_login_NEA
{
    public class User
    {
        public int user_id { get; set; }

        public int player_id { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public string email { get; set; }

        public int admin { get; set; }

        public static string UsernameValidator(string username)
        {
          
            if (OtherUsers(username) == true) 
            {

                return "Username Taken";
            }
            else
            {
                if (username.Length < 4 || username.Length > 30)
                {
                    return "Username has to be between 5 - 30 characters long";
                }
                else
                {
                    return "valid";
                }
            }
             

        }

        

      public static bool OtherUsers(string username)
        {
            if (Database_manager.singleStringFromDB($"{username}", "Username", "Users", "Username") != null)
            {
                return true;
            }
            
            else
            {
                return false;
            }
        }
        

       

    }

}
