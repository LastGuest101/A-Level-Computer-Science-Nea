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
            Team2.Text = Convert.ToString(Database_manager.multipleIntFromDB("1", "league_id", "Handicaps", "player_id"));
            //SelectPlayersTeam1.Items.Add(Database_manager.intAttributesFromDB("1", "team_id", "Teams/Players", "player_id"));
        }

        private void InputtingScoresForm_Load(object sender, EventArgs e)
        {

        }

        private void SelectPlayersTeam1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
