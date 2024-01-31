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
            foreach (var LeagueName in League.GetLeagues())

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
            //Checks if the list is null
            if (LeagueComboBox.SelectedItem != null)
            {
                // + 1 cause list starts at 0, and team_id starts at 1 
                // Gets team_id's in a league
                // cross-table paramatised sql 
                List<int> leagueTeamsIDs = Team.GetTeamID_leagueID(LeagueComboBox.SelectedIndex + 1);
                foreach (var team_id in leagueTeamsIDs)
                {
                    //Gets the all the player_ids associated to the team_id.   cross-table paramatised sql
                    foreach (var playerID in Team.GetAllPlayerID(team_id))
                    {
                        //Adds the player's first name and last name to the list.
                        BowlerComboBox.Items.Add(Player.GetFirstName(playerID) + " " + Player.GetLastName(playerID));
                    }
                }
            }
            else
            {
                //Exception handling
                BowlerLabel.Text = "ERROR";
            }
        }
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            //Checks if the username is valid
            if (User.UsernameValidator(UsernameTextBox.Text) != "valid")
            {
                //displays the error, that cause the username to be invalid, exception handling.
                MessageBox.Show($"{User.UsernameValidator(UsernameTextBox.Text)}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsernameTextBox.Clear();
                UsernameTextBox.Focus();
            }
            //Checks if the password is valid
            if (User.PasswordValidator(PasswordTextbox.Text) != "valid")
            {
                //displays the error, that cause the password to be invalid, exception handling.
                MessageBox.Show($"{User.PasswordValidator(PasswordTextbox.Text)}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTextbox.Clear();
                PasswordTextbox.Focus();
            }
            //Checks if the bowler's list is null.
            if (BowlerComboBox.SelectedItem == null)
            {
                //Displays an error message if no bowler is selected to link the user's new account.
                MessageBox.Show($"Please select a player for this account. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (User.UsernameValidator(UsernameTextBox.Text) == "valid" && User.PasswordValidator(PasswordTextbox.Text) == "valid" && BowlerComboBox.SelectedItem != null)
            {
                //splits the string into two items in a string array, for the first name and last name.
                var SelectedPlayer = BowlerComboBox.SelectedItem.ToString().Split(" ");
                string SelectedFirstName = SelectedPlayer[0];
                string SelectedLastName = SelectedPlayer[1];

                int playerID = Player.GetPlayerIDName($"{SelectedFirstName}", $"{SelectedLastName}");
                //Adds the new user to the database.
                User.AddUser($"{UsernameTextBox.Text}", $"{PasswordTextbox.Text}", playerID);
                //Confirmation message.
                MessageBox.Show($"Successfully added {UsernameTextBox.Text} to database", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginForm LoginForm = new();
                LoginForm.Show();
                Hide();
            }
        }
    }
}

