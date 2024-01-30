using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_login_NEA
{
    public partial class WeeklyHighScores : Form
    {
        public WeeklyHighScores()
        {
            InitializeComponent();

        }

        private void WeeklyHighScores_Load(object sender, EventArgs e)
        {
            //Gets all the weeks from the database.
            foreach (var week in Week.TotalWeeks())
            {
                int week_id = Week.GetWeekID(week);
                int NumOfGames = 0;

                foreach (var match_id in Matches.GetMatches(week_id,3))
                {
                    if (Matches.CheckForGame(match_id) == true)
                    {
                        NumOfGames += 4;
                    }
                }
                //Only displays the weeks if there are enough games to display
                //the top 3 scores in each category, preventing errors.
                if (NumOfGames > 5)
                {
                    WeeksComboBox.Items.Add($"{week}");
                }


            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            UserMenu UserMenuForm = new();
            UserMenuForm.Show();
            Hide();
        }

        private void WeeksComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Gets the highscratchscores of the week in a list in order.
            List<Tuple<int, int>> HighestScratchScores = Game.HighestScratch(Convert.ToInt32(WeeksComboBox.SelectedItem));
            //Gets the highhandicapscores of the week in a list in order.
            List<Tuple<int, int>> HighestHandicapScores = Game.HighestHandicap(Convert.ToInt32(WeeksComboBox.SelectedItem));
            //Gets the highscratchseries of the week in a list in order.
            List<Tuple<int, int>> HighestScratchSeries = Game.HighestScratchSeries(Convert.ToInt32(WeeksComboBox.SelectedItem));
            //Gets the highhandicapseries of the week in a list in order.
            List<Tuple<int, int>> HighestHandicapSeries = Game.HighestHandicapSeries(Convert.ToInt32(WeeksComboBox.SelectedItem));


            //Displays the list to the user: 
            /*A player may only show up once in scratch leaderboard and handicap leaderboard. (seperate for game and series)

            They will be displayed on whatever leaderboard they are placed higher in, Priority given in scratch score over handicap score

            Priority order -->
            Scratch score 1st  --> Handicap Score 1st --> Scratch Score 2nd --> Handicap Score 2nd --> Scratch Score 3rd --> Handicap Score 3rd

            Scratch series 1st  --> Handicap series 1st --> Scratch series 2nd --> Handicap series 2nd --> Scratch series 3rd --> Handicap series 3rd
            */

            FirstPlayerSS.Text = Player.GetFirstName(HighestScratchScores[0].Item1) + " " + Player.GetLastName(HighestScratchScores[0].Item1);
            FirstScratchScore.Text = Convert.ToString(HighestScratchScores[0].Item2);
            HighestHandicapScores.RemoveAll(t => t.Item1 == HighestScratchScores[0].Item1);

            FirstPlayerHS.Text = Player.GetFirstName(HighestHandicapScores[0].Item1) + " " + Player.GetLastName(HighestHandicapScores[0].Item1);
            FirstHandicapScore.Text = Convert.ToString(HighestHandicapScores[0].Item2);
            HighestScratchScores.RemoveAll(t => t.Item1 == HighestHandicapScores[0].Item1);

            SecondPlayerSS.Text = Player.GetFirstName(HighestScratchScores[1].Item1) + " " + Player.GetLastName(HighestScratchScores[1].Item1);
            SecondScratchScore.Text = Convert.ToString(HighestScratchScores[1].Item2);
            HighestHandicapScores.RemoveAll(t => t.Item1 == HighestScratchScores[1].Item1);

            SecondPlayerHS.Text = Player.GetFirstName(HighestHandicapScores[1].Item1) + " " + Player.GetLastName(HighestHandicapScores[1].Item1);
            SecondHandicapScore.Text = Convert.ToString(HighestHandicapScores[1].Item2);
            HighestScratchScores.RemoveAll(t => t.Item1 == HighestHandicapScores[2].Item1);

            ThirdPlayerSS.Text = Player.GetFirstName(HighestScratchScores[2].Item1) + " " + Player.GetLastName(HighestScratchScores[2].Item1);
            ThirdScratchScore.Text = Convert.ToString(HighestScratchScores[2].Item2);
            HighestHandicapScores.RemoveAll(t => t.Item1 == HighestScratchScores[2].Item1);

            ThirdPlayerHS.Text = Player.GetFirstName(HighestHandicapScores[2].Item1) + " " + Player.GetLastName(HighestHandicapScores[2].Item1);
            ThirdHandicapScore.Text = Convert.ToString(HighestHandicapScores[2].Item2);
            HighestScratchScores.RemoveAll(t => t.Item1 == HighestHandicapScores[2].Item1);



            FirstPlayerSSeries.Text = Player.GetFirstName(HighestScratchSeries[0].Item1) + " " + Player.GetLastName(HighestScratchSeries[0].Item1);
            FirstScratchSeries.Text = Convert.ToString(HighestScratchSeries[0].Item2);
            HighestHandicapSeries.RemoveAll(t => t.Item1 == HighestScratchSeries[0].Item1);

            FirstPlayerHSeries.Text = Player.GetFirstName(HighestHandicapSeries[0].Item1) + " " + Player.GetLastName(HighestHandicapSeries[0].Item1);
            FirstHandicapSeries.Text = Convert.ToString(HighestHandicapSeries[0].Item2);
            HighestScratchSeries.RemoveAll(t => t.Item1 == HighestHandicapSeries[0].Item1);

            SecondPlayerSSeries.Text = Player.GetFirstName(HighestScratchSeries[1].Item1) + " " + Player.GetLastName(HighestScratchSeries[1].Item1);
            SecondScratchSeries.Text = Convert.ToString(HighestScratchSeries[1].Item2);
            HighestHandicapSeries.RemoveAll(t => t.Item1 == HighestScratchSeries[1].Item1);

            SecondPlayerHSeries.Text = Player.GetFirstName(HighestHandicapSeries[1].Item1) + " " + Player.GetLastName(HighestHandicapSeries[1].Item1);
            SecondHandicapSeries.Text = Convert.ToString(HighestHandicapSeries[1].Item2);
            HighestScratchSeries.RemoveAll(t => t.Item1 == HighestHandicapSeries[1].Item1);

            ThirdPlayerSSeries.Text = Player.GetFirstName(HighestScratchSeries[2].Item1) + " " + Player.GetLastName(HighestScratchSeries[2].Item1);
            ThirdScratchSeries.Text = Convert.ToString(HighestScratchSeries[2].Item2);
            HighestHandicapSeries.RemoveAll(t => t.Item1 == HighestScratchSeries[2].Item1);

            ThirdPlayerHSeries.Text = Player.GetFirstName(HighestHandicapSeries[2].Item1) + " " + Player.GetLastName(HighestHandicapSeries[2].Item1);
            ThirdHandicapSeries.Text = Convert.ToString(HighestHandicapSeries[2].Item2);
            HighestScratchSeries.RemoveAll(t => t.Item1 == HighestHandicapSeries[2].Item1);


            //Makes the standings visible when a week is selected.

            HandicapSeriesLabel.Visible = true;
            ScratchSeriesLabel.Visible = true;
            HighestScratchGames.Visible = true;
            HighestHandicapGames.Visible = true;


            FirstPlayerSS.Visible = true;
            SecondPlayerSS.Visible = true;
            ThirdPlayerSS.Visible = true;

            FirstScratchScore.Visible = true;
            SecondScratchScore.Visible = true;
            ThirdScratchScore.Visible = true;

            FirstPlayerHS.Visible = true;
            SecondPlayerHS.Visible = true;
            ThirdPlayerHS.Visible = true;

            FirstHandicapScore.Visible = true;
            SecondHandicapScore.Visible = true;
            ThirdHandicapScore.Visible = true;

            FirstPlayerSSeries.Visible = true;
            SecondPlayerSSeries.Visible = true;
            ThirdPlayerSSeries.Visible = true;

            FirstScratchSeries.Visible = true;
            SecondScratchSeries.Visible = true;
            ThirdScratchSeries.Visible = true;

            FirstPlayerHSeries.Visible = true;
            SecondPlayerHSeries.Visible = true;
            ThirdPlayerHSeries.Visible = true;

            FirstHandicapSeries.Visible = true;
            SecondHandicapSeries.Visible = true;
            ThirdHandicapSeries.Visible = true;



        }


    }

}
