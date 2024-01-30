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
    public partial class RemovingPlayers : Form
    {

        int team_id;
        int league_id;
        int player_id;
        public RemovingPlayers()
        {
            InitializeComponent();
        }
        private void RemovingPlayers_Load(object sender, EventArgs e)
        {
            foreach (var LeagueName in League.GetLeagues()) //adds the league name of each entity in the table Leagues to the combobox
            {
                LeagueComboBox.Items.Add(LeagueName);
            }
        }
        private void LeagueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            league_id = League.GetLeagueIDLeagueName(LeagueComboBox.SelectedItem.ToString()); // leagueID = selected league from user


            TeamComboBox.Items.Clear();//TeamsComboBox is cleared
            PlayerComboBox.Items.Clear();//PlayersComboBox is cleared

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

        private void TeamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            team_id = Team.GetTeamID_TeamName(TeamComboBox.SelectedItem.ToString()); // TeamId = selected Team from user


            PlayerComboBox.Items.Clear(); //PlayersComboBox is cleared

            List<int> PlayersInTeam = new List<int>(); //Used to store all the player_ids related to the team selected.

            if (TeamComboBox.SelectedIndex.ToString() != null) // Checks if Team ComboBox is not empty
            {


                PlayersInTeam = Team.GetAllPlayerID(Team.GetTeamID_TeamName(TeamComboBox.SelectedItem.ToString()));  // + 1 cause list starts at 0, and team_id starts at 1

                foreach (var PlayerID in PlayersInTeam) //adds the player full name of each entity in the table Team to the combobox, dependent on what Team is selected first.
                {

                    PlayerComboBox.Items.Add(Player.GetFirstName(PlayerID) + " " + Player.GetLastName(PlayerID));
                }
            }
            else //Exception handling
            {
                MessageBox.Show("Unknown ERROR with LeagueComboBox!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // exception handling
            }
        }

        private void PlayerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var SelectedFullName = PlayerComboBox.SelectedItem.ToString().Split(" ");
            string firstName = SelectedFullName[0];
            string lastName = SelectedFullName[1];

            player_id = Player.GetPlayerIDName(firstName, lastName);

           


        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenuForm = new();
            adminMenuForm.Show();
            Hide();
        }

        private void RemovePlayerButton_Click(object sender, EventArgs e)
        {
            //confirmation if the player wants to remove the player from the database
            DialogResult res = MessageBox.Show($"Are you sure you want to remove {Player.GetFirstName(player_id)}  {Player.GetLastName(player_id)}?", "Remove User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                this.Show();
            }
            else
            {
                Player.RemovePlayer(player_id);
                MessageBox.Show($"Player has been removed from the Database", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information); //confirmation that data was added to the database

                RemovingPlayers removingPlayers = new RemovingPlayers();
                this.Hide();
                removingPlayers.Show();
            }
        }
    }
}
