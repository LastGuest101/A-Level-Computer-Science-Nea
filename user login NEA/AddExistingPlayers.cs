using System;
using System.Collections;
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
    public partial class AddExistingPlayers : Form
    {
        int selectedLeague_id;
        int selectedPlayer_id;
        int selectedTeam_id;
        public AddExistingPlayers()
        {
            InitializeComponent();
        }
        //Creates an Admin Menu, and shows the admin menu, whilst hiding the currently opened menu (admin Menu)
        //When the back button is pressed.
        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenuForm = new();
            adminMenuForm.Show();
            Hide();
        }

        private void AddExistingPlayers_Load(object sender, EventArgs e)
        {
            //Gets all the League Names from the database
            //and adds them to the leagueComboBox.
            foreach (var LeagueName in League.GetLeagues())
            {
                LeagueComboBox.Items.Add(LeagueName);
            }
        }
        private void LeagueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> allPlayer_ID = Player.GetAllPlayers();
            //Gets all the playerIDs in the database 
            TeamComboBox.Items.Clear();
            PlayerComboBox.Items.Clear();
            //Checks if the list is null
            if (LeagueComboBox.SelectedItem != null)
            {
                selectedLeague_id = League.GetLeagueIDLeagueName(LeagueComboBox.SelectedItem.ToString());

                // + 1 cause list starts at 0, and team_id starts at 1 
                // Gets team_id's in a league
                // cross-table paramatised sql 
                List<int> leagueTeamsIDs = Team.GetTeamID_leagueID(LeagueComboBox.SelectedIndex + 1);
                foreach (var team_id in leagueTeamsIDs)
                {
                    //Adds each teamname in a league to the team Combobox
                    TeamComboBox.Items.Add(Team.GetTeamName(team_id));
                    foreach (var LeagueplayerID in Team.GetAllPlayerID(team_id))
                    {
                        //Removes all players already in the existing selected league
                        //From the all playerID list
                        allPlayer_ID.Remove(LeagueplayerID);
                    }
                }
                foreach (int NonLeaguePlayer_id in allPlayer_ID)
                {
                    //Adds all players who are not already in the league to the Player combobox
                    PlayerComboBox.Items.Add(Player.GetFirstName(NonLeaguePlayer_id) + " " + Player.GetLastName(NonLeaguePlayer_id));
                }
                //Checks that all the comboboxs have selected items before showing the add button.
                if (LeagueComboBox.SelectedItem != null && TeamComboBox.SelectedItem != null && PlayerComboBox.SelectedItem != null)
                {
                    AddButton.Visible = true;
                }
                else
                {
                    AddButton.Visible = false;
                }
            }
        }

        private void TeamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTeam_id = Team.GetTeamID_TeamName(TeamComboBox.SelectedItem.ToString());
            //Checks that all the comboboxs have selected items before showing the add button.
            if (LeagueComboBox.SelectedItem != null && TeamComboBox.SelectedItem != null && PlayerComboBox.SelectedItem != null)
            {
                AddButton.Visible = true;
            }
            else
            {
                AddButton.Visible = false;
            }

        }

        private void PlayerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Splits the string into a string[] seperated by the whitespace
            //between the firstname and lastname.
            var SelectedPlayer = PlayerComboBox.SelectedItem.ToString().Split(" ");
            string SelectedFirstName = SelectedPlayer[0];
            string SelectedLastName = SelectedPlayer[1];
            selectedPlayer_id = Player.GetPlayerIDName(SelectedFirstName, SelectedLastName);
            //Checks that all the comboboxs have selected items before showing the add button.
            if (LeagueComboBox.SelectedItem != null && TeamComboBox.SelectedItem != null && PlayerComboBox.SelectedItem != null)
            {
                AddButton.Visible = true;
            }
            else
            {
                AddButton.Visible = false;
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            //confirmation if the player wants to add the scores they have inputted.
            DialogResult res = MessageBox.Show($"Are you sure you want to add Player: {PlayerComboBox.SelectedItem.ToString()}" +
                $" To team: {TeamComboBox.SelectedItem.ToString()}?", "ADD PLAYER", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                this.Show();
            }
            else
            {
                Player.AddExistingPlayer(selectedPlayer_id, selectedTeam_id, selectedLeague_id);
                MessageBox.Show($"{PlayerComboBox.SelectedItem.ToString()} has been added to team: {TeamComboBox.SelectedItem.ToString()} ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //confirmation that data was added to the database
                AddingPlayers addingPlayers = new();
                addingPlayers.Show();
                Hide();
            }
        }
    }
}
