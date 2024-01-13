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
            foreach (var week in Database_manager.columnIntFromDB("Weeks", "week"))
            {
                int week_id = Week.GetWeekID(week);
                int NumOfGames = 0;

                foreach (var match_id in Database_manager.multipleIntFromDB($"{week_id}", "week_id", "Matches", "match_id"))
                {
                    if (Database_manager.multipleIntFromDB($"{match_id}", "match_id", "Games", "game_id").Count != 0)
                    {
                        NumOfGames += 4;
                    }
                }
                if (NumOfGames > 5)
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
            List<Tuple<int, int>> HighestScratchScores = Game.HighestScoresByTeam(Convert.ToInt32(WeeksComboBox.SelectedItem));

            FirstTeamSS.Text = Team.GetTeamName(HighestScratchScores[0].Item1);
            FirstScratchScore.Text = Convert.ToString(HighestScratchScores[0].Item2);
         

            SecondTeamSS.Text = Team.GetTeamName(HighestScratchScores[1].Item1);
            SecondScratchScore.Text = Convert.ToString(HighestScratchScores[1].Item2);


            ThirdTeamSS.Text = Team.GetTeamName(HighestScratchScores[2].Item1);
            ThirdScratchScore.Text = Convert.ToString(HighestScratchScores[2].Item2);

            ScratchScoreLabel.Visible = true;

            FirstTeamSS.Visible = true;
            SecondTeamSS.Visible = true;
            ThirdTeamSS.Visible = true;

            FirstScratchScore.Visible = true;
            SecondScratchScore.Visible = true;
            ThirdScratchScore.Visible = true;


        }
    }
}
