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
    public partial class AddingTeams : Form
    {
        int league_id; 
        //creating variable accessible by all of this form
        public AddingTeams()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            Hide();
        }

        private void AddingTeams_Load(object sender, EventArgs e)
        {
            foreach (var LeagueName in League.GetLeagues()) //adds the league name of each entity in the table Leagues to the combobox
            {
                LeagueComboBox.Items.Add(LeagueName);
            }
        }

        private void LeagueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            league_id = League.GetLeagueIDLeagueName(LeagueComboBox.SelectedItem.ToString());
        }
        private void TeamAddButton_Click(object sender, EventArgs e)
        {
            if (LeagueComboBox.SelectedIndex == -1) // Checks if anything has been selected from the LeagueComboBox    exception handling
            {
                MessageBox.Show("Please select a league!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(TeamTextBox.Text)) // Checks if textbox is empty/contains only whitespace    exception handling 
            {
                TeamTextBox.Text = "ERROR";
                MessageBox.Show("Please enter a FirstName!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TeamTextBox.Clear();
                TeamTextBox.Focus();
            }
            else
            {
                Team.AddTeam($"{TeamTextBox.Text}", league_id);
                MessageBox.Show($"Team has been added to the Database", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information); //confirmation that data was added to the database

                AddingTeams addingTeams = new();
                addingTeams.Show();
                Hide();
            }
        }
    }
}
