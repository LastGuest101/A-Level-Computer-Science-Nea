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
        public UserMenu()
        {
            InitializeComponent();
        }
        private void UserMenu_Load(object sender, EventArgs e)
        {
            foreach (int team_id in Team.GetTeamID_playerID(MainMenu.loggedPlayerID))
            {
                int listLeagueID = League.GetLeagueID_Team_id(team_id);
                LeagueComboBox.Items.Add(League.GetLeagueName(listLeagueID));
            }

            BowlerLabel.Text = "Bowler: " + Player.GetFirstName(MainMenu.loggedPlayerID) + " " + Player.GetLastName(MainMenu.loggedPlayerID);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            MainMenu MainMenuForm = new();
            MainMenuForm.Show();
            Hide();
        }
        private void WeeklyScoresPlayerButton_Click(object sender, EventArgs e)
        {
            WeeklyHighScores WeeklyScoresForm = new WeeklyHighScores();
            WeeklyScoresForm.Show();
            Hide();
        }
        private void WeeklyScoresTeamButton_Click(object sender, EventArgs e)
        {
            WeeklyHighScoresTeam WeeklyScoresTeamForm = new WeeklyHighScoresTeam();
            WeeklyScoresTeamForm.Show();
            Hide();
        }
        private void StandingsButton_Click(object sender, EventArgs e)
        {
            Standings standingsForm = new Standings();
            standingsForm.Show();
            Hide();
        }

        private void LeagueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LeagueComboBox.SelectedItem != null)
            {
                LeagueID = League.GetLeagueIDLeagueName(LeagueComboBox.SelectedItem.ToString());
                List<Tuple<string, int>> Teamname_Points = Game.Leaderboard(LeagueID);
                List<int> PlayerTeams = Team.GetTeamID_playerID(MainMenu.loggedPlayerID);
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
                        TeamLabel.Text = $"Team: {Team.GetTeamName(team_id)}";
                    }
                    int placeCount = 0;
                    foreach (Tuple<string, int> SelectedTeam in Teamname_Points)
                    {
                        placeCount++;
                        if (Team.GetTeamName(team_id) == SelectedTeam.Item1)
                        {
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
