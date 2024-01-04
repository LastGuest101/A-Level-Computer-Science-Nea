using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
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
                if (username.Length < 1 || username.Length > 30)
                {
                    return "Username has to be 1 - 30 characters long";
                }
                else
                {
                    if (Regex.IsMatch(username, "[^A-Za-z0-9_]") == true)
                    {
                        return "Username can only include alphanumeric characters and '_'";
                    }
                    else
                    {
                        return "valid";
                    }
                    
                }

               
            }
             

        }

        public static string PasswordValidator(string password)
        {
            if (Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*(\d|[^a-zA-Z])).{8,30}$"))
            {
                return "valid";
            }
            else if (password.Length < 8 || password.Length > 30)
            {
                return "Password must between 8 - 30 characters long.";
            }
            else if (!Regex.IsMatch(password, @"^(?=.*[a-z])"))
            {
                return "Password must contain at least one lowercase letter.";
            }
            else if (!Regex.IsMatch(password, @"^(?=.*[A-Z])"))
            {
                return "Password must contain at least one uppercase letter.";
            }
            else if (!Regex.IsMatch(password, @"^(?=.*(\d|[^a-zA-Z]))"))
            {
                return "Password must contain at least one digit or special character.";
            }
            
            
            {
                return "Password does not meet the required criteria.";
            }

        }
            
           
        

        

      public static bool OtherUsers(string username)
        {
            if (Database_manager.singleStringFromDB($"{username}", "Username", "Users", "Username") != null)
            { 
                return true;
            }
                return false;
        }
        

       

    }

    public class Player
    {
        public static string ValidateName (string name)
        {
            if (Regex.IsMatch(name, @"^[A-Z][a-z ,.'-]*$"))
            {
                return "Valid";
            }
          
            else
            {
                if (!Regex.IsMatch(name, @"^[A-Z]"))
                {
                    return "Error: First character must be an uppercase letter.";
                }
                else
                {
                    return "Error: Invalid characters or format.";
                }
            }
        }
    }
}
