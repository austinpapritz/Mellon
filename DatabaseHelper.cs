using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public static class DatabaseHelper
    {
        public static void SetUpDatabase()
        {
            using (var command = new SQLiteCommand(DatabaseManager.Instance.Connection))
            {
                command.CommandText = @"
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nickname TEXT NOT NULL UNIQUE,
                    Salt BLOB NOT NULL,
                    HashedMasterPassword BLOB NOT NULL
                );
                CREATE TABLE IF NOT EXISTS SavedCredentials (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserId INTEGER NOT NULL,
                    Website TEXT NOT NULL,
                    Username TEXT NOT NULL,
                    Password TEXT NOT NULL,
                    FOREIGN KEY (UserId) REFERENCES Users (Id)
                );";
                command.ExecuteNonQuery();
            }
        }

        public static (byte[]? hashedMasterPassword, byte[]? salt) GetStoredHashedMasterPassword(string nickname)
        {
            using (var connection = new SQLiteConnection("Data Source=users.db"))
            {
                connection.Open();

                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = "SELECT HashedMasterPassword, Salt FROM Users WHERE Nickname = @Nickname";
                    command.Parameters.AddWithValue("@Nickname", nickname);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            byte[] hashedMasterPassword = (byte[])reader["HashedMasterPassword"];
                            byte[] salt = (byte[])reader["Salt"];

                            return (hashedMasterPassword, salt);
                        }
                        else
                        {
                            return (null, null);
                        }
                    }
                }
            }
        }
        public static void SaveCredential(int userId, string website, string username, string password, byte[] encryptionKey)
        {
            using (var connection = new SQLiteConnection("Data Source=users.db"))
            {
                connection.Open();

                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"
            INSERT INTO SavedCredentials (UserId, Website, Username, Password)
            VALUES (@UserId, @Website, @Username, @Password)
            ";
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@Website", website);

                    // Encrypt the username and password using the encryptionKey
                    string encUsername = EncryptionHelper.Encrypt(username, encryptionKey);
                    string encPassword = EncryptionHelper.Encrypt(password, encryptionKey);


                    command.Parameters.AddWithValue("@Username", encUsername);
                    command.Parameters.AddWithValue("@Password", encPassword);

                    command.ExecuteNonQuery();
                }
            }
        }



        public static List<(string? website, string username, string password)> GetSavedCredentials(int userId, byte[] encryptionKey)
        {
            List<(string? website, string username, string password)> savedCredentials = new List<(string? website, string username, string password)>();

            using (var connection = new SQLiteConnection("Data Source=users.db"))
            {
                connection.Open();

                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = "SELECT Website, Username, Password FROM SavedCredentials WHERE UserId = @UserId";
                    command.Parameters.AddWithValue("@UserId", userId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string website = (string)reader["Website"];
                            string encryptedUsername = (string)reader["Username"];
                            string encryptedPassword = (string)reader["Password"];


                            // Decrypt the username and password using the encryptionKey
                            if (!string.IsNullOrEmpty(encryptedUsername) && !string.IsNullOrEmpty(encryptedPassword))
                            {
                                string username = EncryptionHelper.Decrypt(encryptedUsername, encryptionKey);
                                string password = EncryptionHelper.Decrypt(encryptedPassword, encryptionKey);


                                savedCredentials.Add((website, username, password));
                            }
                        }
                    }
                }
            }

            return savedCredentials;
        }


        public static int GetUserId(string nickname)
        {
            using (var connection = new SQLiteConnection("Data Source=users.db"))
            {
                connection.Open();

                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = "SELECT Id FROM Users WHERE Nickname = @Nickname";
                    command.Parameters.AddWithValue("@Nickname", nickname);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetInt32(0);
                        }
                    }
                }
            }

            return 0;
        }

    }
}