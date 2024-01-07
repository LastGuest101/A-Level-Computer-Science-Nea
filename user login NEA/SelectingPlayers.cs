using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_login_NEA
{
    public partial class SelectingPlayers : Form
    {
        public static string player1;
        public static string player2;
        public static string player3;
        public static string player4;

       
        public SelectingPlayers()
        {
            InitializeComponent();


            Team1.Text = Database_manager.singleStringFromDB("1", "team_id", "Teams", "TeamName");
            //Team2.Text = string.Join(",", Database_manager.multipleIntFromDB("1", "league_id", "Handicaps", "player_id"));     // works! "Convert.ToString" returns the list object as it would be printed to the console; "string.Join" returns the list items separated by commas
            //Team2.Text = string.Join(",", Database_manager.multipleIntFromDB("1", "league_id", "Teams", "team_id"));         // works!
            Team2.Text = Database_manager.singleStringFromDB("2", "team_id", "Teams", "TeamName"); // works! it was the slash; see comment in Database manger.cs line 159

            //SelectPlayersTeam1.Items.Add(Database_manager.intAttributesFromDB("1", "team_id", "Teams/Players", "player_id"));

            foreach (var playerid in Database_manager.multipleIntFromDB("1", "team_id", "Teams/Players", "player_id")) // Gets the player's first name from the player's ID linked by the Team's ID
            {
                string fullname = Database_manager.singleStringFromDB($"{playerid}", "player_id", "Players", "FirstName") + " " + Database_manager.singleStringFromDB($"{playerid}", "player_id", "Players", "LastName");
                SelectPlayersTeam1.Items.Add(fullname);
            }
            foreach (var playerid in Database_manager.multipleIntFromDB("2", "team_id", "Teams/Players", "player_id")) // Gets the player's first name from the player's ID linked by the Team's ID
            {
                string fullname = Database_manager.singleStringFromDB($"{playerid}", "player_id", "Players", "FirstName") + " " + Database_manager.singleStringFromDB($"{playerid}", "player_id", "Players", "LastName");
                SelectPlayersTeam2.Items.Add(fullname);
            }
        }

        private void SelectPlayers_Click(object sender, EventArgs e)
        {

            if ((SelectPlayersTeam1.SelectedItems.Count == 2) && (SelectPlayersTeam2.SelectedItems.Count == 2))
            {

                

                player1 = Convert.ToString(SelectPlayersTeam1.SelectedItems[0]);
                player2 = Convert.ToString(SelectPlayersTeam1.SelectedItems[1]);
                player3 = Convert.ToString(SelectPlayersTeam2.SelectedItems[0]);
                player4 = Convert.ToString(SelectPlayersTeam2.SelectedItems[1]);



                label1.Text = player1 + player2 + player3 + player4;

                InputtingScores inputtingScores = new();
                inputtingScores.Show();
                Hide();

            }
            else
            {
                MessageBox.Show("Please select two players for each team", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenuForm = new();
            adminMenuForm.Show();
            Hide();
        }
    }
}
