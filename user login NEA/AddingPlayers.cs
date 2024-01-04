using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_login_NEA
{
    public partial class AddingPlayers : Form
    {
        public AddingPlayers()
        {
            InitializeComponent();
        }

        private void AddingPlayers_Load(object sender, EventArgs e)
        {

            foreach (var LeagueName in Database_manager.columnStringFromDB("Leagues", "LeagueName"))

            {
                LeagueComboBox.Items.Add(LeagueName);

            }

        }

        private void LeagueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BowlerComboBox.Items.Clear();

            List<int> legaueTeams = new List<int>();

            if (LeagueComboBox.SelectedIndex.ToString() != null)
            {


                legaueTeams = Database_manager.multipleIntFromDB($"{LeagueComboBox.SelectedIndex.ToString() + 1}", "league_id", "Teams", "team_id"); // + 1 cause list starts at 0, and team_id starts at 1

                foreach (var team in legaueTeams)
                {



                    BowlerComboBox.Items.Add(Database_manager.singleStringFromDB($"{team}", "team_id", "Teams", "TeamName"));
                }
            }
            else
            {
                TeamLabel.Text = "ERROR";
            }
        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(FirstNameTextBox.Text))
            {
                FirstNameTextBox.Text = "ERROR";
                MessageBox.Show("Please enter a FirstName!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FirstNameTextBox.Clear();
                FirstNameTextBox.Focus();
            }
            else if (String.IsNullOrWhiteSpace(LastNameTextBox.Text))
            {
                LastNameTextBox.Text = "ERROR";
                MessageBox.Show("Please enter a LastName!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LastNameTextBox.Clear();
                LastNameTextBox.Focus();
            }
            else
            {
                if (Player.ValidateName(FirstNameTextBox.Text) == "Valid" && Player.ValidateName(LastNameTextBox.Text) == "Valid")
                {
                    FirstNameLabel.Text = "VALID";
                }
                else
                {
                    if (Player.ValidateName(FirstNameTextBox.Text) != "Valid") 
                    {
                        FirstNameTextBox.Text = "ERROR";
                        MessageBox.Show($"{Player.ValidateName(FirstNameTextBox.Text)} - FirstName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        FirstNameTextBox.Clear();
                        FirstNameTextBox.Focus();
                    }
                    else if (Player.ValidateName(LastNameTextBox.Text) != "Valid")
                    {
                        FirstNameTextBox.Text = "ERROR";
                        MessageBox.Show($"{Player.ValidateName(LastNameTextBox.Text)} - LastName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LastNameTextBox.Clear();
                        LastNameTextBox.Focus();
                    }
                }
            }

            

        }
    }
}
