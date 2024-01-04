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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = new();
            mainMenuForm.Show();
            Hide();
        }

        private void EditScoresButton_Click(object sender, EventArgs e)
        {
            SelectingPlayers InputScoreForm = new();
            InputScoreForm.Show();
            Hide();
        }

        private void AddPlayersButton_Click(object sender, EventArgs e)
        {
            AddingPlayers addingPlayers = new();
            addingPlayers.Show();
            Hide();
        }
    }
}
