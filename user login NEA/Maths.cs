using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_login_NEA
{
  


        class maths
    {
        public static int Series(int game1, int game2, int game3)
        {
            return game1 + game2 + game3;
        }

        public static int Handicap(int average)
        {
            int Basis_Score = 220;
            float Percentage_Factor = 0.8f;  // Note: Use 'f' suffix for float literals

            float newHandicap_D = (Basis_Score - average) * Percentage_Factor;
            int newHandicap_Whole = (int)newHandicap_D;  // Truncates the handicap calculated
            return newHandicap_Whole;
        }

        public static int Average(int totalPinFall, int NumberOfGames)
        {
            int Average = totalPinFall / NumberOfGames;
            return Average;

        }



    }

}

