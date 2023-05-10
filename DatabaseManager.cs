using System.Data.SQLite;

namespace WinFormsApp1
{
    public class DatabaseManager
    {
        private static DatabaseManager? _instance;
        private SQLiteConnection _connection = new SQLiteConnection();

        public static DatabaseManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DatabaseManager();
                }
                return _instance;
            }
        }

        public SQLiteConnection Connection
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

        private DatabaseManager() { }
    }
}
