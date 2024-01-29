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
    public partial class WeeklyHighScoresTeam : Form
    {
        public WeeklyHighScoresTeam()
        {
            InitializeComponent();
        }

        private void WeeklyHighScoresTeam_Load(object sender, EventArgs e)
        {
            //Gets all the weeks from the database.
            foreach (var week in Week.TotalWeeks())
            {
                int week_id = Week.GetWeekID(week);
                int NumOfGamesTeam = 0;

                //Only displays the weeks if there are enough games to display
                //the top 3 scores in each category, preventing errors.
                foreach (var match_id in Matches.GetMatches(week_id))
                {
                    if (Matches.CheckForGame(match_id) == true)
                    {
                        NumOfGamesTeam += 2;
                    }
                }
                if (NumOfGamesTeam > 5)
                {
                    WeeksComboBox.Items.Add($"{week}");
                }


            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            UserMenu UserMenuForm = new UserMenu();
            UserMenuForm.Show();
            Hide();
        }

        private void WeekComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Tuple<int, int>> HighestScratchGame = Game.ScratchGameTeam(Convert.ToInt32(WeeksComboBox.SelectedItem));
            List<Tuple<int, int>> HighestHandicapGame = Game.HandicapGameTeam(Convert.ToInt32(WeeksComboBox.SelectedItem));
            List<Tuple<int, int>> HighestScratchSeries = Game.ScratchSeriesTeam(Convert.ToInt32(WeeksComboBox.SelectedItem));
            List<Tuple<int, int>> HighestHandicapSeries = Game.HandicapSeriesTeam(Convert.ToInt32(WeeksComboBox.SelectedItem));

            //Displays the list to the user: 
            /*A Team may only show up once in scratch leaderboard and handicap leaderboard. (seperate for game and series)

            They will be displayed on whatever leaderboard they are placed higher in, Priority given in scratch score over handicap score

            Priority order -->
            Scratch score 1st  --> Handicap Score 1st --> Scratch Score 2nd --> Handicap Score 2nd --> Scratch Score 3rd --> Handicap Score 3rd

            Scratch series 1st  --> Handicap series 1st --> Scratch series 2nd --> Handicap series 2nd --> Scratch series 3rd --> Handicap series 3rd
            */

            FirstTeamSS.Text = Team.GetTeamName(HighestScratchGame[0].Item1);
            FirstScratchGame.Text = Convert.ToString(HighestScratchGame[0].Item2);
            HighestHandicapGame.RemoveAll(t => t.Item1 == HighestScratchGame[0].Item1);

            FirstTeamHS.Text = Team.GetTeamName(HighestHandicapGame[0].Item1);
            FirstHandicapGame.Text = Convert.ToString(HighestHandicapGame[0].Item2);
            HighestScratchGame.RemoveAll(t => t.Item1 == HighestHandicapGame[0].Item1);

            SecondTeamSS.Text = Team.GetTeamName(HighestScratchGame[1].Item1);
            SecondScratchGame.Text = Convert.ToString(HighestScratchGame[1].Item2);
            HighestHandicapGame.RemoveAll(t => t.Item1 == HighestScratchGame[1].Item1);

            SecondTeamHS.Text = Team.GetTeamName(HighestHandicapGame[1].Item1);
            SecondHandicapGame.Text = Convert.ToString(HighestHandicapGame[1].Item2);
            HighestScratchGame.RemoveAll(t => t.Item1 == HighestHandicapGame[1].Item1);

            ThirdTeamSS.Text = Team.GetTeamName(HighestScratchGame[2].Item1);
            ThirdScratchGame.Text = Convert.ToString(HighestScratchGame[2].Item2);
            HighestHandicapGame.RemoveAll(t => t.Item1 == HighestScratchGame[2].Item1);

            ThirdTeamHS.Text = Team.GetTeamName(HighestHandicapGame[2].Item1);
            ThirdHandicapGame.Text = Convert.ToString(HighestHandicapGame[2].Item2);
            HighestScratchGame.RemoveAll(t => t.Item1 == HighestHandicapGame[2].Item1);



            FirstTeamSSeries.Text = Team.GetTeamName(HighestScratchSeries[0].Item1);
            FirstScratchSeries.Text = Convert.ToString(HighestScratchSeries[0].Item2);
            HighestHandicapSeries.RemoveAll(t => t.Item1 == HighestScratchSeries[0].Item1);

            FirstTeamHSeries.Text = Team.GetTeamName(HighestHandicapSeries[0].Item1);
            FirstHandicapSeries.Text = Convert.ToString(HighestHandicapSeries[0].Item2);
            HighestScratchSeries.RemoveAll(t => t.Item1 == HighestHandicapSeries[0].Item1);

            SecondTeamSSeries.Text = Team.GetTeamName(HighestScratchSeries[1].Item1);
            SecondScratchSeries.Text = Convert.ToString(HighestScratchSeries[1].Item2);
            HighestHandicapSeries.RemoveAll(t => t.Item1 == HighestScratchSeries[1].Item1);

            SecondTeamHSeries.Text = Team.GetTeamName(HighestHandicapSeries[1].Item1);
            SecondHandicapSeries.Text = Convert.ToString(HighestHandicapSeries[1].Item2);
            HighestScratchSeries.RemoveAll(t => t.Item1 == HighestHandicapSeries[1].Item1);

            ThirdTeamSSeries.Text = Team.GetTeamName(HighestScratchSeries[2].Item1);
            ThirdScratchSeries.Text = Convert.ToString(HighestScratchSeries[2].Item2);
            HighestHandicapSeries.RemoveAll(t => t.Item1 == HighestScratchSeries[2].Item1);

            ThirdTeamHSeries.Text = Team.GetTeamName(HighestHandicapSeries[2].Item1);
            ThirdHandicapSeries.Text = Convert.ToString(HighestHandicapSeries[2].Item2);
            HighestScratchSeries.RemoveAll(t => t.Item1 == HighestHandicapSeries[2].Item1);

            //Makes the standings visible when a week is selected.
            ScratchScoreLabel.Visible = true;
            HandicapScoreLabel.Visible = true;
            ScratchSeriesLabel.Visible = true;
            HandicapSeriesLabel.Visible = true;

            FirstTeamSS.Visible = true;
            SecondTeamSS.Visible = true;
            ThirdTeamSS.Visible = true;

            FirstScratchGame.Visible = true;
            SecondScratchGame.Visible = true;
            ThirdScratchGame.Visible = true;

            FirstTeamHS.Visible = true;
            SecondTeamHS.Visible = true;
            ThirdTeamHS.Visible = true;

            FirstHandicapGame.Visible = true;
            SecondHandicapGame.Visible = true;
            ThirdHandicapGame.Visible = true;

            FirstTeamSSeries.Visible = true;
            SecondTeamSSeries.Visible = true;
            ThirdTeamSSeries.Visible = true;

            FirstScratchSeries.Visible = true;
            SecondScratchSeries.Visible = true;
            ThirdScratchSeries.Visible = true;

            FirstTeamHSeries.Visible = true;
            SecondTeamHSeries.Visible = true;
            ThirdTeamHSeries.Visible = true;

            FirstHandicapSeries.Visible = true;
            SecondHandicapSeries.Visible = true;
            ThirdHandicapSeries.Visible = true;




        }

        
    }
}
