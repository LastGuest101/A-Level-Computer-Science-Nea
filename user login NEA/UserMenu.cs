using Microsoft.SqlServer.Server;
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
    public partial class UserMenu : Form
    {
        public static int LeagueID;
        //Creates variables to be accessed throughout the form
        public UserMenu()
        {
            InitializeComponent();
        }
        private void UserMenu_Load(object sender, EventArgs e)
        {
            //Gets the team_ids linked to the login player
            foreach (int team_id in Team.GetTeamID_playerID(MainMenu.loggedPlayerID))
            {
                //Gets the leagueIDs linked to each teamid
                int listLeagueID = League.GetLeagueID_Team_id(team_id);
                //Adds each LeagueID's leaguename to the list
                LeagueComboBox.Items.Add(League.GetLeagueName(listLeagueID));
            }
            //used to display the linked player's name
            BowlerLabel.Text = "Bowler: " + Player.GetFirstName(MainMenu.loggedPlayerID) + " " + Player.GetLastName(MainMenu.loggedPlayerID);
        }
        //used to go back to the previous form
        private void backButton_Click(object sender, EventArgs e)
        {
            MainMenu MainMenuForm = new();
            MainMenuForm.Show();
            Hide();
        }
        //Used to go the the WeeklyHighScoresForm
        private void WeeklyScoresPlayerButton_Click(object sender, EventArgs e)
        {
            WeeklyHighScores WeeklyScoresForm = new WeeklyHighScores();
            WeeklyScoresForm.Show();
            Hide();
        }
        //Used to go to the WeeklyHighScoresTeamForm
        private void WeeklyScoresTeamButton_Click(object sender, EventArgs e)
        {
            WeeklyHighScoresTeam WeeklyScoresTeamForm = new WeeklyHighScoresTeam();
            WeeklyScoresTeamForm.Show();
            Hide();
        }
        //Used to go to the standings form
        private void StandingsButton_Click(object sender, EventArgs e)
        {
            Standings standingsForm = new Standings();
            standingsForm.Show();
            Hide();
        }
        private void LeagueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {   //Checks if the user has selected a league
            if (LeagueComboBox.SelectedItem != null)
            {
                LeagueID = League.GetLeagueIDLeagueName(LeagueComboBox.SelectedItem.ToString());
                //Used to store the standings of a league
                List<Tuple<string, int>> Standings = Game.Leaderboard(LeagueID);
                //Used to get the player's teams
                List<int> PlayerTeams = Team.GetTeamID_playerID(MainMenu.loggedPlayerID);
                //Used to get the player's leaguestats
                int handicap_id = LeagueStats.GetHandicapID(LeagueID, MainMenu.loggedPlayerID);
                //Checks if the player's totalpinfall and number of games isn't empty to avoid errors.
                if (LeagueStats.GetTotalPinFall(handicap_id) != 0 && LeagueStats.GetNumberOfGames(handicap_id) != 0)
                {
                    //Displays the average pins scored per game by a player from their previous games.
                    AverageLabel.Text = Convert.ToString(maths.Average(LeagueStats.GetTotalPinFall(handicap_id), LeagueStats.GetNumberOfGames(handicap_id)));
                }
                else
                {
                    // if they havent played before their average displayed would be 0.
                    AverageLabel.Text = "0";
                }
                foreach (int team_id in PlayerTeams)
                {
                    if (League.GetLeagueID_Team_id(team_id) == LeagueID)
                    {
                        //Displays the player's teamname in the selected league
                        TeamLabel.Text = $"Team: {Team.GetTeamName(team_id)}";
                    }
                    int placeCount = 0;
                    foreach (Tuple<string, int> SelectedTeam in Standings)
                    {
                        placeCount++;
                        if (Team.GetTeamName(team_id) == SelectedTeam.Item1)
                        {//used to display the player's team position in the league.
                            PlaceLabel.Text = $"Place: {placeCount}";
                        }
                    }
                }

                StandingsButton.Visible = true;
                WeeklyScoresPlayerButton.Visible = true;
                WeeklyScoresTeamButton.Visible = true;
                BowlerLabel.Visible = true;
                TeamLabel.Visible = true;
                PlaceLabel.Visible = true;
                AverageLabel.Visible = true;
            }
        }
    }
}
