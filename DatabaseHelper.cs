using System.Data.SQLite;
using System.IO;


namespace WinFormsApp1
{
    public static class DatabaseHelper
    {
        public static void SetUpDatabase()
        {
            using (var connection = new SQLiteConnection("Data Source=users.db"))
            {
                connection.Open();

                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"
            CREATE TABLE IF NOT EXISTS Users (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Nickname TEXT NOT NULL UNIQUE,
                EncryptedMasterPassword BLOB NOT NULL
            );";
                    command.ExecuteNonQuery();
                }
            }
        }

        public static byte[] GetStoredEncryptedMasterPassword(string nickname)
        {
            byte[] encryptedMasterPassword = null;

            using (var connection = new SQLiteConnection("Data Source=PasswordManager.db;Version=3;"))
            {
                connection.Open();

                string selectQuery = "SELECT EncryptedMasterPassword FROM Users WHERE Nickname = @Nickname";
                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Nickname", nickname);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            encryptedMasterPassword = (byte[])reader["EncryptedMasterPassword"];
                        }
                    }
                }
            }

            return encryptedMasterPassword;
        }



    }
}
