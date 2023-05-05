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
            EncryptedMasterPassword BLOB NOT NULL
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
                    command.CommandText = "SELECT EncryptedMasterPassword FROM Users WHERE Nickname = @Nickname";
                    command.Parameters.AddWithValue("@Nickname", nickname);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            byte[] hashedMasterPasswordWithSalt = (byte[])reader["HashedMasterPassword"];
                            byte[] salt = new byte[16];
                            byte[] hashedMasterPassword = new byte[hashedMasterPasswordWithSalt.Length - 16];

                            Buffer.BlockCopy(hashedMasterPasswordWithSalt, 0, salt, 0, 16);
                            Buffer.BlockCopy(hashedMasterPasswordWithSalt, 16, hashedMasterPassword, 0, hashedMasterPassword.Length);

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
