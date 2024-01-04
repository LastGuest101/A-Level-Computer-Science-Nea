using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_login_NEA
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();


        }
        private void SignUp_Load(object sender, EventArgs e)
        {
            foreach (var LeagueName in Database_manager.columnStringFromDB("Leagues", "LeagueName"))

            {
                LeagueComboBox.Items.Add(LeagueName);

            }
        }


        private void LoginInButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new();
            loginForm.Show();
            Hide();
        }

        private void LeagueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BowlerComboBox.Items.Clear();

            List<int> legaueTeams = new List<int>();

            if (LeagueComboBox.SelectedIndex.ToString() != null)
            {


                legaueTeams = Database_manager.multipleIntFromDB($"{LeagueComboBox.SelectedIndex.ToString() + 1}", "league_id", "Teams", "team_id"); // + 1 cause list starts at 0, and team_id starts at 1

                foreach (var team in legaueTeams)
                {

                    foreach (var playerID in Database_manager.multipleIntFromDB($"{team}", "team_id", "Teams/Players", "player_id"))
                    {

                        BowlerComboBox.Items.Add(Database_manager.singleStringFromDB($"{playerID}", "player_id", "Players", "FirstName") + " " + Database_manager.singleStringFromDB($"{playerID}", "player_id", "Players", "LastName"));
                    }
                }
            }
            else
            {
                //BowlerLabel.Text = "FAIL!";
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {

            ValidatorLabel.Text = User.UsernameValidator(UsernameTextBox.Text);




            //ValidatorLabel.Text = Database_manager.singleStringFromDB($"{UsernameTextBox.Text}", "Username", "Users", "Username");
            /* if (User.OtherUsers(UsernameTextBox.Text) == true)
             {
                ValidatorLabel.Text = "true";
             }
             else
             {
                 ValidatorLabel.Text = "false";
             }
            */


        }

        
    }
}
