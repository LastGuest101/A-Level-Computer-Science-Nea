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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            int league_id = League.GetLeagueIDMatch_id(SelectingPlayers.match_id);


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

            int player1_id = Player.GetPlayerIDName(firstName1,lastName1);
            int player2_id = Player.GetPlayerIDName(firstName2, lastName2);
            int player3_id = Player.GetPlayerIDName(firstName3, lastName3);
            int player4_id = Player.GetPlayerIDName(firstName4, lastName4);

            int handicap1_id = LeagueStats.GetHandicapID(league_id, player1_id);
            int handicap2_id = LeagueStats.GetHandicapID(league_id, player2_id);
            int handicap3_id = LeagueStats.GetHandicapID(league_id, player3_id);
            int handicap4_id = LeagueStats.GetHandicapID(league_id, player4_id);

            Handicap1Label.Text = Convert.ToString(LeagueStats.GetHandicap(handicap1_id));
            Handicap2Label.Text = Convert.ToString(LeagueStats.GetHandicap(handicap2_id));
            Handicap3Label.Text = Convert.ToString(LeagueStats.GetHandicap(handicap3_id));
            Handicap4Label.Text = Convert.ToString(LeagueStats.GetHandicap(handicap4_id));

            HandicapTotal1Label.Text = Convert.ToString(LeagueStats.GetHandicap(handicap1_id) * 3);
            HandicapTotal2Label.Text = Convert.ToString(LeagueStats.GetHandicap(handicap2_id) * 3);
            HandicapTotal3Label.Text = Convert.ToString(LeagueStats.GetHandicap(handicap3_id) * 3);
            HandicapTotal4Label.Text = Convert.ToString(LeagueStats.GetHandicap(handicap4_id) * 3);

            if (LeagueStats.GetTotalPinFall(handicap1_id) != 0 && LeagueStats.GetNumberOfGames(handicap1_id) != 0)
            {
                Average1Label.Text = Convert.ToString(maths.Average(LeagueStats.GetTotalPinFall(handicap1_id), LeagueStats.GetNumberOfGames(handicap1_id)));
            }
            else
            {
                Average1Label.Text = "0";
            }
            if (LeagueStats.GetTotalPinFall(handicap2_id) != 0 && LeagueStats.GetNumberOfGames(handicap2_id) != 0)
            {
                Average2Label.Text = Convert.ToString(maths.Average(LeagueStats.GetTotalPinFall(handicap2_id), LeagueStats.GetNumberOfGames(handicap2_id)));
            }
            else
            {
                Average2Label.Text = "0";
            }
            if (LeagueStats.GetTotalPinFall(handicap3_id) != 0 && LeagueStats.GetNumberOfGames(handicap3_id) != 0)
            {
                Average3Label.Text = Convert.ToString(maths.Average(LeagueStats.GetTotalPinFall(handicap3_id), LeagueStats.GetNumberOfGames(handicap3_id)));
            }
            else
            {
                Average3Label.Text = "0";
            }
            if (LeagueStats.GetTotalPinFall(handicap4_id) != 0 && LeagueStats.GetNumberOfGames(handicap4_id) != 0)
            {
                Average4Label.Text = Convert.ToString(maths.Average(LeagueStats.GetTotalPinFall(handicap4_id), LeagueStats.GetNumberOfGames(handicap4_id)));
            }
            else
            {
                Average4Label.Text = "0";
            }

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

        private void AddButton_Click(object sender, EventArgs e)
        {
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

            int player1_id = Player.GetPlayerIDName(firstName1, lastName1);
            int player2_id = Player.GetPlayerIDName(firstName2, lastName2);
            int player3_id = Player.GetPlayerIDName(firstName3, lastName3);
            int player4_id = Player.GetPlayerIDName(firstName4, lastName4);



            if (AreTextBoxesFilled() == false)
            {
                MessageBox.Show("Please fill in all of the textboxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (AreTextBoxesFilled() == true)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to add these scores?", "ADD SCORES", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                {
                    this.Show();
                }
                else
                {
                    Game.InputGame($"{SelectingPlayers.match_id}", $"{player1_id}", $"{P1_Game1TextBox.Text}", $"{P1_Game2TextBox.Text}", $"{P1_Game3TextBox.Text}");
                    Game.InputGame($"{SelectingPlayers.match_id}", $"{player2_id}", $"{P2_Game1TextBox.Text}", $"{P2_Game2TextBox.Text}", $"{P2_Game3TextBox.Text}");
                    Game.InputGame($"{SelectingPlayers.match_id}", $"{player3_id}", $"{P3_Game1TextBox.Text}", $"{P3_Game2TextBox.Text}", $"{P3_Game3TextBox.Text}");
                    Game.InputGame($"{SelectingPlayers.match_id}", $"{player4_id}", $"{P4_Game1TextBox.Text}", $"{P4_Game2TextBox.Text}", $"{P4_Game3TextBox.Text}");

                    LeagueStats.UpdateLeagueStats(Convert.ToInt32(SelectingPlayers.match_id), Convert.ToInt32(player1_id));
                    LeagueStats.UpdateLeagueStats(Convert.ToInt32(SelectingPlayers.match_id), Convert.ToInt32(player2_id));
                    LeagueStats.UpdateLeagueStats(Convert.ToInt32(SelectingPlayers.match_id), Convert.ToInt32(player3_id));
                    LeagueStats.UpdateLeagueStats(Convert.ToInt32(SelectingPlayers.match_id), Convert.ToInt32(player4_id));

                    Team.SetPoints(SelectingPlayers.match_id, player1_id, player2_id, player3_id, player4_id);

                    LeagueStats.SetHandicap(Convert.ToInt32(SelectingPlayers.match_id), Convert.ToInt32(player1_id));
                    LeagueStats.SetHandicap(Convert.ToInt32(SelectingPlayers.match_id), Convert.ToInt32(player2_id));
                    LeagueStats.SetHandicap(Convert.ToInt32(SelectingPlayers.match_id), Convert.ToInt32(player3_id));
                    LeagueStats.SetHandicap(Convert.ToInt32(SelectingPlayers.match_id), Convert.ToInt32(player4_id));

                    int team1 = Team.GetTeamID_playerID(player1_id);
                    int team2 = Team.GetTeamID_playerID(player3_id);

                    MessageBox.Show($"{Team.GetTeamName(team1)} has gained {Team.GetPoints(team1)} Points and {Team.GetTeamName(team2)} has gained {Team.GetPoints(team2)} ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminMenu adminMenu = new AdminMenu();
                    adminMenu.Show();
                    Hide();

                }
            }
        }
            
        

        private bool AreTextBoxesFilled()
        {
            // Array to store references to your textboxes

            System.Windows.Forms.TextBox[] textBoxes = { P1_Game1TextBox, P1_Game2TextBox, P1_Game3TextBox, P2_Game1TextBox, P2_Game2TextBox, P2_Game3TextBox, P3_Game1TextBox, P3_Game2TextBox, P3_Game3TextBox, P4_Game1TextBox, P4_Game2TextBox, P4_Game3TextBox };


            // Check if any textbox is empty or contains only whitespace
            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return false; // If any textbox is empty or contains only whitespace, return false
                }
            }

            return true; // All textboxes have content
        }
    }
}



    
