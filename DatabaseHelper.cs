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

        public static (byte[] encryptedMasterPassword, byte[] salt) GetStoredEncryptedMasterPassword(string nickname)
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
                            byte[] encryptedMasterPasswordWithSalt = (byte[])reader["EncryptedMasterPassword"];
                            byte[] salt = new byte[16];
                            byte[] encryptedMasterPassword = new byte[encryptedMasterPasswordWithSalt.Length - 16];

                            Buffer.BlockCopy(encryptedMasterPasswordWithSalt, 0, salt, 0, 16);
                            Buffer.BlockCopy(encryptedMasterPasswordWithSalt, 16, encryptedMasterPassword, 0, encryptedMasterPassword.Length);

                            return (encryptedMasterPassword, salt);
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
