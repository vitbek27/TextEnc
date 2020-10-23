using System.Data.SQLite;

namespace TextEnc
{
    class DB
    {
        SQLiteConnection connection = new SQLiteConnection(@"Data Source = TextEnc.db;Version=3;New=False;Compress=True;");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public SQLiteConnection getConnection()
        {
            return connection;
        }
    }
}
