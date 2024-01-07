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
    public partial class InputtingScores : Form
    {
        public InputtingScores()
        {
            InitializeComponent();
       
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Team1TableLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InputtingScores_Load(object sender, EventArgs e)
        {
            Player1Label.Text = SelectingPlayers.player1;
            Player2Label.Text = SelectingPlayers.player2;
            Player3Label.Text = SelectingPlayers.player3;
            Player4Label.Text = SelectingPlayers.player4;


            var player1 = SelectingPlayers.player1.Split(" ");
            string firstName1 = player1[0];
            string lastName1 = player1[1];

            var player2 = SelectingPlayers.player2.Split(" ");
            string firstName2 = player2[0];
            string lastName2 = player2[1];

            var player3 = SelectingPlayers.player3.Split(" ");
            string firstName3 = player3[0];
            string lastName3 = player3[1];

            var player4 = SelectingPlayers.player4.Split(" ");
            string firstName4 = player4[0];
            string lastName4 = player4[1];

            string player1_id = Convert.ToString(Database_manager.singleIntFromDBMC($"{firstName1}", $"{lastName1}", "FirstName", "LastName", "Players", "player_id"));
            string player2_id = Convert.ToString(Database_manager.singleIntFromDBMC($"{firstName2}", $"{lastName2}", "FirstName", "LastName", "Players", "player_id"));
            string player3_id = Convert.ToString(Database_manager.singleIntFromDBMC($"{firstName3}", $"{lastName3}", "FirstName", "LastName", "Players", "player_id"));
            string player4_id = Convert.ToString(Database_manager.singleIntFromDBMC($"{firstName4}", $"{lastName4}", "FirstName", "LastName", "Players", "player_id"));

            Handicap1Label.Text = Convert.ToString(Database_manager.singleIntFromDB($"{player1_id}", "player_id", "LeagueStats", "Handicap"));
            Handicap2Label.Text = Convert.ToString(Database_manager.singleIntFromDB($"{player2_id}", "player_id", "LeagueStats", "Handicap"));
            Handicap3Label.Text = Convert.ToString(Database_manager.singleIntFromDB($"{player3_id}", "player_id", "LeagueStats", "Handicap"));
            Handicap4Label.Text = Convert.ToString(Database_manager.singleIntFromDB($"{player4_id}", "player_id", "LeagueStats", "Handicap"));

            HandicapTotal1Label.Text = Convert.ToString(Database_manager.singleIntFromDB($"{player1_id}", "player_id", "LeagueStats", "Handicap") * 3);
            HandicapTotal2Label.Text = Convert.ToString(Database_manager.singleIntFromDB($"{player2_id}", "player_id", "LeagueStats", "Handicap") * 3);
            HandicapTotal3Label.Text = Convert.ToString(Database_manager.singleIntFromDB($"{player3_id}", "player_id", "LeagueStats", "Handicap") * 3);
            HandicapTotal4Label.Text = Convert.ToString(Database_manager.singleIntFromDB($"{player4_id}", "player_id", "LeagueStats", "Handicap") * 3);

            Average1Label.Text = Convert.ToString(maths.Average(Database_manager.singleIntFromDB($"{player1_id}", "player_id", "LeagueStats", "TotalPinFall"), Database_manager.singleIntFromDB($"{player1_id}", "player_id", "LeagueStats", "Games")));
            Average2Label.Text = Convert.ToString(maths.Average(Database_manager.singleIntFromDB($"{player2_id}", "player_id", "LeagueStats", "TotalPinFall"), Database_manager.singleIntFromDB($"{player2_id}", "player_id", "LeagueStats", "Games")));
            Average3Label.Text = Convert.ToString(maths.Average(Database_manager.singleIntFromDB($"{player3_id}", "player_id", "LeagueStats", "TotalPinFall"), Database_manager.singleIntFromDB($"{player3_id}", "player_id", "LeagueStats", "Games")));
            Average4Label.Text = Convert.ToString(maths.Average(Database_manager.singleIntFromDB($"{player4_id}", "player_id", "LeagueStats", "TotalPinFall"), Database_manager.singleIntFromDB($"{player4_id}", "player_id", "LeagueStats", "Games")));

        }

    
           

        private void Handicap1Label_Click(object sender, EventArgs e)
        {

        }
    }
}
