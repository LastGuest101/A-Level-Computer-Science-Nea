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
        int team_id;
        int league_id;
        public AddingPlayers()
        {
            InitializeComponent();


        }

        private void AddingPlayers_Load(object sender, EventArgs e)
        {


            foreach (var LeagueName in League.GetLeagues()) //adds the league name of each entity in the table Leagues to the combobox

            {
                LeagueComboBox.Items.Add(LeagueName);

            }

        }

        private void LeagueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            league_id = League.GetLeagueIDLeagueName(LeagueComboBox.SelectedItem.ToString());


            TeamComboBox.Items.Clear();

            List<int> legaueTeams = new List<int>();

            if (LeagueComboBox.SelectedIndex.ToString() != null) // Checks if combobox is not empty
            {


                legaueTeams = Team.GetTeamID_leagueID(LeagueComboBox.SelectedIndex + 1);  // + 1 cause list starts at 0, and team_id starts at 1

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




                Player.AddPlayer($"{firstname}", $"{lastname}", team_id , league_id);
                MessageBox.Show($"Player has been added to the Database", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AddingPlayers addingPlayers = new();
                addingPlayers.Show();
                Hide();
            }





        }

        private void TeamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            team_id = Team.GetTeamID_TeamName(TeamComboBox.SelectedItem.ToString());  
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenuForm = new();
            adminMenuForm.Show();
            Hide();
        }
    }
}
