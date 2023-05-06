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


    }
}
