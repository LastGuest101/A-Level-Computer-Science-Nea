using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Mapping;
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
        // Creating variables that is accessed by the whole form
        int team_id;
        int league_id;

        //initialises the form
        public AddingPlayers()
        {
            InitializeComponent();
        }

        private void AddPlayerButton_Click_1(object sender, EventArgs e)
        {
            // Checks if anything has been selected from the LeagueComboBox    exception handling
                if (LeagueComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a league!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Checks if anything has been selected from the TeamComboBox    exception handling
            else if (TeamComboBox.SelectedIndex == -1) 
            {
                MessageBox.Show("Please select a team!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Checks if textbox is empty/contains only whitespace    exception handling 
            else if (String.IsNullOrWhiteSpace(FirstNameTextBox.Text)) 
            {
                FirstNameTextBox.Text = "ERROR";
                MessageBox.Show("Please enter a FirstName!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FirstNameTextBox.Clear();
                FirstNameTextBox.Focus();
            }
            // Checks if textbox is empty/contains only whitespace     exception handling
            else if (String.IsNullOrWhiteSpace(LastNameTextBox.Text)) 
            {
                LastNameTextBox.Text = "ERROR";
                MessageBox.Show("Please enter a LastName!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LastNameTextBox.Clear();
                LastNameTextBox.Focus();
            }
            // Checks if Name inputted is valid using Player.ValidateName     exception handling
            else if (Player.ValidateName(FirstNameTextBox.Text) != "Valid") 
            {
                FirstNameTextBox.Text = "ERROR";
                MessageBox.Show($"{Player.ValidateName(FirstNameTextBox.Text)} - FirstName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FirstNameTextBox.Clear();
                FirstNameTextBox.Focus();
            }
            // Checks if Name inputted is valid using Player.ValidateName     exception handling
            else if (Player.ValidateName(LastNameTextBox.Text) != "Valid")
            { 
                LastNameTextBox.Text = "ERROR";
                MessageBox.Show($"{Player.ValidateName(LastNameTextBox.Text)} - LastName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LastNameTextBox.Clear();
                LastNameTextBox.Focus();
            }

            else if (Team.NumberOfPlayers(team_id) > 5) // Teams should have a max of 6 players     exception handling 
            {
                MessageBox.Show($"Max number of players in a team had been reached (6) ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FirstNameTextBox.Clear();
                LastNameTextBox.Clear();
                LastNameTextBox.Focus();
            }

            else if (Player.OtherPlayers(FirstNameTextBox.Text, LastNameTextBox.Text) == true) // Checks if player is already added into database     exception handling 
            {
                MessageBox.Show($"Player is already in the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FirstNameTextBox.Clear();
                LastNameTextBox.Clear();
                LastNameTextBox.Focus();
            }

            else if (Player.ValidateName(FirstNameTextBox.Text) == "Valid" && Player.ValidateName(LastNameTextBox.Text) == "Valid") //Adds a new player with user's inputted data to the database 
            {
                string firstname = FirstNameTextBox.Text;
                string lastname = LastNameTextBox.Text;

                Player.AddPlayer($"{firstname}", $"{lastname}", team_id, league_id);    // calls method in the entity to add player to the database
                MessageBox.Show($"Player has been added to the Database", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information); //confirmation that data was added to the database

                AddingPlayers addingPlayers = new();
                addingPlayers.Show();
                Hide();
            }
        }
        //Creates an Admin Menu, and shows the admin menu, whilst hiding the currently opened menu (admin Menu)
        //When the back button is pressed.
        private void backButton_Click_1(object sender, EventArgs e)
        {
            AdminMenu adminMenuForm = new();
            adminMenuForm.Show();
            Hide();
        }
        //Calls the method when the user selects a new item from the team's list
        private void TeamComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            team_id = Team.GetTeamID_TeamName(TeamComboBox.SelectedItem.ToString()); //Gets the teamID from the user selected TeamName from the TeamComboBox
        }
        //method is called when the form is loading.
        private void AddingPlayers_Load_1(object sender, EventArgs e)
        {
            foreach (var LeagueName in League.GetLeagues()) //adds the league name of each entity in the table Leagues to the combobox
            {
                LeagueComboBox.Items.Add(LeagueName);
            }
        }
        //method is called when an the user selects a different league form the LeagueComboBox
        private void LeagueComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            league_id = League.GetLeagueIDLeagueName(LeagueComboBox.SelectedItem.ToString()); // leagueID = selected league from user
            TeamComboBox.Items.Clear(); //TeamsComboBox is cleared

            List<int> legaueTeams = new List<int>(); //Used to store all the team_ids related to the league selected.

            if (LeagueComboBox.SelectedIndex.ToString() != null) // Checks if League ComboBox is not empty
            { 
                legaueTeams = Team.GetTeamID_leagueID(LeagueComboBox.SelectedIndex + 1);  // + 1 cause list starts at 0, and team_id starts at 1

                foreach (var team in legaueTeams) //adds the team name of each entity in the table Leagues to the combobox, dependent on what league is selected first.
                {
                    TeamComboBox.Items.Add(Team.GetTeamName(team));
                }
            }
            else //Exception handling
            {
                MessageBox.Show("Unknown ERROR with LeagueComboBox!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // exception handling
            }
        }
    }
}
