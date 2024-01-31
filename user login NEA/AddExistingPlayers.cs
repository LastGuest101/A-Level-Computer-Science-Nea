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
            foreach (var LeagueName in League.GetLeagues())
            {
                LeagueComboBox.Items.Add(LeagueName);
            }
        }
        private void LeagueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> allPlayer_ID = Player.GetAllPlayers();
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
                    TeamComboBox.Items.Add(Team.GetTeamName(team_id));
                    foreach (var LeagueplayerID in Team.GetAllPlayerID(team_id))
                    {
                        allPlayer_ID.Remove(LeagueplayerID);

                    }
                }
                foreach (int NonLeaguePlayer_id in allPlayer_ID)
                {
                    PlayerComboBox.Items.Add(Player.GetFirstName(NonLeaguePlayer_id) + " " + Player.GetLastName(NonLeaguePlayer_id));
                }
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
            var SelectedPlayer = PlayerComboBox.SelectedItem.ToString().Split(" ");
            string SelectedFirstName = SelectedPlayer[0];
            string SelectedLastName = SelectedPlayer[1];
            selectedPlayer_id = Player.GetPlayerIDName(SelectedFirstName, SelectedLastName);
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
