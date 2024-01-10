using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_login_NEA
{
    public partial class AddingPlayers : Form
    {
        string team_id;
        string league_id;
        public AddingPlayers()
        {
            InitializeComponent();


        }

        private void AddingPlayers_Load(object sender, EventArgs e)
        {


            foreach (var LeagueName in Database_manager.columnStringFromDB("Leagues", "LeagueName")) //adds the league name of each entity in the table Leagues to the combobox

            {
                LeagueComboBox.Items.Add(LeagueName);

            }

        }

        private void LeagueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            league_id = Convert.ToString(Database_manager.singleIntFromDB($"{LeagueComboBox.SelectedItem}", "LeagueName", "Leagues", "league_id"));


            TeamComboBox.Items.Clear();

            List<int> legaueTeams = new List<int>(); 

            if (LeagueComboBox.SelectedIndex.ToString() != null) // Checks if combobox is not empty
            {


                legaueTeams = Database_manager.multipleIntFromDB($"{(LeagueComboBox.SelectedIndex + 1).ToString()}", "league_id", "Teams", "team_id"); // + 1 cause list starts at 0, and team_id starts at 1

                foreach (var team in legaueTeams) //adds the team name of each entity in the table Leagues to the combobox, dependent on what league is selected first.
                {



                    TeamComboBox.Items.Add(Database_manager.singleStringFromDB($"{team}", "team_id", "Teams", "TeamName"));
                }
            }
            else
            {
                TeamLabel.Text = "ERROR";
            }
        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            if (LeagueComboBox.SelectedIndex == -1) // Checks if anything has been selected from the LeagueComboBox
            {
                MessageBox.Show("Please select a league!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TeamComboBox.SelectedIndex == -1) // Checks if anything has been selected from the TeamComboBox
            {
                MessageBox.Show("Please select a team!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            else if (String.IsNullOrWhiteSpace(FirstNameTextBox.Text)) // Checks if textbox is empty/contains only whitespace
            {
                FirstNameTextBox.Text = "ERROR";
                MessageBox.Show("Please enter a FirstName!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FirstNameTextBox.Clear();
                FirstNameTextBox.Focus();
            }
            else if (String.IsNullOrWhiteSpace(LastNameTextBox.Text)) // Checks if textbox is empty/contains only whitespace
            {
                LastNameTextBox.Text = "ERROR";
                MessageBox.Show("Please enter a LastName!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LastNameTextBox.Clear();
                LastNameTextBox.Focus();
            }


            else if (Player.ValidateName(FirstNameTextBox.Text) != "Valid") // Checks if Name inputted is valid using Player.ValidateName
            {
                FirstNameTextBox.Text = "ERROR";
                MessageBox.Show($"{Player.ValidateName(FirstNameTextBox.Text)} - FirstName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FirstNameTextBox.Clear();
                FirstNameTextBox.Focus();
            }
            else if (Player.ValidateName(LastNameTextBox.Text) != "Valid") // Checks if Name inputted is valid using Player.ValidateName
            {
                LastNameTextBox.Text = "ERROR";
                MessageBox.Show($"{Player.ValidateName(LastNameTextBox.Text)} - LastName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LastNameTextBox.Clear();
                LastNameTextBox.Focus();
            }

            else if (Team.NumberOfPlayers(TeamComboBox.SelectedText) > 6) // Teams should have a max of 6 players (*NEEDS TESTING)
            {
                MessageBox.Show($"Max number of players in a team had been reached (6) ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FirstNameTextBox.Clear();
                LastNameTextBox.Clear();
                LastNameTextBox.Focus();
            }

            else if (Player.OtherPlayers(FirstNameTextBox.Text, LastNameTextBox.Text) == true) // Checks if player is already added into database
            {
                MessageBox.Show($"Player is already in the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FirstNameTextBox.Clear();
                LastNameTextBox.Clear();
                LastNameTextBox.Focus();
            }





            else if (Player.ValidateName(FirstNameTextBox.Text) == "Valid" && Player.ValidateName(LastNameTextBox.Text) == "Valid") //Adds a new player and associated data to the database.
            {
                string firstname = FirstNameTextBox.Text;
                string lastname = LastNameTextBox.Text;
                FirstNameLabel.Text = "VALID";



                Player.AddPlayer($"{firstname}", $"{lastname}", $"{team_id}", $"{league_id}");
            }





        }

        private void TeamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            team_id = Convert.ToString(Database_manager.singleIntFromDB($"{TeamComboBox.SelectedItem}", "TeamName", "Teams", "team_id"));
        }
    }
}
