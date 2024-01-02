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
    public partial class InputtingScoresForm : Form
    {
        public InputtingScoresForm()
        {
            InitializeComponent();

            Team1.Text = Database_manager.singleStringFromDB("1", "team_id", "Teams", "TeamName");
            //Team2.Text = string.Join(",", Database_manager.multipleIntFromDB("1", "league_id", "Handicaps", "player_id"));     // works! "Convert.ToString" returns the list object as it would be printed to the console; "string.Join" returns the list items separated by commas
            //Team2.Text = string.Join(",", Database_manager.multipleIntFromDB("1", "league_id", "Teams", "team_id"));         // works!
            Team2.Text = Database_manager.singleStringFromDB("2", "team_id", "Teams", "TeamName"); // works! it was the slash; see comment in Database manger.cs line 159

            //SelectPlayersTeam1.Items.Add(Database_manager.intAttributesFromDB("1", "team_id", "Teams/Players", "player_id"));

            foreach (var playerid in Database_manager.multipleIntFromDB("1", "team_id", "Teams/Players", "player_id")) // Gets the player's first name from the player's ID linked by the Team's ID
            {
                string fullname = Database_manager.singleStringFromDB($"{playerid}", "player_id", "Players", "FirstName") + " " +  Database_manager.singleStringFromDB($"{playerid}", "player_id", "Players", "LastName");
                SelectPlayersTeam1.Items.Add(fullname);
            }
            foreach (var playerid in Database_manager.multipleIntFromDB("2", "team_id", "Teams/Players", "player_id")) // Gets the player's first name from the player's ID linked by the Team's ID
            {
                string fullname = Database_manager.singleStringFromDB($"{playerid}", "player_id", "Players", "FirstName") + " " + Database_manager.singleStringFromDB($"{playerid}", "player_id", "Players", "LastName");
                SelectPlayersTeam2.Items.Add(fullname);
            }



        }

        private void InputtingScoresForm_Load(object sender, EventArgs e)
        {

        }

        private void SelectPlayersTeam1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}
