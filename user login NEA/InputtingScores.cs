using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
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

            Total1Label.Text = "0";
            Total2Label.Text = "0";
            Total3Label.Text = "0";
            Total4Label.Text = "0";

        }

        private void P1_Game1TextBox_TextChanged(object sender, EventArgs e)
        {
            int Game1;
            int Game2;
            int Game3;
            int TotalHandicap = Convert.ToInt32(HandicapTotal1Label.Text);

            if (Game.ValidateGameNumber(P1_Game1TextBox.Text) != "valid") // Only allows numbers from 0 - 300 to be inputted
            {
                P1_Game1TextBox.Clear();
                Game1 = 0;
            }

            else
            {
                Game1 = Convert.ToInt32(P1_Game1TextBox.Text);
            }
            if (String.IsNullOrWhiteSpace(P1_Game2TextBox.Text)) // Checks if player1 Game2 is empty
            {
                Game2 = 0;
            }
            else
            {
                Game2 = Convert.ToInt32(P1_Game2TextBox.Text);
            }
            if (String.IsNullOrWhiteSpace(P1_Game3TextBox.Text))  // Checks if player1 Game3 is empty
            {
                Game3 = 0;
            }
            else
            {
                Game3 = Convert.ToInt32(P1_Game3TextBox.Text);
            }
            ScratchScore1Label.Text = Convert.ToString(maths.Series(Game1, Game2, Game3)); // Displays the scratch score of player1
            Total1Label.Text = Convert.ToString(maths.Series(Game1, Game2, Game3) + TotalHandicap); // Displays total score including handicap player1
        }

        private void P1_Game2TextBox_TextChanged(object sender, EventArgs e)
        {
            {
                int Game2;
                int Game1;
                int Game3;
                int TotalHandicap = Convert.ToInt32(HandicapTotal1Label.Text);

                if (Game.ValidateGameNumber(P1_Game2TextBox.Text) != "valid")
                {
                    P1_Game2TextBox.Clear();
                    Game2 = 0;
                }

                else
                {
                    Game2 = Convert.ToInt32(P1_Game2TextBox.Text);
                }
                if (String.IsNullOrWhiteSpace(P1_Game1TextBox.Text))
                {
                    Game1 = 0;
                }
                else
                {
                    Game1 = Convert.ToInt32(P1_Game1TextBox.Text);
                }
                if (String.IsNullOrWhiteSpace(P1_Game3TextBox.Text))
                {
                    Game3 = 0;
                }
                else
                {
                    Game3 = Convert.ToInt32(P1_Game3TextBox.Text);
                }
                ScratchScore1Label.Text = Convert.ToString(maths.Series(Game2, Game1, Game3));
                Total1Label.Text = Convert.ToString(maths.Series(Game2, Game1, Game3) + TotalHandicap);
            }

        }

        private void P1_Game3TextBox_TextChanged(object sender, EventArgs e)
        {
            {
                int Game3;
                int Game2;
                int Game1;
                int TotalHandicap = Convert.ToInt32(HandicapTotal1Label.Text);

                if (Game.ValidateGameNumber(P1_Game3TextBox.Text) != "valid")
                {
                    P1_Game3TextBox.Clear();
                    Game3 = 0;
                }

                else
                {
                    Game3 = Convert.ToInt32(P1_Game3TextBox.Text);
                }
                if (String.IsNullOrWhiteSpace(P1_Game2TextBox.Text))
                {
                    Game2 = 0;
                }
                else
                {
                    Game2 = Convert.ToInt32(P1_Game2TextBox.Text);
                }
                if (String.IsNullOrWhiteSpace(P1_Game1TextBox.Text))
                {
                    Game1 = 0;
                }
                else
                {
                    Game1 = Convert.ToInt32(P1_Game1TextBox.Text);
                }
                ScratchScore1Label.Text = Convert.ToString(maths.Series(Game3, Game2, Game1));
                Total1Label.Text = Convert.ToString(maths.Series(Game3, Game2, Game1) + TotalHandicap);
            }
        }

        private void P2_Game1TextBox_TextChanged(object sender, EventArgs e)
        {
            int Game1;
            int Game2;
            int Game3;
            int TotalHandicap = Convert.ToInt32(HandicapTotal2Label.Text);

            if (Game.ValidateGameNumber(P2_Game1TextBox.Text) != "valid") // Only allows numbers from 0 - 300 to be inputted
            {
                P2_Game1TextBox.Clear();
                Game1 = 0;
            }

            else
            {
                Game1 = Convert.ToInt32(P2_Game1TextBox.Text);
            }
            if (String.IsNullOrWhiteSpace(P2_Game2TextBox.Text)) // Checks if player2 Game2 is empty
            {
                Game2 = 0;
            }
            else
            {
                Game2 = Convert.ToInt32(P2_Game2TextBox.Text);
            }
            if (String.IsNullOrWhiteSpace(P2_Game3TextBox.Text))  // Checks if player2 Game3 is empty
            {
                Game3 = 0;
            }
            else
            {
                Game3 = Convert.ToInt32(P2_Game3TextBox.Text);
            }
            ScratchScore2Label.Text = Convert.ToString(maths.Series(Game1, Game2, Game3)); // Displays the scratch score of player2
            Total2Label.Text = Convert.ToString(maths.Series(Game1, Game2, Game3) + TotalHandicap); // Displays total score including handicap player2

        }

        private void P2_Game2TextBox_TextChanged(object sender, EventArgs e)
        {
            int Game2;
            int Game1;
            int Game3;
            int TotalHandicap = Convert.ToInt32(HandicapTotal2Label.Text);

            if (Game.ValidateGameNumber(P2_Game2TextBox.Text) != "valid")
            {
                P2_Game2TextBox.Clear();
                Game2 = 0;
            }

            else
            {
                Game2 = Convert.ToInt32(P2_Game2TextBox.Text);
            }
            if (String.IsNullOrWhiteSpace(P2_Game1TextBox.Text))
            {
                Game1 = 0;
            }
            else
            {
                Game1 = Convert.ToInt32(P2_Game1TextBox.Text);
            }
            if (String.IsNullOrWhiteSpace(P2_Game3TextBox.Text))
            {
                Game3 = 0;
            }
            else
            {
                Game3 = Convert.ToInt32(P2_Game3TextBox.Text);
            }
            ScratchScore2Label.Text = Convert.ToString(maths.Series(Game2, Game1, Game3));
            Total2Label.Text = Convert.ToString(maths.Series(Game2, Game1, Game3) + TotalHandicap);

        }

        private void P2_Game3TextBox_TextChanged(object sender, EventArgs e)
        {
            int Game3;
            int Game1;
            int Game2;
            int TotalHandicap = Convert.ToInt32(HandicapTotal2Label.Text);

            if (Game.ValidateGameNumber(P2_Game3TextBox.Text) != "valid")
            {
                P2_Game3TextBox.Clear();
                Game3 = 0;
            }

            else
            {
                Game3 = Convert.ToInt32(P2_Game3TextBox.Text);
            }
            if (String.IsNullOrWhiteSpace(P2_Game2TextBox.Text))
            {
                Game2 = 0;
            }

            else
            {
                Game2 = Convert.ToInt32(P2_Game2TextBox.Text);
            }
            if (String.IsNullOrWhiteSpace(P2_Game1TextBox.Text))
            {
                Game1 = 0;
            }
            else
            {
                Game1 = Convert.ToInt32(P2_Game1TextBox.Text);
            }
            ScratchScore2Label.Text = Convert.ToString(maths.Series(Game3, Game1, Game2));
            Total2Label.Text = Convert.ToString(maths.Series(Game3, Game1, Game2) + TotalHandicap);
        }

        private void P3_Game1TextBox_TextChanged(object sender, EventArgs e)
        {
            int Game1;
            int Game2;
            int Game3;
            int TotalHandicap = Convert.ToInt32(HandicapTotal3Label.Text);

            if (Game.ValidateGameNumber(P3_Game1TextBox.Text) != "valid")
            {
                P3_Game1TextBox.Clear();
                Game1 = 0;
            }

            else
            {
                Game1 = Convert.ToInt32(P3_Game1TextBox.Text);
            }
            if (String.IsNullOrWhiteSpace(P3_Game2TextBox.Text))
            {
                Game2 = 0;
            }
            else
            {
                Game2 = Convert.ToInt32(P3_Game2TextBox.Text);
            }
            if (String.IsNullOrWhiteSpace(P3_Game3TextBox.Text))
            {
                Game3 = 0;
            }
            else
            {
                Game3 = Convert.ToInt32(P3_Game3TextBox.Text);
            }
            ScratchScore3Label.Text = Convert.ToString(maths.Series(Game1, Game2, Game3));
            Total3Label.Text = Convert.ToString(maths.Series(Game1, Game2, Game3) + TotalHandicap);
        }

        private void P3_Game2TextBox_TextChanged(object sender, EventArgs e)
        {
            int Game1;
            int Game2;
            int Game3;
            int TotalHandicap = Convert.ToInt32(HandicapTotal3Label.Text);

            if (Game.ValidateGameNumber(P3_Game2TextBox.Text) != "valid")
            {
                P3_Game2TextBox.Clear();
                Game2 = 0;
            }

            else
            {
                Game2 = Convert.ToInt32(P3_Game2TextBox.Text);
            }
            if (String.IsNullOrWhiteSpace(P3_Game1TextBox.Text))
            {
                Game1 = 0;
            }
            else
            {
                Game1 = Convert.ToInt32(P3_Game1TextBox.Text);
            }
            if (String.IsNullOrWhiteSpace(P3_Game3TextBox.Text))
            {
                Game3 = 0;
            }
            else
            {
                Game3 = Convert.ToInt32(P3_Game3TextBox.Text);
            }
            ScratchScore3Label.Text = Convert.ToString(maths.Series(Game1, Game2, Game3));
            Total3Label.Text = Convert.ToString(maths.Series(Game1, Game2, Game3) + TotalHandicap);
        }

        private void P3_Game3TextBox_TextChanged(object sender, EventArgs e)
        {
            int Game1;
            int Game2;
            int Game3;
            int TotalHandicap = Convert.ToInt32(HandicapTotal3Label.Text);

            if (Game.ValidateGameNumber(P3_Game3TextBox.Text) != "valid")
            {
                P3_Game3TextBox.Clear();
                Game3 = 0;
            }

            else
            {
                Game3 = Convert.ToInt32(P3_Game3TextBox.Text);
            }
            if (String.IsNullOrWhiteSpace(P3_Game2TextBox.Text))
            {
                Game2 = 0;
            }
            else
            {
                Game2 = Convert.ToInt32(P3_Game2TextBox.Text);
            }
            if (String.IsNullOrWhiteSpace(P3_Game1TextBox.Text))
            {
                Game1 = 0;
            }
            else
            {
                Game1 = Convert.ToInt32(P3_Game1TextBox.Text);
            }
            ScratchScore3Label.Text = Convert.ToString(maths.Series(Game1, Game2, Game3));
            Total3Label.Text = Convert.ToString(maths.Series(Game1, Game2, Game3) + TotalHandicap);
        }

        private void P4_Game1TextBox_TextChanged(object sender, EventArgs e)
        {
            int Game1;
            int Game2;
            int Game3;
            int TotalHandicap = Convert.ToInt32(HandicapTotal4Label.Text);

            if (Game.ValidateGameNumber(P4_Game1TextBox.Text) != "valid")
            {
                P4_Game1TextBox.Clear();
                Game1 = 0;
            }

            else
            {
                Game1 = Convert.ToInt32(P4_Game1TextBox.Text);
            }
            if (String.IsNullOrWhiteSpace(P4_Game2TextBox.Text))
            {
                Game2 = 0;
            }
            else
            {
                Game2 = Convert.ToInt32(P4_Game2TextBox.Text);
            }
            if (String.IsNullOrWhiteSpace(P4_Game3TextBox.Text))
            {
                Game3 = 0;
            }
            else
            {
                Game3 = Convert.ToInt32(P4_Game3TextBox.Text);
            }
            ScratchScore4Label.Text = Convert.ToString(maths.Series(Game1, Game2, Game3));
            Total4Label.Text = Convert.ToString(maths.Series(Game1, Game2, Game3) + TotalHandicap);
        }

        private void P4_Game2TextBox_TextChanged(object sender, EventArgs e)
        {
            int Game1;
            int Game2;
            int Game3;
            int TotalHandicap = Convert.ToInt32(HandicapTotal4Label.Text);

            if (Game.ValidateGameNumber(P4_Game2TextBox.Text) != "valid")
            {
                P4_Game2TextBox.Clear();
                Game2 = 0;
            }

            else
            {
                Game2 = Convert.ToInt32(P4_Game2TextBox.Text);
            }
            if (String.IsNullOrWhiteSpace(P4_Game1TextBox.Text))
            {
                Game1 = 0;
            }
            else
            {
                Game1 = Convert.ToInt32(P4_Game1TextBox.Text);
            }
            if (String.IsNullOrWhiteSpace(P4_Game3TextBox.Text))
            {
                Game3 = 0;
            }
            else
            {
                Game3 = Convert.ToInt32(P4_Game3TextBox.Text);
            }
            ScratchScore4Label.Text = Convert.ToString(maths.Series(Game1, Game2, Game3));
            Total4Label.Text = Convert.ToString(maths.Series(Game1, Game2, Game3) + TotalHandicap);

        }

        private void P4_Game3TextBox_TextChanged(object sender, EventArgs e)
        {
            int Game1;
            int Game2;
            int Game3;
            int TotalHandicap = Convert.ToInt32(HandicapTotal4Label.Text);

            if (Game.ValidateGameNumber(P4_Game3TextBox.Text) != "valid")
            {
                P4_Game3TextBox.Clear();
                Game3 = 0;
            }

            else
            {
                Game3 = Convert.ToInt32(P4_Game3TextBox.Text);
            }
            if (String.IsNullOrWhiteSpace(P4_Game2TextBox.Text))
            {
                Game2 = 0;
            }
            else
            {
                Game2 = Convert.ToInt32(P4_Game2TextBox.Text);
            }
            if (String.IsNullOrWhiteSpace(P4_Game1TextBox.Text))
            {
                Game1 = 0;
            }
            else
            {
                Game1 = Convert.ToInt32(P4_Game1TextBox.Text);
            }
            ScratchScore4Label.Text = Convert.ToString(maths.Series(Game1, Game2, Game3));
            Total4Label.Text = Convert.ToString(maths.Series(Game1, Game2, Game3) + TotalHandicap);
        }


    }
}



    
