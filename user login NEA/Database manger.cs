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

            string path = @"C:\Users\olive\OneDrive - Bradford Grammar School\user login NEA";
            string databaseName = "DATABASE.db";
            connectionString = $"Data Source={System.IO.Path.Combine(path, databaseName)};Version=3;";

            return connectionString;
        }


        static void InsertData(string connectionString, string FirstName, string LastName)
        {
            // INSERT query
            string insertQuery = $"INSERT INTO Players (FirstName, LastName) VALUES ('{FirstName}', '{LastName}');";
            // Create a new SQLite connection
            using (SQLiteConnection connection = new (connectionString))
            {
                // Open the connection
                connection.Open();

                // Create a command with the query and connection
                using (SQLiteCommand command = new (insertQuery, connection))
                {
                    // Execute the query
                    command.ExecuteNonQuery();
                }
            }
        }

        static void InsertData_Users(string connectionString, string Username, string Password, string Email)
        {
            string value = "1";
            // INSERT query
            string insertQuery = $"INSERT INTO Users (Username, player_id, Password, Email) VALUES ('{Username}','{value}', '{Password}', '{Email}');";
            // Create a new SQLite connection
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Create a command with the query and connection
                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    // Execute the query
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void InsertGame(string match_id, string player_id, string game1, string game2, string game3)
        {
            // INSERT query
            string insertQuery = $"INSERT INTO Games (match_id, player_id, game1, game2, game3) VALUES ('{match_id}','{player_id}', '{game1}', '{game2}, '{game3}');";
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
                }
            }
        }

        public static void InsertPlayers(string firstname, string lastname)
        {
            
            string insertQuery = $"INSERT INTO Players (FirstName, LastName) VALUES ('{firstname}','{lastname}');";

            using (SQLiteConnection connection = new (Connection()))
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

        public static void InsertHandicap(string league_id, string player_id)
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

        public static void InsertPlayerIntoTeam(string player_id, string team_id)
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
            using (SQLiteConnection connection = new (Connection()))
            {
                string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";

                using (SQLiteCommand command = new (query, connection))
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
        public static int singleIntFromDB(string Input, string attributeNameQuery,  string TableName, string attributeNameOutput)
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

            using (SQLiteConnection connection = new (Connection()))
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

        public static int singleIntFromDBMC(string Input,string Input2, string attributeNameQuery, string attributeNameQuery2, string TableName, string attributeNameOutput) // Retrieves a single int value from the database, and queries from 2 columns.
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

    

