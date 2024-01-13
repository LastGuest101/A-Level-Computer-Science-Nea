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
        public UserMenu()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainMenu MainMenuForm = new();
            MainMenuForm.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
