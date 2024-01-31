using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_login_NEA
{



    class maths
    {
        //used to get the series score from 3 games.
        public static int Series(int game1, int game2, int game3)
        {
            return game1 + game2 + game3;
        }
        //used to calculate a player's new handicap
        public static int Handicap(int average)
        {
            int Basis_Score = 220;
            float Percentage_Factor = 0.8f;
            //handicap is in decimial which isn't allowed.
            float newHandicap_D = (Basis_Score - average) * Percentage_Factor;
            int newHandicap_Whole = (int)newHandicap_D;
            if (newHandicap_Whole < 0)
            {
                return 0;
            }
            else
            {
                return newHandicap_Whole;
            }
        }
        //used to calculate average from totalpinfall and number of games.
        public static int Average(int totalPinFall, int NumberOfGames)
        {
            int Average = totalPinFall / NumberOfGames;
            return Average;

        }
    }
}

