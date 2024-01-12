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
    public partial class WeeklyHighScores : Form
    {
        public WeeklyHighScores()
        {
            InitializeComponent();

        }

        private void WeeklyHighScores_Load(object sender, EventArgs e)
        {
            foreach (var week in Database_manager.columnIntFromDB("Weeks", "week"))

            {
                WeeksComboBox.Items.Add($"{week}");

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
           
            List<Tuple<int, int>> HighestScratchScores = Game.HighestScratch(Convert.ToInt32(WeeksComboBox.SelectedItem));
            List<Tuple<int, int>> HighestHandicapScores = Game.HighestHandicap(Convert.ToInt32(WeeksComboBox.SelectedItem));

            FirstPlayerSS.Text = Player.GetFirstName(HighestScratchScores[0].Item1) + " " + Player.GetLastName(HighestScratchScores[0].Item1);
            FirstScratchScore.Text = Convert.ToString(HighestScratchScores[0].Item2);
            HighestHandicapScores.RemoveAll(t => t.Item1 == HighestScratchScores[0].Item1);

            SecondPlayerSS.Text = Player.GetFirstName(HighestScratchScores[1].Item1) + " " + Player.GetLastName(HighestScratchScores[1].Item1);
            SecondScratchScore.Text = Convert.ToString(HighestScratchScores[1].Item2);
            HighestHandicapScores.RemoveAll(t => t.Item1 == HighestScratchScores[1].Item1);

            ThirdPlayerSS.Text = Player.GetFirstName(HighestScratchScores[2].Item1) + " " + Player.GetLastName(HighestScratchScores[2].Item1);
            ThirdScratchScore.Text = Convert.ToString(HighestScratchScores[2].Item2);
            HighestHandicapScores.RemoveAll(t => t.Item1 == HighestScratchScores[2].Item1);

            FirstPlayerHS.Text = Player.GetFirstName(HighestHandicapScores[0].Item1) + " " + Player.GetLastName(HighestHandicapScores[0].Item1);
            FirstHandicapScore.Text = Convert.ToString(HighestHandicapScores[0].Item2);
            HighestScratchScores.RemoveAll(t => t.Item1 == HighestHandicapScores[0].Item1);

            SecondPlayerHS.Text = Player.GetFirstName(HighestHandicapScores[1].Item1) + " " + Player.GetLastName(HighestHandicapScores[1].Item1);
            SecondHandicapScore.Text = Convert.ToString(HighestHandicapScores[1].Item2);
            HighestScratchScores.RemoveAll(t => t.Item1 == HighestHandicapScores[2].Item1);

            ThirdPlayerHS.Text = Player.GetFirstName(HighestHandicapScores[2].Item1) + " " + Player.GetLastName(HighestHandicapScores[2].Item1);
            ThirdHandicapScore.Text = Convert.ToString(HighestHandicapScores[2].Item2);
            HighestScratchScores.RemoveAll(t => t.Item1 == HighestHandicapScores[2].Item1);





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

        }
    }

}
