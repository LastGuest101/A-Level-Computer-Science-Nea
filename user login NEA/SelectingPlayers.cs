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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_login_NEA
{
    public partial class SelectingPlayers : Form
    {
        //used to carry data from one from to another form.

        public static string player1;
        public static string player2;
        public static string player3;
        public static string player4;
        public static int match_id;

        List<int> match_ids = new List<int>();


        public SelectingPlayers()
        {
            InitializeComponent();

            foreach (var week in Week.TotalWeeks())

            {
                WeeksCombobox.Items.Add($"{week}");

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
                match_id = match_ids[MatchComboBox.SelectedIndex];






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

        private void WeeksCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MatchComboBox.Items.Clear();
            match_ids.Clear();
            SelectPlayersTeam1.Items.Clear();
            SelectPlayersTeam2.Items.Clear();
            CompletedComboBox.Items.Clear();

            // Clears the comboboxes and the list when a different week is selected.


            int weekid; // Used to store the weekID selected

            if (WeeksCombobox.SelectedIndex.ToString() != null) //Checks if the Week Combobox is empty or not
            {


                weekid = Week.GetWeekID(WeeksCombobox.SelectedIndex + 1);  // + 1 cause list starts at 0, and team_id starts at 1


                foreach (var match_id in Matches.GetMatches(weekid)) //Gets all the match_ids in the week
                {

                    if (Matches.CheckForGame(match_id) == false) //Checks if the Matches has any Games recorded or not. If not then it will add the match to the MatchCombobox
                    {
                        match_ids.Add(match_id);

                        int team_id1 = Matches.GetTeamID1(match_id); // Get's team_1 id from match_id
                        int team_id2 = Matches.GetTeamID2(match_id); // Get's team_2 id from match_id

                        MatchComboBox.Items.Add(Team.GetTeamName(team_id1) + " VS " + Team.GetTeamName(team_id2));
                    }

                    else if (Matches.CheckForGame(match_id) == true) // If the Match already has Games recorded for it, it will stored the match into completed combobox, so it will not allow more games to be added to the same match.
                    {
                        int team_id1 = Matches.GetTeamID1(match_id); // Get's team_1 id from match_id
                        int team_id2 = Matches.GetTeamID2(match_id); // Get's team_2 id from match_id

                        CompletedComboBox.Items.Add(Team.GetTeamName(team_id1) + " VS " + Team.GetTeamName(team_id2));
                    }

                }

            }


        }

        private void MatchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectPlayersTeam1.Items.Clear();
            SelectPlayersTeam2.Items.Clear();

            int selectedMatch_id = match_ids[MatchComboBox.SelectedIndex];
            int selectedTeam_id1 = Matches.GetTeamID1(selectedMatch_id);
            int selectedTeam_id2 = Matches.GetTeamID2(selectedMatch_id);

            Team1.Text = Team.GetTeamName(selectedTeam_id1);
            Team2.Text = Team.GetTeamName(selectedTeam_id2);

            foreach (var playerid in Team.GetAllPlayerID(selectedTeam_id1)) // Gets the player's first name from the player's ID linked by the Team's ID
            {
                string fullname = Player.GetFirstName(playerid) + " " + Player.GetLastName(playerid);
                SelectPlayersTeam1.Items.Add(fullname);
            }
            foreach (var playerid in Team.GetAllPlayerID(selectedTeam_id2)) // Gets the player's first name from the player's ID linked by the Team's ID
            {
                string fullname = Player.GetFirstName(playerid) + " " + Player.GetLastName(playerid);
                SelectPlayersTeam2.Items.Add(fullname);
            }

        }

        
    }
}
