using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
namespace user_login_NEA
{
    public class Database_manager
    {
        // This subroutine is used to call the connection to the database, allowing visual studio C# to communicate
        // with the SQLite database which is stored in a file on the laptop.
        public static string Connection()
        {
            string connectionString;
            string path = @"C:\Users\olive\OneDrive\Documents\GitHub\A-Level-Computer-Science-Nea";
            string databaseName = "DATABASE.db";
            connectionString = $"Data Source={System.IO.Path.Combine(path, databaseName)};Version=3;";
            return connectionString;
        }
        //Used to update the points of a team in the Teams Table.
        //Takes new total number of points for the team and a team_id to identify
        //who the new points belong to.
        public static void UpdatePoints(int Points, int team_id)
        {   //Update Sql query
            string updateQuery = "UPDATE Teams SET Points = @Points WHERE team_id = @TeamID";
            // Create a new SQLite connection
            using (SQLiteConnection connection = new(Connection()))
            {
                // Open the connection
                connection.Open();
                // Create a command with the query and connection
                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Points", Points);
                    command.Parameters.AddWithValue("@TeamID", team_id);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        //Used to update the new handicaps after new games have been inputted
        //Takes in the new handicaps which have been calculated in the entity class, and the handicap_id
        //to identify who the new handicap belongs to.
        public static void UpdateHandicap(int Handicap, int handicap_id)
        {   // Update SQ: query
            string updateQuery = "UPDATE LeagueStats SET Handicap = @Handicap WHERE handicap_id = @HandicapID";
            // Create a new SQLite connection
            using (SQLiteConnection connection = new(Connection()))
            {
                // Open the connection
                connection.Open();
                // Create a command with the query and connection
                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Handicap", Handicap);
                    command.Parameters.AddWithValue("@HandicapID", handicap_id);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        //Used to update the TotalPinFall after new games have been inputted.
        //Takes new TotalPinFall which was calculated in the entity class.
        public static void UpdateTotalPinFall(int TotalPinFall, int handicap_id)
        {
            //Update SQL query
            string updateQuery = "UPDATE LeagueStats SET TotalPinFall = @TotalPinFall WHERE handicap_id = @HandicapID";
            // Create a new SQLite connection
            using (SQLiteConnection connection = new(Connection()))
            {
                // Open the connection
                connection.Open();
                // Create a command with the query and connection
                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@TotalPinFall", TotalPinFall);
                    command.Parameters.AddWithValue("@HandicapID", handicap_id);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        //Used to update the NumberOfGames Played by a player after new games have been inputted.
        public static void UpdateNumberOfGames(int NumberOfGames, int handicap_id)
        {
            string updateQuery = "UPDATE LeagueStats SET Games = @Games WHERE handicap_id = @HandicapID";
            // Create a new SQLite connection
            using (SQLiteConnection connection = new(Connection()))
            {
                // Open the connection
                connection.Open();
                // Create a command with the query and connection
                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Games", NumberOfGames);
                    command.Parameters.AddWithValue("@HandicapID", handicap_id);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        //Used to update the User name of a user from the User Table in the database.
        public static void UpdateUsername(string newUsername, int user_id)
        {
            string updateQuery = "UPDATE Users SET Username = @Username WHERE user_id = @user_id";
            // Create a new SQLite connection
            using (SQLiteConnection connection = new(Connection()))
            {
                // Open the connection
                connection.Open();
                // Create a command with the query and connection
                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", newUsername);
                    command.Parameters.AddWithValue("@user_id", user_id);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        //Used to update the account level of the user from the User Table in the database.
        public static void UpdateAdmin(int AdminLevel, int user_id)
        {
            string updateQuery = "UPDATE Users SET Admin = @Admin WHERE user_id = @user_id";
            // Create a new SQLite connection
            using (SQLiteConnection connection = new(Connection()))
            {
                // Open the connection
                connection.Open();
                // Create a command with the query and connection
                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Admin", AdminLevel);
                    command.Parameters.AddWithValue("@user_id", user_id);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        //This subroutine is used to make a user account in the database,
        //taking 2 inputting data and 1 linking foreign key:
        //User name, password, and player_id which is a foreign key from the Players table.        Cross-table parameterized SQL
        public static void InsertUser(string Username, string PasswordHash, int Player_id)
        {
            // Creating the SQL query to insert a new user into the 'Users' table
            string insertQuery = $"INSERT INTO Users (Username, PasswordHash, player_id) VALUES ('{Username}', '{PasswordHash}', '{Player_id}');";
            // Using a connection to an SQLite database
            using (SQLiteConnection connection = new SQLiteConnection(Connection()))
            {
                // Open the database connection
                connection.Open();
                // Creating a command with the SQL query and the open connection
                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    // Executing the query to insert a new user
                    command.ExecuteNonQuery();

                    // Close the database connection
                    connection.Close();
                }
            }
        }
        //This subroutine is used to make insert a game into
        //the Games table in the database, taking 3 inputs, and 2 foreign keys:
        //the foreign keys is used to link the games to an individual player who played the three games
        //and the match/fixture the games where played in.

        //the primary key (game_id) is automatically incremented by the database itself.      Cross-table parameterized SQL

        public static void InsertGame(int match_id, int player_id, int game1, int game2, int game3)
        {
            // INSERT query
            string insertQuery = $"INSERT INTO Games (match_id, player_id, game1, game2, game3) VALUES ('{match_id}','{player_id}', '{game1}', '{game2}', '{game3}');";
            // Create a new SQLite connection
            using (SQLiteConnection connection = new(Connection()))
            {
                // Open the connection
                connection.Open();
                // Create a command with the query and connection
                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    // Execute the query
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        //This subroutine is used to make insert a player into
        //the Players table in the database
        public static void InsertPlayers(string firstname, string lastname)
        {
            // INSERT query
            string insertQuery = $"INSERT INTO Players (FirstName, LastName) VALUES ('{firstname}','{lastname}');";
            // Create a new SQLite connection
            using (SQLiteConnection connection = new(Connection()))
            {
                // Open the connection
                connection.Open();
                // Create a command with the query and connection
                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    // Execute the query
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public static void InsertTeam(string TeamName, int league_id)
        {
            // INSERT query
            string insertQuery = $"INSERT INTO Teams (TeamName, league_id) VALUES ('{TeamName}','{league_id}');";
            // Create a new SQLite connection
            using (SQLiteConnection connection = new(Connection()))
            {
                // Open the connection
                connection.Open();

                // Create a command with the query and connection
                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    // Execute the query
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        //This subroutine is used to make insert a new handicap into
        //the LeagueStats table in the database
        public static void InsertHandicap(int league_id, int player_id)
        {
            // INSERT query
            string insertQuery = $"INSERT INTO LeagueStats (league_id, player_id, Handicap) VALUES ('{league_id}','{player_id}' , '0');";
            // Create a new SQLite connection
            using (SQLiteConnection connection = new(Connection()))
            {
                // Open the connection
                connection.Open();
                // Create a command with the query and connection
                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    // Execute the query
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        //This subroutine is used to make insert a new player into a team 
        //in the Teams/Players table.
        public static void InsertPlayerIntoTeam(int player_id, int team_id)
        {
            string insertQuery = $"INSERT INTO [Teams/Players] (player_id, team_id ) VALUES ('{player_id}','{team_id}');"; // Had to use [] since / is a reserved word in SQL.
            using (SQLiteConnection connection = new(Connection()))
            {
                // Open the connection
                connection.Open();
                // Create a command with the query and connection
                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    // Execute the query
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        //Used to delete players from the database, by inputting their player_id
        //From the Players table.
        public static void DeletePlayer(int player_id)
        {
            string deleteQuery = $"DELETE FROM Players WHERE player_id = '{player_id}';";

            using (SQLiteConnection connection = new SQLiteConnection(Connection()))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        //Used to compare the inputed user name and password with all of the user names 
        // and passwords in the Users table.
        public static bool AuthenticateUserLoginIn(string username, string password)
        {
            // Open the connection
            using (SQLiteConnection connection = new(Connection()))
            {
                //SQL Select Query
                string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
                using (SQLiteCommand command = new(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        return reader.Read(); //returns true if a match is found
                    }
                }
            }
        }

        //This method is a general subroutine, to get a single integer value from the database.
        //I made it a general method to increase the reproducibility of the subroutine and reduce
        //code needed for similar queries. It takes in 5 values:
        //Input - the data value being parameterized in the query.
        //attributeNameQuery name of the heading/column the Input belongs to.
        //TableName - Table in database being queried.
        //attributeNameOutput - The heading/column the Output (string) data belongs to.          
        public static int singleIntFromDB(string Input, string attributeNameQuery, string TableName, string attributeNameOutput)
        {
            int attributeValue = -1; // Default value indicating attribute not found
            using (SQLiteConnection connection = new SQLiteConnection(Connection()))
            {
                connection.Open();
                // Used a parameterized query to prevent SQL injection
                string sqlQuery = $"SELECT {attributeNameOutput} FROM {TableName}  WHERE {attributeNameQuery} = @{attributeNameQuery}";

                using (SQLiteCommand command = new SQLiteCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue($"@{attributeNameQuery}", Input);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Check if the attribute was found
                            attributeValue = reader.GetInt32(0);
                        }
                    }
                }
                connection.Close();
            }
            return attributeValue;
        }
        //This method is a general subroutine, to get a single string value from the database.
        //Similar to the subroutine above but the variable used to store the result must be string
        //Instead of int.
        public static string singleStringFromDB(string input, string attributeNameQuery, string tableName, string attributeNameOutput)
        {
            string attributeString = null; // Default value indicating attribute not found
            using (SQLiteConnection connection = new SQLiteConnection(Connection()))
            {
                connection.Open();
                // Use a parameterized query to prevent SQL injection
                string sqlQuery = $"SELECT {attributeNameOutput} FROM {tableName} WHERE {attributeNameQuery} = @{attributeNameQuery}";

                using (SQLiteCommand command = new SQLiteCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue($"@{attributeNameQuery}", input);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Check if the attribute was found
                            attributeString = reader.GetString(0);
                        }
                    }
                }
                connection.Close();
            }
            return attributeString;
        }
        //This method is a general subroutine, to get a multiple integer values from the database.
        //The data type list is used as, the known items of the output can vary depending on the parameters inputted.
        public static List<int> multipleIntFromDB(string Input, string attributeNameQuery, string TableName, string attributeNameOutput)
        {
            List<int> attributeValues = new List<int>(); // Collection to store multiple attribute values
            using (SQLiteConnection connection = new(Connection()))
            {
                connection.Open();

                string sqlQuery = $"SELECT {attributeNameOutput} FROM \"{TableName}\" WHERE {attributeNameQuery} = @{attributeNameQuery}";
                // Previous issue, it executes the literal of this string, so it was running "SELECT x FROM y/z" and slashes are special; i escaped that slash by enclosing it in quotes;
                using (SQLiteCommand command = new SQLiteCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue($"@{attributeNameQuery}", Input);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Read and add each attribute value to the collection
                            int attributeValue = reader.GetInt32(0);
                            attributeValues.Add(attributeValue);
                        }
                    }
                }
                connection.Close();
            }
            return attributeValues;
        }
        //This method is a general subroutine, to get a multiple string values from the database.
        //IS REDUNDANT AS IT NOT CALLED IN MY PROJECT, JUST KEPT JUST INCASE I NEEDED IT FOR EXTENSTION FUNCTIONS..
        public static List<string> multipleStringFromDB(string Input, string attributeNameQuery, string TableName, string attributeNameOutput)
        {
            List<string> attributeValues = new List<string>(); // Collection to store multiple attribute strings
            using (SQLiteConnection connection = new SQLiteConnection(Connection()))
            {
                connection.Open();
                string sqlQuery = $"SELECT {attributeNameOutput} FROM \"{TableName}\" WHERE \"{attributeNameQuery}\" = @{attributeNameQuery}";

                using (SQLiteCommand command = new SQLiteCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue($"@{attributeNameQuery}", Input);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Read and add each attribute value to the collection
                            string attributeValue = reader.GetString(0);
                            attributeValues.Add(attributeValue);
                        }
                    }
                }
                connection.Close();
            }
            return attributeValues;
        }

        //It is used to return all the items in a column which are string, without a parameter, in a string list.

        public static List<string> columnStringFromDB(string TableName, string attributeNameOutput)
        {
            List<string> attributeValues = new List<string>(); // Collection to store multiple attribute strings
            using (SQLiteConnection connection = new SQLiteConnection(Connection()))
            {
                connection.Open();
                string sqlQuery = $"SELECT \"{attributeNameOutput}\" FROM \"{TableName}\" ";

                using (SQLiteCommand command = new SQLiteCommand(sqlQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Read and add each attribute value to the collection
                            string attributeValue = reader.GetString(0);
                            attributeValues.Add(attributeValue);
                        }
                    }
                }
                connection.Close();
            }
            return attributeValues;
        }

        //It is used to return all the items in a column which are int, without a parameter, in a int list.
        public static List<int> columnIntFromDB(string TableName, string attributeNameOutput)
        {
            List<int> attributeValues = new List<int>(); // Collection to store multiple attribute strings

            using (SQLiteConnection connection = new SQLiteConnection(Connection()))
            {
                connection.Open();
                string sqlQuery = $"SELECT {attributeNameOutput} FROM \"{TableName}\" ";

                using (SQLiteCommand command = new SQLiteCommand(sqlQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Read and add each attribute value to the collection
                            int attributeValue = reader.GetInt32(0);
                            attributeValues.Add(attributeValue);
                        }
                    }
                }
                connection.Close();
            }
            return attributeValues;
        }

        // Used to return all the games (games 1 + games 2 + game 3)
        //From the foreign keys player_id and match_id      Cross-table parameterized SQL
        public static List<int> AllGames(int player_id, int match_id)
        {
            List<int> attributeValues = new List<int>();

            using (SQLiteConnection connection = new SQLiteConnection(Connection()))
            {
                connection.Open();
                string sqlQuery = $"SELECT game1, game2, game3 FROM Games WHERE player_id = @player_id AND match_id = @match_id";

                using (SQLiteCommand command = new SQLiteCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@player_id", player_id);
                    command.Parameters.AddWithValue("@match_id", match_id);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Read and add each attribute value to the collection
                            int game1Value = reader.GetInt32(0);  // Assumes game1 is the first column
                            int game2Value = reader.GetInt32(1);  // Assumes game2 is the second column
                            int game3Value = reader.GetInt32(2);  // Assumes game3 is the third column

                            attributeValues.Add(game1Value);
                            attributeValues.Add(game2Value);
                            attributeValues.Add(game3Value);
                        }
                    }
                }
                connection.Close();
            }
            // Collection to store multiple attribute strings
            return attributeValues;
        }

        //This method is a general subroutine,to get a single int from the database,
        //which has two parameters than the output data needs to meet.
        public static int singleIntFromDBMC(string Input, string Input2, string attributeNameQuery, string attributeNameQuery2, string TableName, string attributeNameOutput)
        {
            int attributeValue = -1; // Default value indicating attribute not found

            using (SQLiteConnection connection = new SQLiteConnection(Connection()))
            {
                connection.Open();
                // Use a parameterized query to prevent SQL injection
                string sqlQuery = $"SELECT {attributeNameOutput} FROM {TableName}  WHERE {attributeNameQuery} = @{attributeNameQuery} AND {attributeNameQuery2} = @{attributeNameQuery2}";

                using (SQLiteCommand command = new SQLiteCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue($"@{attributeNameQuery}", Input);
                    command.Parameters.AddWithValue($"@{attributeNameQuery2}", Input2);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Check if the attribute was found
                            attributeValue = reader.GetInt32(0);
                        }
                    }
                }
                connection.Close();
            }
            return attributeValue;
        }

        //This method is a general subroutine,to get a list of int from the database,
        //which has two parameters than the output data needs to meet.
        public static List<int> multipleIntFromDBMC(string Input, string Input2, string attributeNameQuery, string attributeNameQuery2, string TableName, string attributeNameOutput)
        {
            List<int> attributeValues = new List<int>();
            using (SQLiteConnection connection = new SQLiteConnection(Connection()))
            {
                connection.Open();

                // Use a parameterized query to prevent SQL injection
                string sqlQuery = $"SELECT {attributeNameOutput} FROM {TableName}  WHERE {attributeNameQuery} = @{attributeNameQuery} AND {attributeNameQuery2} = @{attributeNameQuery2}";

                using (SQLiteCommand command = new SQLiteCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue($"@{attributeNameQuery}", Input);
                    command.Parameters.AddWithValue($"@{attributeNameQuery2}", Input2);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Read and add each attribute value to the collection
                            int attributeValue = reader.GetInt32(0);
                            attributeValues.Add(attributeValue);
                        }
                    }
                }
                connection.Close();
            }
            return attributeValues;
        }
    }
}
