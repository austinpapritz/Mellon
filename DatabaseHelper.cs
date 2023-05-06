using System.Data.SQLite;

namespace WinFormsApp1
{
    public static class DatabaseHelper
    {
        public static void SetUpDatabase()
        {
            using (var command = new SQLiteCommand(DatabaseManager.Connection))
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

        public static (byte[] hashedMasterPassword, byte[] salt) GetStoredHashedMasterPassword(string nickname)
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
        public static void SaveCredential(int userId, string website, string username, string password)
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
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    command.ExecuteNonQuery();
                }
            }
        }


        public static List<(string website, string username, string password)> GetSavedCredentials(int userId)
        {
            List<(string website, string username, string password)> savedCredentials = new List<(string website, string username, string password)>();

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
                            string website = reader["Website"].ToString();
                            string username = reader["Username"].ToString();
                            string password = reader["Password"].ToString();

                            savedCredentials.Add((website, username, password));
                        }
                    }
                }
            }

            return savedCredentials;
        }
    }
}