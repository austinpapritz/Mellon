using System.Data.SQLite;

namespace WinFormsApp1
{
    public class DatabaseManager
    {
        private static SQLiteConnection _connection;

        public static SQLiteConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new SQLiteConnection("Data Source=users.db");
                    _connection.Open();
                }
                return _connection;
            }
        }
    }
}
