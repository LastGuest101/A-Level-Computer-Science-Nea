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


                legaueTeams = Database_manager.multipleIntFromDB($"{LeagueComboBox.SelectedIndex + 1}", "league_id", "Teams", "team_id"); // + 1 cause list starts at 0, and team_id starts at 1 // Gets team_id's in a league

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
                BowlerLabel.Text = "ERROR";
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (User.UsernameValidator(UsernameTextBox.Text) != "valid")
            {
                MessageBox.Show($"{User.UsernameValidator(UsernameTextBox.Text)}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsernameTextBox.Clear();
                UsernameTextBox.Focus();
               
            }

            if (User.PasswordValidator(PasswordTextbox.Text) != "valid")
            {
                MessageBox.Show($"{User.PasswordValidator(PasswordTextbox.Text)}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTextbox.Clear();
                PasswordTextbox.Focus();
            }

            if(BowlerComboBox.SelectedItem == null)
            {
                MessageBox.Show($"Please select a player for this account. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (User.UsernameValidator(UsernameTextBox.Text) == "valid" && User.PasswordValidator(PasswordTextbox.Text) == "valid" && BowlerComboBox.SelectedItem != null)
            {
                var SelectedPlayer = BowlerComboBox.SelectedItem.ToString().Split(" ");
                string SelectedFirstName = SelectedPlayer[0];
                string SelectedLastName = SelectedPlayer[1];


                int playerID = Player.GetPlayerIDName($"{SelectedFirstName}", $"{SelectedLastName}");
                User.AddUser($"{UsernameTextBox.Text}", $"{PasswordTextbox.Text}", playerID);
                MessageBox.Show($"Successfully added {UsernameTextBox.Text} to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoginForm LoginForm = new();
                LoginForm.Show();
                Hide();


            }
            
             
             
            


        }

    }
}

