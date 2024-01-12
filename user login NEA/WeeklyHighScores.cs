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
            FirstPlayerSS.Text = Player.GetFirstName(HighestScratchScores[0].Item1) + " " + Player.GetLastName(HighestScratchScores[0].Item1);
            SecondPlayerSS.Text = Player.GetFirstName(HighestScratchScores[1].Item1) + " " + Player.GetLastName(HighestScratchScores[1].Item1);
            ThirdPlayerSS.Text = Player.GetFirstName(HighestScratchScores[2].Item1) + " " + Player.GetLastName(HighestScratchScores[2].Item1);

            FirstScratchScore.Text = Convert.ToString(HighestScratchScores[0].Item2);
            SecondScratchScore.Text = Convert.ToString(HighestScratchScores[1].Item2);
            ThirdScratchScore.Text = Convert.ToString(HighestScratchScores[2].Item2);

            FirstPlayerSS.Visible = true;
            SecondPlayerSS.Visible = true;
            ThirdPlayerSS.Visible = true;

            FirstScratchScore.Visible = true;
            SecondScratchScore.Visible = true;
            ThirdScratchScore.Visible = true;

        }
    }

}
