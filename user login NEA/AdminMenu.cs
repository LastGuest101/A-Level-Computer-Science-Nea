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
        
        /*
        Creates the Main Menu From when the back button is clicked, 
        hiding the current form, and showing the main menu form
        */
        private void BackButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = new();
            mainMenuForm.Show();
            Hide();
        }
        //Creates a Selecting Players form, when the "Edit Scores"
        //button is clicked.
        private void EditScoresButton_Click(object sender, EventArgs e)
        {
            SelectingPlayers InputScoreForm = new();
            InputScoreForm.Show();
            Hide();
        }

        //Cretes a Adding Players for, when the Add Players button is clicked.

        private void AddPlayersButton_Click(object sender, EventArgs e)
        {
            AddingPlayers addingPlayers = new();
            addingPlayers.Show();
            Hide();
        }
    }
}
