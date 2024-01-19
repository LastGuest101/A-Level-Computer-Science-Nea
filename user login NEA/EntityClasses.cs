using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.DirectoryServices.ActiveDirectory;

namespace user_login_NEA
{
    public class User
    {
        public int user_id { get; set; }

        public int player_id { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public string email { get; set; }

        public int admin { get; set; }

        public static string UsernameValidator(string username)
        {
          
            if (OtherUsers(username) == true) 
            {

                return "Username Taken";
            }
            else
            {
                if (username.Length < 1 || username.Length > 30)
                {
                    return "Username has to be 1 - 30 characters long";
                }
                else
                {
                    if (Regex.IsMatch(username, "[^A-Za-z0-9_]") == true)
                    {
                        return "Username can only include alphanumeric characters and '_'";
                    }
                    else
                    {
                        return "valid";
                    }
                    
                }

               
            }
             

        }

        public static string PasswordValidator(string password)
        {
            if (Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*(\d|[^a-zA-Z])).{8,30}$"))
            {
                return "valid";
            }
            else if (password.Length < 8 || password.Length > 30)
            {
                return "Password must between 8 - 30 characters long.";
            }
            else if (!Regex.IsMatch(password, @"^(?=.*[a-z])"))
            {
                return "Password must contain at least one lowercase letter.";
            }
            else if (!Regex.IsMatch(password, @"^(?=.*[A-Z])"))
            {
                return "Password must contain at least one uppercase letter.";
            }
            else if (!Regex.IsMatch(password, @"^(?=.*(\d|[^a-zA-Z]))"))
            {
                return "Password must contain at least one digit or special character.";
            }
            
            
            {
                return "Password does not meet the required criteria.";
            }

        }

        public static bool LoginValidator(string username, string password)
        {
           if(Database_manager.AuthenticateUserLoginIn(username, password) == true)
            {
                return true;
            }
            return false;
            
        }

         public static bool OtherUsers(string username)
         {
              if (Database_manager.singleStringFromDB($"{username}", "Username", "Users", "Username") != null)
            { 
                return true;
            }
                return false;
         }

         public static string getUsername(int user_id)
         {
           return Database_manager.singleStringFromDB($"{user_id}", "user_id", "Users", "Username");
         }
         public static int getUserID(string Username)
         {
              return Database_manager.singleIntFromDB($"{Username}", "Username", "Users", "user_id");
         }

        public static int GetAdminLevel(int user_id)
        {
          return Database_manager.singleIntFromDB($"{user_id}", "user_id", "Users", "Admin");
        }
    

        public static void SetUsername(string newUsername, int user_id)
        {
            Database_manager.UpdateUsername(newUsername, user_id);
        }
        
        public static void SetAdminLevel(int AdminLevel,  int user_id)
        {
            Database_manager.UpdateAdmin(AdminLevel, user_id);
        }

    





    }

    public class Player
    {
        public static string ValidateName(string name)
        {
            if (Regex.IsMatch(name, @"^[A-Z][a-z ,.'-]*$"))
            {
                return "Valid";
            }
          
            else
            {
                if (!Regex.IsMatch(name, @"^[A-Z].*$"))
                {
                     return ("Error: First character must be an uppercase letter.");
                }
                else
                {
                    return "Error: Invalid characters or format.";
                }
            }
        }
        public static void AddPlayer(string firstname, string lastname, int team_id, int league_id)
        {
           
            Database_manager.InsertPlayers(firstname, lastname);
            int player_id = Database_manager.singleIntFromDBMC($"{firstname}", $"{lastname}", "FirstName", "LastName", "Players", "player_id");

            Database_manager.InsertHandicap(league_id, player_id);

            Database_manager.InsertPlayerIntoTeam(player_id, team_id);

        }

        public static bool OtherPlayers(string InputtedFirstname, string InputtedLastname)
        {
                

              List<string> FirstNames =  Database_manager.columnStringFromDB("Players", "FirstName");
              List<string> LastNames = Database_manager.columnStringFromDB("Players", "LastName");

           if ( Database_manager.singleIntFromDBMC($"{InputtedFirstname}", $"{InputtedLastname}", "FirstName", "LastName", "Players", "player_id" ) != -1)
            {
                return true;
            } 
                return false;
            

        }
        public static string GetFirstName(int player_id)
        {
            return Database_manager.singleStringFromDB($"{player_id}", "player_id", "Players", "FirstName");
        }
        public static string GetLastName(int player_id)
        {
            return Database_manager.singleStringFromDB($"{player_id}", "player_id", "Players", "LastName");
        }

        public static int GetPlayerID(string LoggedUsername)
        {
            return Database_manager.singleIntFromDB(LoggedUsername, "Username", "Users", "player_id");
        }
    }

    public class Team
    {
        public static int GetTeamID(int player_id)
        {
            return Database_manager.singleIntFromDB($"{player_id}", "player_id", "[Teams/Players]", "team_id");
        }

        public static int GetPoints(int team_id)
        {
            return Database_manager.singleIntFromDB($"{team_id}", "team_id", "Teams", "Points");
        }
        public static string GetTeamName(int team_id)
        {
            return Database_manager.singleStringFromDB($"{team_id}", "team_id", "Teams", "TeamName");
        }

        public static int NumberOfPlayers(string TeamName)
        {
            int team_id = Database_manager.singleIntFromDB($"{TeamName}", "TeamName", "Teams", "team_id");

            return Database_manager.singleIntFromDB($"{team_id}", "team_id", "[Teams/Players]", "COUNT(player_id)"); //Aggregate SQL function


        }
        public static int SetPoints(int match_id, int player_id1, int player_id2, int player_id3, int player_id4) //used to calculate + input points from a match  
        {
            int newTeam1points = 0;
            int newTeam2points = 0;
            int league_id = Database_manager.singleIntFromDB($"{match_id}", "match_id", "Matches", "league_id");

            if (LeagueStats.GetHandicap(LeagueStats.GetHandicapID(league_id, player_id1)) == 0) // Used to set the handicap for players who didn't have a handicap before the game played.
                                                                                                // Whilst Players who already have a handicap dont get their handicap updated until after the match is over.#When Teams are given their points.
            {
                LeagueStats.SetHandicap(match_id, player_id1);
            }
            if (LeagueStats.GetHandicap(LeagueStats.GetHandicapID(league_id, player_id2)) == 0)
            {
                LeagueStats.SetHandicap(match_id, player_id2);
            }
            if (LeagueStats.GetHandicap(LeagueStats.GetHandicapID(league_id, player_id3)) == 0)
            {
                LeagueStats.SetHandicap(match_id, player_id3);
            }
            if (LeagueStats.GetHandicap(LeagueStats.GetHandicapID(league_id, player_id4)) == 0)
            {
                LeagueStats.SetHandicap(match_id, player_id4);
            }


            int TotalHandicapTeam1 = Database_manager.singleIntFromDB($"{player_id1}", "player_id", "LeagueStats", "Handicap") + Database_manager.singleIntFromDB($"{player_id2}", "player_id", "LeagueStats", "Handicap"); // Gets total handicap from player_id1 and player_id2
            int TotalHandicapTeam2 = Database_manager.singleIntFromDB($"{player_id3}", "player_id", "LeagueStats", "Handicap") + Database_manager.singleIntFromDB($"{player_id4}", "player_id", "LeagueStats", "Handicap"); // Gets total handicap from player_id3 and player_id4

            int player1_gameID = Database_manager.singleIntFromDBMC($"{match_id}", $"{player_id1}", "match_id", "player_id", "Games", "game_id");
            int player2_gameID = Database_manager.singleIntFromDBMC($"{match_id}", $"{player_id2}", "match_id", "player_id", "Games", "game_id");
            int player3_gameID = Database_manager.singleIntFromDBMC($"{match_id}", $"{player_id3}", "match_id", "player_id", "Games", "game_id");
            int player4_gameID = Database_manager.singleIntFromDBMC($"{match_id}", $"{player_id4}", "match_id", "player_id", "Games", "game_id");

            int Team1_Game1 = Database_manager.singleIntFromDB($"{player1_gameID}", "game_id", "Games", "game1") + Database_manager.singleIntFromDB($"{player2_gameID}", "game_id", "Games", "game1") + TotalHandicapTeam1;
            int Team1_Game2 = Database_manager.singleIntFromDB($"{player1_gameID}", "game_id", "Games", "game2") + Database_manager.singleIntFromDB($"{player2_gameID}", "game_id", "Games", "game2") + TotalHandicapTeam1;
            int Team1_Game3 = Database_manager.singleIntFromDB($"{player1_gameID}", "game_id", "Games", "game3") + Database_manager.singleIntFromDB($"{player2_gameID}", "game_id", "Games", "game3") + TotalHandicapTeam1;

            int Team2_Game1 = Database_manager.singleIntFromDB($"{player3_gameID}", "game_id", "Games", "game1") + Database_manager.singleIntFromDB($"{player4_gameID}", "game_id", "Games", "game1") + TotalHandicapTeam2;
            int Team2_Game2 = Database_manager.singleIntFromDB($"{player3_gameID}", "game_id", "Games", "game2") + Database_manager.singleIntFromDB($"{player4_gameID}", "game_id", "Games", "game2") + TotalHandicapTeam2;
            int Team2_Game3 = Database_manager.singleIntFromDB($"{player3_gameID}", "game_id", "Games", "game3") + Database_manager.singleIntFromDB($"{player4_gameID}", "game_id", "Games", "game3") + TotalHandicapTeam2;

            if (Team1_Game1 > Team2_Game1)
            {
                newTeam1points += 2;
            }
            else if (Team1_Game1 == Team2_Game1)
            {
                newTeam1points++;
                newTeam2points++;
            }
            else
            {
                newTeam2points += 2;
            }


            if (Team1_Game2 > Team2_Game2)
            {
                newTeam1points += 2;
            }
            else if (Team1_Game2 == Team2_Game2)
            {
                newTeam1points++;
                newTeam2points++;
            }
            else
            {
                newTeam2points += 2;
            }


            if (Team1_Game3 > Team2_Game3)
            {
                newTeam1points += 2;
            }
            else if (Team1_Game3 == Team2_Game3)
            {
                newTeam1points++;
                newTeam2points++;
            }
            else
            {
                newTeam2points += 2;
            }

            if ((maths.Series(Team1_Game1, Team1_Game2, Team1_Game3) + TotalHandicapTeam1) > (maths.Series(Team2_Game1, Team2_Game2, Team2_Game3) + TotalHandicapTeam2))
            {
                newTeam1points += 2;
            }

            else if ((maths.Series(Team1_Game1, Team1_Game2, Team1_Game3) + TotalHandicapTeam1) == (maths.Series(Team2_Game1, Team2_Game2, Team2_Game3) + TotalHandicapTeam2))
            {
                newTeam1points++;
                newTeam2points++;
            }

            else
            {
                newTeam2points += 2;
            }

            int Team1_id = Team.GetTeamID(player_id1);
            int Team2_id = Team.GetTeamID(player_id4);

            int Team1points = Database_manager.singleIntFromDB($"{Team1_id}", "team_id", "Teams", "Points") + newTeam1points;
            int Team2points = Database_manager.singleIntFromDB($"{Team2_id}", "team_id", "Teams", "Points") + newTeam2points;

            Database_manager.UpdatePoints(Team1points, Team1_id);

            Database_manager.UpdatePoints(Team2points, Team2_id);

            return Convert.ToInt32(Team2_Game1);

        }
    }

    public class Game
    {
        public static string ValidateGameNumber(string inputNumber)
        {
            string pattern = @"^(0|[1-9]|[1-9]\d|1\d{2}|2[0-9]{2}|300)$";
            string input = inputNumber;

            Regex regex = new Regex(pattern);

            if (regex.IsMatch(input))
            {
                return "valid";
            }
            else
            {
                return "Input does not match the pattern for numbers from 0 to 300.";
            }
        }
        public static void InputGame(string match_id, string player_id, string game1, string game2, string game3)
        {
            Database_manager.InsertGame(match_id, player_id, game1, game2, game3);
        }

        public static int GetGameID(int match_id, int player_id)
        {
            return Database_manager.singleIntFromDBMC($"{match_id}", $"{player_id}", "match_id", "player_id", "Games", "game_id");
        }

        public static List<Tuple<int, int>> HighestScratch(int week)
        {
            int week_id = Week.GetWeekID(week);
            List<Tuple<int, int>> HighestScratchScores = new List<Tuple<int, int>>();

            foreach (int match_id in Database_manager.multipleIntFromDB($"{week_id}", "week_id", "Matches", "match_id"))
            {
                foreach (int player_id in Database_manager.multipleIntFromDB($"{match_id}", "match_id", "Games", "player_id"))
                {
                    List<int> PlayersGame = Database_manager.AllGames(player_id);
                    PlayersGame.Sort((a, b) => b.CompareTo(a));

                    // Store player_id along with the highest game value as a Tuple
                    HighestScratchScores.Add(new Tuple<int, int>(player_id, PlayersGame[0]));
                }
            }

            // Sort the TotalGames list based on the highest game value
            HighestScratchScores.Sort((a, b) => b.Item2.CompareTo(a.Item2));

            return HighestScratchScores;
        }

        public static List<Tuple<int, int>> HighestHandicap(int week)
        {
            int week_id = Week.GetWeekID(week);
            List<Tuple<int, int>> HighestHandicapScore = new List<Tuple<int, int>>();

            foreach (int match_id in Database_manager.multipleIntFromDB($"{week_id}", "week_id", "Matches", "match_id"))
            {
                foreach (int player_id in Database_manager.multipleIntFromDB($"{match_id}", "match_id", "Games", "player_id"))
                {
                    int league_id = Database_manager.singleIntFromDB($"{match_id}", "match_id", "Matches", "league_id");
                    int handicap_id = LeagueStats.GetHandicapID(league_id, player_id);
                    List<int> PlayersGame = Database_manager.AllGames(player_id);
                    PlayersGame.Sort((a, b) => b.CompareTo(a));

                    // Store player_id along with the highest game value as a Tuple
                    HighestHandicapScore.Add(new Tuple<int, int>(player_id, PlayersGame[0] + LeagueStats.GetHandicap(handicap_id)));
                }
            }

            // Sort the TotalGames list based on the highest game value
            HighestHandicapScore.Sort((a, b) => b.Item2.CompareTo(a.Item2));

            return HighestHandicapScore;
        }
        public static List<Tuple<int, int>> HighestScratchSeries(int week)
        {
            int week_id = Week.GetWeekID(week);
            List<Tuple<int, int>> HighestScratchSeries = new List<Tuple<int, int>>();

            foreach (int match_id in Database_manager.multipleIntFromDB($"{week_id}", "week_id", "Matches", "match_id"))
            {
                foreach (int player_id in Database_manager.multipleIntFromDB($"{match_id}", "match_id", "Games", "player_id"))
                {
                    List<int> PlayersGame = Database_manager.AllGames(player_id);
                    PlayersGame.Sort((a, b) => b.CompareTo(a));

                    // Store player_id along with the highest game value as a Tuple
                    HighestScratchSeries.Add(new Tuple<int, int>(player_id, PlayersGame[0] + PlayersGame[1] + PlayersGame[2]));
                }
            }

            // Sort the TotalGames list based on the highest game value
            HighestScratchSeries.Sort((a, b) => b.Item2.CompareTo(a.Item2));

            return HighestScratchSeries;
        }

        public static List<Tuple<int, int>> HighestHandicapSeries(int week)
        {
            int week_id = Week.GetWeekID(week);
            List<Tuple<int, int>> HighestHandicapSeries = new List<Tuple<int, int>>();

            foreach (int match_id in Database_manager.multipleIntFromDB($"{week_id}", "week_id", "Matches", "match_id"))
            {
                foreach (int player_id in Database_manager.multipleIntFromDB($"{match_id}", "match_id", "Games", "player_id"))
                {
                    int league_id = Database_manager.singleIntFromDB($"{match_id}", "match_id", "Matches", "league_id");
                    int handicap_id = LeagueStats.GetHandicapID(league_id, player_id);

                    List<int> PlayersGame = Database_manager.AllGames(player_id);
                    PlayersGame.Sort((a, b) => b.CompareTo(a));

                    // Store player_id along with the highest game value as a Tuple
                    HighestHandicapSeries.Add(new Tuple<int, int>(player_id, PlayersGame[0] + PlayersGame[1] + PlayersGame[2] + (LeagueStats.GetHandicap(handicap_id) * 3) ));
                }
            }

            // Sort the TotalGames list based on the highest game value
            HighestHandicapSeries.Sort((a, b) => b.Item2.CompareTo(a.Item2));

            return HighestHandicapSeries;
        }

        public static List<Tuple<int, int>> ScratchGameTeam(int week)
        {
            
            int week_id = Week.GetWeekID(week);

            List<Tuple<int, int>> HighestScratchScores = new List<Tuple<int, int>>();

            foreach (int match_id in Database_manager.multipleIntFromDB($"{week_id}", "week_id", "Matches", "match_id"))
            {
                foreach (int team_id1 in Database_manager.multipleIntFromDB($"{match_id}", "match_id", "Matches", "team_id1"))
                {
                    List<int> teamTotal = new List<int> { 0, 0, 0 };

                    foreach (int player_id in Database_manager.multipleIntFromDB($"{team_id1}", "team_id", "Teams/Players", "player_id"))
                    {
                        
                        List<int> PlayersGame = Database_manager.AllGames(player_id);
                        if(PlayersGame.Count != 0)
                        {
                            teamTotal[0] += PlayersGame[0];
                            teamTotal[1] += PlayersGame[1];
                            teamTotal[2] += PlayersGame[2];  
                        }
                        
                    }

                    if(teamTotal[0] != 0)
                    {
                        teamTotal.Sort((a, b) => b.CompareTo(a));

                        // Store player_id along with the highest game value as a Tuple
                        HighestScratchScores.Add(new Tuple<int, int>(team_id1, teamTotal[0]));
                    }
                    
                }
                foreach (int team_id2 in Database_manager.multipleIntFromDB($"{match_id}", "match_id", "Matches", "team_id2"))
                {
                    List<int> teamTotal = new List<int> { 0, 0, 0 };

                    foreach (int player_id in Database_manager.multipleIntFromDB($"{team_id2}", "team_id", "Teams/Players", "player_id"))
                    {

                        List<int> PlayersGame = Database_manager.AllGames(player_id);
                        if (PlayersGame.Count != 0)
                        {
                            teamTotal[0] += PlayersGame[0];
                            teamTotal[1] += PlayersGame[1];
                            teamTotal[2] += PlayersGame[2];
                        }

                    }

                    if (teamTotal[0] != 0)
                    {
                        teamTotal.Sort((a, b) => b.CompareTo(a));

                        // Store player_id along with the highest game value as a Tuple
                        HighestScratchScores.Add(new Tuple<int, int>(team_id2, teamTotal[0]));
                    }

                }
            }

            HighestScratchScores.Sort((a, b) => b.Item2.CompareTo(a.Item2));

            return HighestScratchScores;
        }

        public static List<Tuple<int, int>> HandicapGameTeam(int week)
        {

            int week_id = Week.GetWeekID(week);

            List<Tuple<int, int>> HighestScratchScores = new List<Tuple<int, int>>();

            foreach (int match_id in Database_manager.multipleIntFromDB($"{week_id}", "week_id", "Matches", "match_id"))
            {
                int league_id = Database_manager.singleIntFromDB($"{match_id}", "match_id", "Matches", "league_id");
               
                foreach (int team_id1 in Database_manager.multipleIntFromDB($"{match_id}", "match_id", "Matches", "team_id1"))
                {
                    List<int> teamTotal = new List<int> { 0, 0, 0 };
                   

                    foreach (int player_id in Database_manager.multipleIntFromDB($"{team_id1}", "team_id", "Teams/Players", "player_id"))
                    {
                        int handicap_id = LeagueStats.GetHandicapID(league_id, player_id);

                        List<int> PlayersGame = Database_manager.AllGames(player_id);
                        if (PlayersGame.Count != 0)
                        {
                            teamTotal[0] += PlayersGame[0] + LeagueStats.GetHandicap(handicap_id);
                            teamTotal[1] += PlayersGame[1] + LeagueStats.GetHandicap(handicap_id);
                            teamTotal[2] += PlayersGame[2] + LeagueStats.GetHandicap(handicap_id);
                        }


                    }

                    if (teamTotal[0] != 0)
                    {
                        teamTotal.Sort((a, b) => b.CompareTo(a));

                        // Store player_id along with the highest game value as a Tuple
                        HighestScratchScores.Add(new Tuple<int, int>(team_id1, teamTotal[0]));
                    }

                }
                foreach (int team_id2 in Database_manager.multipleIntFromDB($"{match_id}", "match_id", "Matches", "team_id2"))
                {
                    List<int> teamTotal = new List<int> { 0, 0, 0 };

                    foreach (int player_id in Database_manager.multipleIntFromDB($"{team_id2}", "team_id", "Teams/Players", "player_id"))
                    {
                        int handicap_id = LeagueStats.GetHandicapID(league_id, player_id);

                        List<int> PlayersGame = Database_manager.AllGames(player_id);
                        if (PlayersGame.Count != 0)
                        {
                            teamTotal[0] += PlayersGame[0] + LeagueStats.GetHandicap(handicap_id);
                            teamTotal[1] += PlayersGame[1] + LeagueStats.GetHandicap(handicap_id);
                            teamTotal[2] += PlayersGame[2] + LeagueStats.GetHandicap(handicap_id);
                        }

                    }

                    if (teamTotal[0] != 0)
                    {
                        teamTotal.Sort((a, b) => b.CompareTo(a));

                        // Store player_id along with the highest game value as a Tuple
                        HighestScratchScores.Add(new Tuple<int, int>(team_id2, teamTotal[0]));
                    }

                }
            }

            HighestScratchScores.Sort((a, b) => b.Item2.CompareTo(a.Item2));

            return HighestScratchScores;
        }

        public static List<Tuple<int, int>> ScratchSeriesTeam(int week)
        {

            int week_id = Week.GetWeekID(week);

            List<Tuple<int, int>> HighestScratchSeries = new List<Tuple<int, int>>();

            foreach (int match_id in Database_manager.multipleIntFromDB($"{week_id}", "week_id", "Matches", "match_id"))
            {
                foreach (int team_id1 in Database_manager.multipleIntFromDB($"{match_id}", "match_id", "Matches", "team_id1"))
                {
                    int teamTotal = 0 ;

                    foreach (int player_id in Database_manager.multipleIntFromDB($"{team_id1}", "team_id", "Teams/Players", "player_id"))
                    {

                        List<int> PlayersGame = Database_manager.AllGames(player_id);
                        if (PlayersGame.Count != 0)
                        {
                            teamTotal = teamTotal+ PlayersGame[0] + PlayersGame[1] + PlayersGame[2];

                        }

                    }

                    if (teamTotal != 0)
                    {
                        

                        // Store player_id along with the highest game value as a Tuple
                        HighestScratchSeries.Add(new Tuple<int, int>(team_id1, teamTotal));
                    }

                }
                foreach (int team_id2 in Database_manager.multipleIntFromDB($"{match_id}", "match_id", "Matches", "team_id2"))
                {
                    int teamTotal = 0;

                    foreach (int player_id in Database_manager.multipleIntFromDB($"{team_id2}", "team_id", "Teams/Players", "player_id"))
                    {

                        List<int> PlayersGame = Database_manager.AllGames(player_id);
                        if (PlayersGame.Count != 0)
                        {
                            teamTotal = teamTotal + PlayersGame[0] + PlayersGame[1] + PlayersGame[2];
                        }

                    }

                    if (teamTotal != 0)
                    {
                      

                        // Store player_id along with the highest game value as a Tuple
                        HighestScratchSeries.Add(new Tuple<int, int>(team_id2, teamTotal));
                    }

                }
            }

            HighestScratchSeries.Sort((a, b) => b.Item2.CompareTo(a.Item2));

            return HighestScratchSeries;
        }

        public static List<Tuple<int, int>> HandicapSeriesTeam(int week)
        {

            int week_id = Week.GetWeekID(week);

            List<Tuple<int, int>> HighestScratchSeries = new List<Tuple<int, int>>();

            foreach (int match_id in Database_manager.multipleIntFromDB($"{week_id}", "week_id", "Matches", "match_id"))
            {
                int league_id = Database_manager.singleIntFromDB($"{match_id}", "match_id", "Matches", "league_id");

                foreach (int team_id1 in Database_manager.multipleIntFromDB($"{match_id}", "match_id", "Matches", "team_id1"))
                {
                    int teamTotal = 0;


                    foreach (int player_id in Database_manager.multipleIntFromDB($"{team_id1}", "team_id", "Teams/Players", "player_id"))
                    {
                        int handicap_id = LeagueStats.GetHandicapID(league_id, player_id);

                        List<int> PlayersGame = Database_manager.AllGames(player_id);
                        if (PlayersGame.Count != 0)
                        {
                            teamTotal = teamTotal + PlayersGame[0] + PlayersGame[1] + PlayersGame[2] + LeagueStats.GetHandicap(handicap_id) * 3;

                        }

                    }

                    if (teamTotal != 0)
                    {


                        // Store player_id along with the highest game value as a Tuple
                        HighestScratchSeries.Add(new Tuple<int, int>(team_id1, teamTotal));
                    }

                }
                foreach (int team_id2 in Database_manager.multipleIntFromDB($"{match_id}", "match_id", "Matches", "team_id2"))
                {
                    int teamTotal = 0;

                    foreach (int player_id in Database_manager.multipleIntFromDB($"{team_id2}", "team_id", "Teams/Players", "player_id"))
                    {
                        int handicap_id = LeagueStats.GetHandicapID(league_id, player_id);

                        List<int> PlayersGame = Database_manager.AllGames(player_id);
                        if (PlayersGame.Count != 0)
                        {
                            teamTotal = teamTotal + PlayersGame[0] + PlayersGame[1] + PlayersGame[2] + LeagueStats.GetHandicap(handicap_id) * 3;
                        }

                    }

                    if (teamTotal != 0)
                    {


                        // Store player_id along with the highest game value as a Tuple
                        HighestScratchSeries.Add(new Tuple<int, int>(team_id2, teamTotal));
                    }

                }
            }

            HighestScratchSeries.Sort((a, b) => b.Item2.CompareTo(a.Item2));

            return HighestScratchSeries;
        }

        public static List<Tuple<string, int>> Leaderboard(int league_id)
        {
            List<Tuple<string, int>> TeamName_Points = new List<Tuple<string, int>>();

            foreach(int team_id in Database_manager.multipleIntFromDB($"{league_id}", "league_id", "Teams", "team_id"))
            {
                string TeamName = Team.GetTeamName(team_id);
                int Points = Team.GetPoints(team_id);

                TeamName_Points.Add(new Tuple<string, int>(TeamName, Points));
            }

           TeamName_Points.Sort((a, b) => b.Item2.CompareTo(a.Item2));

            return TeamName_Points;

        }
            






        public static int Series(int game_id)
        {
            return Database_manager.singleIntFromDB($"{game_id}", "game_id", "Games", "game1") + Database_manager.singleIntFromDB($"{game_id}", "game_id", "Games", "game2") + Database_manager.singleIntFromDB($"{game_id}", "game_id", "Games", "game3");
        }


    }

    public class LeagueStats
    {
        public static void SetTotalPinFall(int match_id, int player_id)
        {
            int league_id = Database_manager.singleIntFromDB($"{match_id}", "match_id", "Matches", "league_id");

            int game_id = Game.GetGameID(match_id, player_id);
            int handicap_id = GetHandicapID(league_id, player_id);

            int newTotalPinFall = GetTotalPinFall(handicap_id) + Game.Series(game_id);

            Database_manager.UpdateTotalPinFall(newTotalPinFall, handicap_id);
        }

        public static void SetNumberOfGames(int match_id, int player_id)
        {
            int league_id = Database_manager.singleIntFromDB($"{match_id}", "match_id", "Matches", "league_id");
            int game_id = Game.GetGameID(match_id, player_id);
            int handicap_id = GetHandicapID(league_id, player_id);

            int newNumberOfGames = GetNumberOfGames(handicap_id) + 3;

            Database_manager.UpdateNumberOfGames(newNumberOfGames, handicap_id);
        }

        public static void SetHandicap(int match_id, int player_id)
        {
            int league_id = Database_manager.singleIntFromDB($"{match_id}", "match_id", "Matches", "league_id");
            int game_id = Game.GetGameID(match_id, player_id);
            int handicap_id = GetHandicapID(league_id, player_id);

            int newHandicap = maths.Handicap(GetTotalPinFall(handicap_id) / GetNumberOfGames(handicap_id));

            Database_manager.UpdateHandicap(newHandicap, handicap_id);

        }

        public static int GetHandicap(int handicap_id)
        {
            return Database_manager.singleIntFromDB($"{handicap_id}", "handicap_id", "LeagueStats", "Handicap");
        }

        public static int GetTotalPinFall(int handicap_id)
        {
            return Database_manager.singleIntFromDB($"{handicap_id}", "handicap_id", "LeagueStats", "TotalPinFall");
        }

        public static int GetNumberOfGames(int handicap_id)
        {
            return Database_manager.singleIntFromDB($"{handicap_id}", "handicap_id", "LeagueStats", "Games");
        }

        public static int GetHandicapID(int league_id, int player_id)
        {
            return Database_manager.singleIntFromDBMC($"{league_id}", $"{player_id}", "league_id", "player_id", "LeagueStats", "handicap_id");
        }


        public static void UpdateLeagueStats(int match_id, int player_id)
        {
            SetTotalPinFall(match_id, player_id);
            SetNumberOfGames(match_id, player_id);
        }

    }

    public class Week
    {
        public static int GetWeekID(int week)
        {
            return Database_manager.singleIntFromDB($"{week}", "Week", "Weeks", "week_id");
        }
    }
}
