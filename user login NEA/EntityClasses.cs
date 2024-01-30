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
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using BCrypt.Net;



namespace user_login_NEA
{
    public class User
    {
        //This subroutine is used to verify if the inputted user name is in the correct
        //Format and isn't taken by other users.
        public static string UsernameValidator(string username)
        {

            if (OtherUsers(username) == true) //calls otherUsers routine to check for other users
            {

                return "Username Taken";
            }
            else
            {
                //Checks if user name is between 2 - 20 characters long
                if (username.Length < 2 || username.Length > 20)
                {
                    return "Username has to be 2 - 20 characters long";
                }
                else
                {
                    //Regex used to check if the user name contains only alphanumeric characters
                    //and _.
                    if (Regex.IsMatch(username, "[^A-Za-z0-9_]") == true)

                    {
                        return "Username can only include alphanumeric characters and '_'";
                    }
                    else
                    {
                        //returns valid if all conditions for the user name is met.
                        return "valid";
                    }

                }


            }


        }
        //This subroutine is used to verify if the inputted password is in the correct
        //Format and outputs an appropriate error message if not, to help the user
        //input a valid password.

        public static string PasswordValidator(string password)
        {
            //A valid password must contain at least:
            //one lowercase letter
            //one uppercase letter
            //either one number or special character
            //and must be between 8 to 20 characters long)
            if (Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*(\d|[^a-zA-Z])).{8,20}$"))
            //compares the inputted password with the regex representing the format of a valid password
            {
                return "valid";
            }
            else if (password.Length < 8 || password.Length > 20)
            {
                return "Password must between 8 - 20 characters long.";
            }
            else if (!Regex.IsMatch(password, @"^(?=.*[a-z])"))
            //checks if the inputted password has at least one lowercase letter using regex pattern above.
            {
                return "Password must contain at least one lowercase letter.";
            }
            else if (!Regex.IsMatch(password, @"^(?=.*[A-Z])"))
            //checks if the inputted password has at least uppercase letter using regex pattern above.
            {
                return "Password must contain at least one uppercase letter.";
            }
            else if (!Regex.IsMatch(password, @"^(?=.*(\d|[^a-zA-Z]))"))
            //checks if the inputted password has at one number or special character using regex pattern above.
            {
                return "Password must contain at least one digit or special character.";
            }

            //Exception handling : In case the error isn't picked up by the rest of the code.
            {
                return "Password does not meet the required criteria.";
            }

        }



        //is used to compare the user's inputted username and password with all the users logged in the database.
        public static bool LoginValidator(string username, string password)
        {
            int user_id = GetUserID(username);
            if (user_id == -1)
            {
                return false;

            }
            else
            {
                if (Encryption.HashChecking(password,user_id) == true)
                {
                    return true;
                }

                return false;
            }


        }

        //It is used to compare the user's inputted username with all the other usernames in the database.
        public static bool OtherUsers(string username)
        {
            //If no username is = to the inputted username the variable used to retreive data from
            //the database will be null, as there is nothing in it.
            if (Database_manager.singleStringFromDB($"{username}", "Username", "Users", "Username") != null)
            {
                return true;
            }
            return false;
        }

        //Adds a user to the database with its username, password and linked player the user is linked to.    Cross-table parameterised SQL
        public static void AddUser(string username, string password, int player_id)
        {
            string passwordHash = Encryption.HashString(password);

            Database_manager.InsertUser(username, passwordHash, player_id);

        }

        public static string GetUsername(int user_id)
        {
            return Database_manager.singleStringFromDB($"{user_id}", "user_id", "Users", "Username");
        }
        public static string GetPasswordHash(int user_id)
        {
            return Database_manager.singleStringFromDB($"{user_id}", "user_id", "Users", "PasswordHash");
        }
        public static int GetUserID(string Username)
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

        public static void SetAdminLevel(int AdminLevel, int user_id)
        {
            Database_manager.UpdateAdmin(AdminLevel, user_id);
        }

        public static List<string> GetAllUsers()
        {
            return Database_manager.columnStringFromDB("Users", "Username");
        }

    }

    public class Player
    {
        //This subrountine uses a regex pattern to validate a inputted name.
        //The name must start with a capital letter
        //followed by lowercase alphabet characters.

        public static string ValidateName(string name)
        {
            if (Regex.IsMatch(name, @"^[A-Z][a-z ,.'-]*$"))
            {
                return "Valid";
            }

            else
            {
                if (!Regex.IsMatch(name, @"^[A-Z].*$")) // exception handling
                {
                    return ("Error: First character must be an uppercase letter.");
                }
                else // exception handling
                {
                    return "Error: Invalid characters or format.";
                }
            }
        }
        //This subrountine is used to add a player to the database as well as all the
        // other information linked to the new player like the team they are in
        // and their stats.
        public static void AddPlayer(string firstname, string lastname, int team_id, int league_id)
        {
            //used to make a new player in the players table
            Database_manager.InsertPlayers(firstname, lastname);
            //used to get the player id, of the newly added player
            int player_id = Database_manager.singleIntFromDBMC($"{firstname}", $"{lastname}", "FirstName", "LastName", "Players", "player_id");


            //makes the new league stats for the new player, using the playerid retrieved.
            Database_manager.InsertHandicap(league_id, player_id);

            //links the new player to the team they are associated to and is added to the Teams/Players linking table.
            Database_manager.InsertPlayerIntoTeam(player_id, team_id);

        }

        //Used to check if the player the user's wants to add is in the database already.
        public static bool OtherPlayers(string InputtedFirstname, string InputtedLastname)
        {

            if (Database_manager.singleIntFromDBMC($"{InputtedFirstname}", $"{InputtedLastname}", "FirstName", "LastName", "Players", "player_id") != -1)
            {
                return true;
            }
            return false;
        }

        //Used to call the Delete Player SQL in database manager file to complete delete a player from the database
        public static void RemovePlayer(int player_id)
        {
            Database_manager.DeletePlayer(player_id);
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
        public static int GetPlayerIDName(string FirstName, string LastName)
        {
            return Database_manager.singleIntFromDBMC($"{FirstName}", $"{LastName}", "FirstName", "LastName", "Players", "player_id");
        }
    }

    public class Team
    {
        public static int GetTeamID_playerID(int player_id)
        {
            return Database_manager.singleIntFromDB($"{player_id}", "player_id", "[Teams/Players]", "team_id");
        }

        //Is stored in a list as a league has multiple teams, which can vary in amount depending on the league.
        public static List<int> GetTeamID_leagueID(int league_id)
        {
            return Database_manager.multipleIntFromDB($"{league_id}", "league_id", "Teams", "team_id");
        }

        public static int GetTeamID_TeamName(string TeamName)
        {
            return Database_manager.singleIntFromDB($"{TeamName}", "TeamName", "Teams", "team_id");
        }

        public static int GetPoints(int team_id)
        {
            return Database_manager.singleIntFromDB($"{team_id}", "team_id", "Teams", "Points");
        }
        public static string GetTeamName(int team_id)
        {
            return Database_manager.singleStringFromDB($"{team_id}", "team_id", "Teams", "TeamName");
        }

        public static int NumberOfPlayers(int team_id)
        {

            return Database_manager.singleIntFromDB($"{team_id}", "team_id", "[Teams/Players]", "COUNT(player_id)"); //Aggregate SQL function
        }
        // Is stored in a list as a team had multiple players, which can also vary in amount.
        public static List<int> GetAllPlayerID(int team_id)
        {
            return Database_manager.multipleIntFromDB($"{team_id}", "team_id", "Teams/Players", "player_id");
        }
        public static void AddTeam(String TeamName, int league_id)
        {
            Database_manager.InsertTeam(TeamName, league_id);
        }

        //This subroutine is responsible for calculating the points earned for each team, after a match.
        public static void SetPoints(int match_id, int player_id1, int player_id2, int player_id3, int player_id4) //used to calculate + input points from a match  
        {
            int newTeam1points = 0;
            int newTeam2points = 0;
            //Gets the league id from the match_id   //Cross-table parameterised SQL
            int league_id = Database_manager.singleIntFromDB($"{match_id}", "match_id", "Matches", "league_id");

            // Used to set the handicap for players who didn't have a handicap before the game played.
            // Whilst Players who already have a handicap dont get their handicap updated until after the match is over.
            // When Teams are given their points.

            if (LeagueStats.GetHandicap(LeagueStats.GetHandicapID(league_id, player_id1)) == 0)
            {
                LeagueStats.SetHandicap(match_id, player_id1);
            }
            else if (LeagueStats.GetHandicap(LeagueStats.GetHandicapID(league_id, player_id2)) == 0)
            {
                LeagueStats.SetHandicap(match_id, player_id2);
            }
            else if (LeagueStats.GetHandicap(LeagueStats.GetHandicapID(league_id, player_id3)) == 0)
            {
                LeagueStats.SetHandicap(match_id, player_id3);
            }
            else if (LeagueStats.GetHandicap(LeagueStats.GetHandicapID(league_id, player_id4)) == 0)
            {
                LeagueStats.SetHandicap(match_id, player_id4);
            }

            // Gets total handicap from player_id1 and player_id2     Cross-table parameterised SQL
            int TotalHandicapTeam1 = Database_manager.singleIntFromDB($"{player_id1}", "player_id", "LeagueStats", "Handicap") + Database_manager.singleIntFromDB($"{player_id2}", "player_id", "LeagueStats", "Handicap");

            // Gets total handicap from player_id3 and player_id4     Cross-table parameterised SQL
            int TotalHandicapTeam2 = Database_manager.singleIntFromDB($"{player_id3}", "player_id", "LeagueStats", "Handicap") + Database_manager.singleIntFromDB($"{player_id4}", "player_id", "LeagueStats", "Handicap");

            //Gets the Game_id fro each player     Cross-table parameterised SQL
            int player1_gameID = Database_manager.singleIntFromDBMC($"{match_id}", $"{player_id1}", "match_id", "player_id", "Games", "game_id");
            int player2_gameID = Database_manager.singleIntFromDBMC($"{match_id}", $"{player_id2}", "match_id", "player_id", "Games", "game_id");
            int player3_gameID = Database_manager.singleIntFromDBMC($"{match_id}", $"{player_id3}", "match_id", "player_id", "Games", "game_id");
            int player4_gameID = Database_manager.singleIntFromDBMC($"{match_id}", $"{player_id4}", "match_id", "player_id", "Games", "game_id");

            //Adds the player's individual games for, adding them to get the Team's total score (with handicap) for each game.
            int Team1_Game1 = Database_manager.singleIntFromDB($"{player1_gameID}", "game_id", "Games", "game1") + Database_manager.singleIntFromDB($"{player2_gameID}", "game_id", "Games", "game1") + TotalHandicapTeam1;
            int Team1_Game2 = Database_manager.singleIntFromDB($"{player1_gameID}", "game_id", "Games", "game2") + Database_manager.singleIntFromDB($"{player2_gameID}", "game_id", "Games", "game2") + TotalHandicapTeam1;
            int Team1_Game3 = Database_manager.singleIntFromDB($"{player1_gameID}", "game_id", "Games", "game3") + Database_manager.singleIntFromDB($"{player2_gameID}", "game_id", "Games", "game3") + TotalHandicapTeam1;

            int Team2_Game1 = Database_manager.singleIntFromDB($"{player3_gameID}", "game_id", "Games", "game1") + Database_manager.singleIntFromDB($"{player4_gameID}", "game_id", "Games", "game1") + TotalHandicapTeam2;
            int Team2_Game2 = Database_manager.singleIntFromDB($"{player3_gameID}", "game_id", "Games", "game2") + Database_manager.singleIntFromDB($"{player4_gameID}", "game_id", "Games", "game2") + TotalHandicapTeam2;
            int Team2_Game3 = Database_manager.singleIntFromDB($"{player3_gameID}", "game_id", "Games", "game3") + Database_manager.singleIntFromDB($"{player4_gameID}", "game_id", "Games", "game3") + TotalHandicapTeam2;

            //Whoever has the team score in game 1 get's two points
            if (Team1_Game1 > Team2_Game1)
            {
                newTeam1points += 2;
            }
            //If they draw they get 1 point each.
            else if (Team1_Game1 == Team2_Game1)
            {
                newTeam1points++;
                newTeam2points++;
            }
            else
            {
                newTeam2points += 2;
            }

            //Whoever has the team score in game 2 get's two points
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

            //Whoever has the team score in game 3 get's two points
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

            //Used to get the each team total handicap score over the three games.
            //Whoever has the highest score gets 2 points as well.
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

            int Team1_id = Team.GetTeamID_playerID(player_id1);
            int Team2_id = Team.GetTeamID_playerID(player_id4);

            // Is used to get the old points for each team and store the old points of each team.
            //+ the new points each point earned from the current match.

            int Team1points = Database_manager.singleIntFromDB($"{Team1_id}", "team_id", "Teams", "Points") + newTeam1points;
            int Team2points = Database_manager.singleIntFromDB($"{Team2_id}", "team_id", "Teams", "Points") + newTeam2points;


            //updated points are added to the database
            Database_manager.UpdatePoints(Team1points, Team1_id);
            Database_manager.UpdatePoints(Team2points, Team2_id);



        }
    }

    public class Game
    {
        //Only allows values 0 - 300 to inputted into the scoresheet.
        //As these are the only possible scores to get in bowling
        public static string ValidateGameNumber(string inputNumber)
        {
            string pattern = @"^(0|[1-9]|[1-9]\d|1\d{2}|2[0-9]{2}|300)$";
            string input = inputNumber;

            Regex regex = new Regex(pattern);

            //checks if the input number matches with the regex pattern.
            if (regex.IsMatch(input))
            {
                return "valid";
            }
            else //error handling
            {
                return "Input does not match the pattern for numbers from 0 to 300.";
            }
        }


        public static void InputGame(int match_id, int player_id, int game1, int game2, int game3)
        {
            Database_manager.InsertGame(match_id, player_id, game1, game2, game3);
        }

        public static int GetGameID(int match_id, int player_id)
        {
            return Database_manager.singleIntFromDBMC($"{match_id}", $"{player_id}", "match_id", "player_id", "Games", "game_id");
        }

        //Used to get the Scratch game score from each player in a given week. from highest to lowest
        //which is stored in order from highest to lowest, in a Touple list (int,int)
        //with item 1 being the, player id the highest score belongs to and item 2,
        //being the score the player got.
        public static List<Tuple<int, int>> HighestScratch(int week)
        {
            //gets the week_id
            int week_id = Week.GetWeekID(week);

            List<Tuple<int, int>> HighestScratchScores = new List<Tuple<int, int>>();

            //Used to get all the matches in a given week from the week_id     Cross-table paramatised SQL.
            foreach (int match_id in Database_manager.multipleIntFromDB($"{week_id}", "week_id", "Matches", "match_id"))
            {
                //Used to get the players ids in each of the matches     Cross-table paramatised SQL.
                foreach (int player_id in Database_manager.multipleIntFromDB($"{match_id}", "match_id", "Games", "player_id"))
                {
                    //Used to get the all of a player's games and stores it in a list.
                    List<int> PlayersGame = Database_manager.AllGames(player_id, match_id);

                    //sorts out the list from the player's highest score to lowest.
                    PlayersGame.Sort((a, b) => b.CompareTo(a));

                    // Store player_id along with the highest game value as a Tuple
                    HighestScratchScores.Add(new Tuple<int, int>(player_id, PlayersGame[0]));
                }
            }

            //Sort the TotalGames list based on the highest game value
            HighestScratchScores.Sort((a, b) => b.Item2.CompareTo(a.Item2));

            return HighestScratchScores;
        }

        //Used to get the Handicap game score from each team in a given week. from highest to lowest
        public static List<Tuple<int, int>> HighestHandicap(int week)
        {
            int week_id = Week.GetWeekID(week);

            List<Tuple<int, int>> HighestHandicapScore = new List<Tuple<int, int>>();

            //  Cross - table parameterised SQL
            foreach (int match_id in Database_manager.multipleIntFromDB($"{week_id}", "week_id", "Matches", "match_id"))
            {
                //   Cross-table parameterised SQL
                foreach (int player_id in Database_manager.multipleIntFromDB($"{match_id}", "match_id", "Games", "player_id"))
                {
                    //   Cross-table parameterised SQL
                    int league_id = Database_manager.singleIntFromDB($"{match_id}", "match_id", "Matches", "league_id");

                    int handicap_id = LeagueStats.GetHandicapID(league_id, player_id);

                    List<int> PlayersGame = Database_manager.AllGames(player_id, match_id);

                    PlayersGame.Sort((a, b) => b.CompareTo(a));

                    // Store player_id along with the highest game value as a Tuple
                    HighestHandicapScore.Add(new Tuple<int, int>(player_id, PlayersGame[0] + LeagueStats.GetHandicap(handicap_id)));
                }
            }

            // Sort the TotalGames list based on the highest game value
            HighestHandicapScore.Sort((a, b) => b.Item2.CompareTo(a.Item2));

            return HighestHandicapScore;
        }

        //Used to get the Scratch series score from each player in a given week. from highest to lowest
        public static List<Tuple<int, int>> HighestScratchSeries(int week)
        {
            int week_id = Week.GetWeekID(week);
            List<Tuple<int, int>> HighestScratchSeries = new List<Tuple<int, int>>();

            //   Cross-table parameterised SQL
            foreach (int match_id in Database_manager.multipleIntFromDB($"{week_id}", "week_id", "Matches", "match_id"))
            {
                //   Cross-table parameterised SQL
                foreach (int player_id in Database_manager.multipleIntFromDB($"{match_id}", "match_id", "Games", "player_id"))
                {
                    List<int> PlayersGame = Database_manager.AllGames(player_id, match_id);
                    PlayersGame.Sort((a, b) => b.CompareTo(a));

                    // Store player_id along with the highest game value as a Tuple
                    HighestScratchSeries.Add(new Tuple<int, int>(player_id, PlayersGame[0] + PlayersGame[1] + PlayersGame[2]));
                }
            }

            // Sort the TotalGames list based on the highest game value
            HighestScratchSeries.Sort((a, b) => b.Item2.CompareTo(a.Item2));

            return HighestScratchSeries;
        }


        //Used to get the HighestHandicap Series score from a player in a given week.
        public static List<Tuple<int, int>> HighestHandicapSeries(int week)
        {
            int week_id = Week.GetWeekID(week);
            List<Tuple<int, int>> HighestHandicapSeries = new List<Tuple<int, int>>();

            //   Cross-table parameterised SQL
            foreach (int match_id in Database_manager.multipleIntFromDB($"{week_id}", "week_id", "Matches", "match_id"))
            {
                //   Cross-table parameterised SQL
                foreach (int player_id in Database_manager.multipleIntFromDB($"{match_id}", "match_id", "Games", "player_id"))
                {
                    //   Cross-table parameterised SQL
                    int league_id = Database_manager.singleIntFromDB($"{match_id}", "match_id", "Matches", "league_id");
                    int handicap_id = LeagueStats.GetHandicapID(league_id, player_id);

                    List<int> PlayersGame = Database_manager.AllGames(player_id, match_id);
                    PlayersGame.Sort((a, b) => b.CompareTo(a));

                    // Store player_id along with the highest game value as a Tuple
                    HighestHandicapSeries.Add(new Tuple<int, int>(player_id, PlayersGame[0] + PlayersGame[1] + PlayersGame[2] + (LeagueStats.GetHandicap(handicap_id) * 3)));
                }
            }

            // Sort the TotalGames list based on the highest game value
            HighestHandicapSeries.Sort((a, b) => b.Item2.CompareTo(a.Item2));

            return HighestHandicapSeries;
        }


        //Used to get the Scratch game scores from each team in a given week. from highest to lowest
        public static List<Tuple<int, int>> ScratchGameTeam(int week)
        {

            int week_id = Week.GetWeekID(week);

            List<Tuple<int, int>> HighestScratchScores = new List<Tuple<int, int>>();

            //   Cross-table parameterised SQL
            foreach (int match_id in Database_manager.multipleIntFromDB($"{week_id}", "week_id", "Matches", "match_id"))
            {
                //   Cross-table parameterised SQL
                foreach (int team_id1 in Database_manager.multipleIntFromDB($"{match_id}", "match_id", "Matches", "team_id1"))
                {
                    //makes a list used to store 3 items.
                    List<int> teamTotal = new List<int> { 0, 0, 0 };

                    //   Cross-table parameterised SQL
                    foreach (int player_id in Database_manager.multipleIntFromDB($"{team_id1}", "team_id", "Teams/Players", "player_id"))
                    {

                        List<int> PlayersGame = Database_manager.AllGames(player_id, match_id);

                        //Checks if the player has scores inputted into the system. 
                        if (PlayersGame.Count != 0)
                        {
                            // Both player's game 1 is added and stored in the first item in the teamTotal list.
                            teamTotal[0] += PlayersGame[0];
                            // Both player's game 2 is added and stored in the first item in the teamTotal list.
                            teamTotal[1] += PlayersGame[1];
                            // Both player's game 3 is added and stored in the first item in the teamTotal list.
                            teamTotal[2] += PlayersGame[2];
                        }

                    }

                    //Checks if the team has inputted scores yet (prevents errors)
                    if (teamTotal[0] != 0)
                    {
                        //sorts the team game scores from highest to lowest.
                        teamTotal.Sort((a, b) => b.CompareTo(a));

                        // Stores the team_id along with the highest game value as a Tuple
                        HighestScratchScores.Add(new Tuple<int, int>(team_id1, teamTotal[0]));
                    }

                }

                //Each match has two teams, so the process is repeated for the second team as well
                //And follows the same code above but teamid_1 is replaced with teamid_2

                //   Cross-table parameterised SQL
                foreach (int team_id2 in Database_manager.multipleIntFromDB($"{match_id}", "match_id", "Matches", "team_id2"))
                {
                    List<int> teamTotal = new List<int> { 0, 0, 0 };

                    //   Cross-table parameterised SQL
                    foreach (int player_id in Database_manager.multipleIntFromDB($"{team_id2}", "team_id", "Teams/Players", "player_id"))
                    {

                        List<int> PlayersGame = Database_manager.AllGames(player_id, match_id);
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

                        // Store team_id along with the highest game value as a Tuple
                        HighestScratchScores.Add(new Tuple<int, int>(team_id2, teamTotal[0]));
                    }

                }
            }

            //Sorts out the teams from the highest scoring team game to the lowest scoring team game.
            HighestScratchScores.Sort((a, b) => b.Item2.CompareTo(a.Item2));

            return HighestScratchScores;
        }


        //Used to get the Handicap game score from each team in a given week. from highest to lowest
        //Basically the same as the subroutine above but adds the team's handicap onto the 
        //team's highest scratch scores for each game
        public static List<Tuple<int, int>> HandicapGameTeam(int week)
        {

            int week_id = Week.GetWeekID(week);

            List<Tuple<int, int>> HighestHandicapScores = new List<Tuple<int, int>>();

            //   Cross-table parameterised SQL
            foreach (int match_id in Database_manager.multipleIntFromDB($"{week_id}", "week_id", "Matches", "match_id"))
            {
                //   Cross-table parameterised SQL
                int league_id = Database_manager.singleIntFromDB($"{match_id}", "match_id", "Matches", "league_id");

                //   Cross-table parameterised SQL
                foreach (int team_id1 in Database_manager.multipleIntFromDB($"{match_id}", "match_id", "Matches", "team_id1"))
                {
                    List<int> teamTotal = new List<int> { 0, 0, 0 };

                    //   Cross-table parameterised SQL
                    foreach (int player_id in Database_manager.multipleIntFromDB($"{team_id1}", "team_id", "Teams/Players", "player_id"))
                    {
                        int handicap_id = LeagueStats.GetHandicapID(league_id, player_id);

                        List<int> PlayersGame = Database_manager.AllGames(player_id, match_id);
                        if (PlayersGame.Count != 0)
                        {
                            // Both player's game 1 is added + the player's handicap and stores it in the first item in the teamTotal list.
                            teamTotal[0] += PlayersGame[0] + LeagueStats.GetHandicap(handicap_id);
                            // Both player's game 2 is added + the player's handicap and stores it in the first item in the teamTotal list.
                            teamTotal[1] += PlayersGame[1] + LeagueStats.GetHandicap(handicap_id);
                            // Both player's game 3 is added + the player's handicap and stores it in the first item in the teamTotal list.
                            teamTotal[2] += PlayersGame[2] + LeagueStats.GetHandicap(handicap_id);
                        }


                    }

                    if (teamTotal[0] != 0)
                    {
                        teamTotal.Sort((a, b) => b.CompareTo(a));

                        // Store player_id along with the highest game value as a Tuple
                        HighestHandicapScores.Add(new Tuple<int, int>(team_id1, teamTotal[0]));
                    }

                }
                //   Cross-table parameterised SQL
                foreach (int team_id2 in Database_manager.multipleIntFromDB($"{match_id}", "match_id", "Matches", "team_id2"))
                {
                    List<int> teamTotal = new List<int> { 0, 0, 0 };

                    //   Cross-table parameterised SQL
                    foreach (int player_id in Database_manager.multipleIntFromDB($"{team_id2}", "team_id", "Teams/Players", "player_id"))
                    {
                        int handicap_id = LeagueStats.GetHandicapID(league_id, player_id);

                        List<int> PlayersGame = Database_manager.AllGames(player_id, match_id);
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
                        HighestHandicapScores.Add(new Tuple<int, int>(team_id2, teamTotal[0]));
                    }

                }
            }

            //Sorts out the teams from the highest scoring team game to the lowest scoring team game.
            HighestHandicapScores.Sort((a, b) => b.Item2.CompareTo(a.Item2));

            return HighestHandicapScores;
        }

        //Used to get the Scratch series score from each team in a given week. from highest to lowest
        public static List<Tuple<int, int>> ScratchSeriesTeam(int week)
        {

            int week_id = Week.GetWeekID(week);

            List<Tuple<int, int>> HighestScratchSeries = new List<Tuple<int, int>>();

            //   Cross-table parameterised SQL
            foreach (int match_id in Database_manager.multipleIntFromDB($"{week_id}", "week_id", "Matches", "match_id"))
            {
                //   Cross-table parameterised SQL
                foreach (int team_id1 in Database_manager.multipleIntFromDB($"{match_id}", "match_id", "Matches", "team_id1"))
                {
                    int teamTotal = 0;

                    //   Cross-table parameterised SQL
                    foreach (int player_id in Database_manager.multipleIntFromDB($"{team_id1}", "team_id", "Teams/Players", "player_id"))
                    {

                        List<int> PlayersGame = Database_manager.AllGames(player_id, match_id);
                        if (PlayersGame.Count != 0)
                        {
                            teamTotal = teamTotal + PlayersGame[0] + PlayersGame[1] + PlayersGame[2];

                        }

                    }

                    if (teamTotal != 0)
                    {


                        // Store player_id along with the highest game value as a Tuple
                        HighestScratchSeries.Add(new Tuple<int, int>(team_id1, teamTotal));
                    }

                }
                //   Cross-table parameterised SQL
                foreach (int team_id2 in Database_manager.multipleIntFromDB($"{match_id}", "match_id", "Matches", "team_id2"))
                {
                    int teamTotal = 0;

                    //   Cross-table parameterised SQL
                    foreach (int player_id in Database_manager.multipleIntFromDB($"{team_id2}", "team_id", "Teams/Players", "player_id"))
                    {

                        List<int> PlayersGame = Database_manager.AllGames(player_id, match_id);
                        if (PlayersGame.Count != 0)
                        {
                            //Adds all of the currently selected players games and adds it to the team total.
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

            //Sorts out the teams from the highest scoring team series to the lowest scoring team series.
            HighestScratchSeries.Sort((a, b) => b.Item2.CompareTo(a.Item2));

            return HighestScratchSeries;
        }

        //Used to get the Handicap series score from each team in a given week. from highest to lowest
        public static List<Tuple<int, int>> HandicapSeriesTeam(int week)
        {

            int week_id = Week.GetWeekID(week);

            List<Tuple<int, int>> HighestHandicapSeries = new List<Tuple<int, int>>();

            //   Cross-table parameterised SQL
            foreach (int match_id in Database_manager.multipleIntFromDB($"{week_id}", "week_id", "Matches", "match_id"))
            {
                int league_id = Database_manager.singleIntFromDB($"{match_id}", "match_id", "Matches", "league_id");

                //   Cross-table parameterised SQL
                foreach (int team_id1 in Database_manager.multipleIntFromDB($"{match_id}", "match_id", "Matches", "team_id1"))
                {
                    int teamTotal = 0;


                    //   Cross-table parameterised SQL
                    foreach (int player_id in Database_manager.multipleIntFromDB($"{team_id1}", "team_id", "Teams/Players", "player_id"))
                    {
                        //   Cross-table parameterised SQL
                        int handicap_id = LeagueStats.GetHandicapID(league_id, player_id);

                        List<int> PlayersGame = Database_manager.AllGames(player_id, match_id);
                        if (PlayersGame.Count != 0)
                        {
                            //Adds all of the currently selected players games + their handicap X 3
                            //(since there are 3 games in a series) and adds it to the team total.
                            teamTotal = teamTotal + PlayersGame[0] + PlayersGame[1] + PlayersGame[2] + LeagueStats.GetHandicap(handicap_id) * 3;

                        }

                    }

                    if (teamTotal != 0)
                    {


                        // Store player_id along with the highest game value as a Tuple
                        HighestHandicapSeries.Add(new Tuple<int, int>(team_id1, teamTotal));
                    }

                }
                //   Cross-table parameterised SQL
                foreach (int team_id2 in Database_manager.multipleIntFromDB($"{match_id}", "match_id", "Matches", "team_id2"))
                {
                    int teamTotal = 0;

                    //   Cross-table parameterised SQL
                    foreach (int player_id in Database_manager.multipleIntFromDB($"{team_id2}", "team_id", "Teams/Players", "player_id"))
                    {
                        //   Cross-table parameterised SQL
                        int handicap_id = LeagueStats.GetHandicapID(league_id, player_id);

                        List<int> PlayersGame = Database_manager.AllGames(player_id, match_id);
                        if (PlayersGame.Count != 0)
                        {
                            teamTotal = teamTotal + PlayersGame[0] + PlayersGame[1] + PlayersGame[2] + LeagueStats.GetHandicap(handicap_id) * 3;
                        }

                    }

                    if (teamTotal != 0)
                    {


                        // Store player_id along with the highest game value as a Tuple
                        HighestHandicapSeries.Add(new Tuple<int, int>(team_id2, teamTotal));
                    }

                }
            }

            //Sorts out the teams from the highest scoring team series to the lowest scoring team series.
            HighestHandicapSeries.Sort((a, b) => b.Item2.CompareTo(a.Item2));

            return HighestHandicapSeries;
        }

        //This subroutine is used to store all the teams, and their points in order
        //from highest to lowest.
        public static List<Tuple<string, int>> Leaderboard(int league_id)
        {
            List<Tuple<string, int>> TeamName_Points = new List<Tuple<string, int>>();

            // Gets the teams in associated in a league.
            //Cross-table paramatised sql.
            foreach (int team_id in Database_manager.multipleIntFromDB($"{league_id}", "league_id", "Teams", "team_id"))
            {
                string TeamName = Team.GetTeamName(team_id);
                int Points = Team.GetPoints(team_id);

                TeamName_Points.Add(new Tuple<string, int>(TeamName, Points));
            }

            //sorts the list out depending on the points of the team from highest to lowest.
            TeamName_Points.Sort((a, b) => b.Item2.CompareTo(a.Item2));

            return TeamName_Points;

        }

        //Gets the total score from a game_id's game1, game2 and game 
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

        // Cross-table Paramatised SQL
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

        public static List<int> TotalWeeks()
        {
            return Database_manager.columnIntFromDB("Weeks", "week");
        }
    }

    public class League
    {
        public static List<string> GetLeagues()
        {
            return Database_manager.columnStringFromDB("Leagues", "LeagueName");
        }

        public static int GetLeagueIDLeagueName(string LeagueName)
        {
            return Database_manager.singleIntFromDB($"{LeagueName}", "LeagueName", "Leagues", "league_id");
        }
        public static int GetLeagueIDMatch_id(int match_id)
        {
            return Database_manager.singleIntFromDB($"{match_id}", "match_id", "Matches", "league_id");
        }

    }

    public class Matches
    {
        //Cross table parameterised SQL
        public static List<int> GetMatches(int week_id, int league_id)
        {
            return Database_manager.multipleIntFromDBMC($"{week_id}", $"{league_id}","week_id", "league_id", "Matches", $"match_id");
        }

        public static bool CheckForGame(int match_id)
        {
            if (Database_manager.singleIntFromDB($"{match_id}", "match_id", "Games", "game_id") != -1)
            {
                return true; // There already is a game
            }
            return false; // There is no game recorded for that match.
        }
        public static int GetTeamID1(int match_id)
        {
            return Database_manager.singleIntFromDB($"{match_id}", "match_id", "Matches", "team_id1");
        }

        public static int GetTeamID2(int match_id)
        {
            return Database_manager.singleIntFromDB($"{match_id}", "match_id", "Matches", "team_id2");
        }
    }
    


    //Used to handle all the hashing part of the program being using a library for bcrypt algorithm.
    class Encryption
    {
        public static string HashString(string password)
        {
             string passwordHash = BCrypt.Net.BCrypt.EnhancedHashPassword(password, 13);
             return passwordHash;
        }

        public static bool HashChecking(string InputtedPassword, int UserID)
        {
            
            if(BCrypt.Net.BCrypt.EnhancedVerify($"{InputtedPassword}", User.GetPasswordHash(UserID)) == true)
            {
                return true;
            }

            return false;
        }
        
    }

}


