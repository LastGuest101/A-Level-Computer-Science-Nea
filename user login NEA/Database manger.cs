using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


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


        public static bool AuthenticateUser(string username, string password)
        {
            using (SQLiteConnection connection = new SQLiteConnection(Connection()))
            {
                string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
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
                string sqlQuery = $"SELECT {attributeNameOutput} FROM {TableName} WHERE {attributeNameQuery} = @{attributeNameQuery}";

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

            using (SQLiteConnection connection = new SQLiteConnection(Connection()))
            {
                connection.Open();

                string sqlQuery = $"SELECT {attributeNameOutput} FROM {TableName} WHERE {attributeNameQuery} = @{attributeNameQuery}";

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





    }

   



}

    

