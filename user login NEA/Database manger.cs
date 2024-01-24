using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace user_login_NEA
{
    public class Database_manager
    {


        // Connection string
        public static string Connection()
        {
            string connectionString;

            string path = @"C:\Users\olive\OneDrive\Documents\GitHub\A-Level-Computer-Science-Nea";
            string databaseName = "DATABASE.db";
            connectionString = $"Data Source={System.IO.Path.Combine(path, databaseName)};Version=3;";

            return connectionString;
        }


        public static void InsertUser(string Username, string Password, int Player_id)
        {

            string insertQuery = $"INSERT INTO Users (Username, Password, player_id) VALUES ('{Username}','{Password}' , '{Player_id}');";

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

        public static void InsertGame(string match_id, string player_id, string game1, string game2, string game3)
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

        public static void UpdatePoints(int Points, int team_id)
        {
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

        public static void UpdateHandicap(int Handicap, int handicap_id)
        {
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

        public static void UpdateTotalPinFall(int TotalPinFall, int handicap_id)
        {
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

        public static void InsertPlayers(string firstname, string lastname)
        {

            string insertQuery = $"INSERT INTO Players (FirstName, LastName) VALUES ('{firstname}','{lastname}');";

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

        public static void InsertHandicap(int league_id, int player_id)
        {

            string insertQuery = $"INSERT INTO LeagueStats (league_id, player_id, Handicap) VALUES ('{league_id}','{player_id}' , '0');";

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


        public static bool AuthenticateUserLoginIn(string username, string password)
        {
            using (SQLiteConnection connection = new(Connection()))
            {
                string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";

                using (SQLiteCommand command = new(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        return reader.Read();
                    }
                }
            }
        }
        public static int singleIntFromDB(string Input, string attributeNameQuery, string TableName, string attributeNameOutput)
        {
            int attributeValue = -1; // Default value indicating attribute not found

            using (SQLiteConnection connection = new SQLiteConnection(Connection()))
            {
                connection.Open();

                // Use a parameterized query to prevent SQL injection
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

        public static List<int> multipleIntFromDB(string Input, string attributeNameQuery, string TableName, string attributeNameOutput)
        {
            List<int> attributeValues = new List<int>(); // Collection to store multiple attribute values

            using (SQLiteConnection connection = new(Connection()))
            {
                connection.Open();

                string sqlQuery = $"SELECT {attributeNameOutput} FROM \"{TableName}\" WHERE {attributeNameQuery} = @{attributeNameQuery}";
                // when line 164 runs, it executes the literal of this string, so it was running "SELECT x FROM y/z" and slashes are special; i escaped that slash by enclosing it in quotes; you might wanna enclose the other column names in quotes too

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

        public static List<string> multipleStringFromDB(string Input, string attributeNameQuery, string TableName, string attributeNameOutput)
        {
            List<string> attributeValues = new List<string>(); // Collection to store multiple attribute strings

            using (SQLiteConnection connection = new SQLiteConnection(Connection()))
            {
                connection.Open();

                string sqlQuery = $"SELECT {attributeNameOutput} FROM \"{TableName}\" WHERE {attributeNameQuery} = @{attributeNameQuery}";
                // when line 164 runs, it executes the literal of this string, so it was running "SELECT x FROM y/z" and slashes are special; i escaped that slash by enclosing it in quotes; you might wanna enclose the other column names in quotes too

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

        public static List<string> columnStringFromDB(string TableName, string attributeNameOutput)
        {
            List<string> attributeValues = new List<string>(); // Collection to store multiple attribute strings

            using (SQLiteConnection connection = new SQLiteConnection(Connection()))
            {
                connection.Open();

                string sqlQuery = $"SELECT {attributeNameOutput} FROM \"{TableName}\" ";
                // when line 164 runs, it executes the literal of this string, so it was running "SELECT x FROM y/z" and slashes are special; i escaped that slash by enclosing it in quotes; you might wanna enclose the other column names in quotes too

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

        public static List<int> columnIntFromDB(string TableName, string attributeNameOutput)
        {
            List<int> attributeValues = new List<int>(); // Collection to store multiple attribute strings

            using (SQLiteConnection connection = new SQLiteConnection(Connection()))
            {
                connection.Open();

                string sqlQuery = $"SELECT {attributeNameOutput} FROM \"{TableName}\" ";
                // when line 164 runs, it executes the literal of this string, so it was running "SELECT x FROM y/z" and slashes are special; i escaped that slash by enclosing it in quotes; you might wanna enclose the other column names in quotes too

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

        public static List<int> AllGames(int player_id)
        {
            List<int> attributeValues = new List<int>();

            using (SQLiteConnection connection = new SQLiteConnection(Connection()))
            {
                connection.Open();

                string sqlQuery = $"SELECT game1, game2, game3 FROM Games WHERE player_id = @player_id";
                // when line 164 runs, it executes the literal of this string, so it was running "SELECT x FROM y/z" and slashes are special; i escaped that slash by enclosing it in quotes; you might wanna enclose the other column names in quotes too

                using (SQLiteCommand command = new SQLiteCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@player_id", player_id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Read and add each attribute value to the collection
                            int game1Value = reader.GetInt32(0);
                            int game2Value = reader.GetInt32(1);  // Assuming game2 is the second column
                            int game3Value = reader.GetInt32(2);  // Assuming game3 is the third column

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

        public static int singleIntFromDBMC(string Input, string Input2, string attributeNameQuery, string attributeNameQuery2, string TableName, string attributeNameOutput) // Retrieves a single int value from the database, and queries from 2 columns.
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


    }







}

    

