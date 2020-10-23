using System.Data.SQLite;
using System.Windows.Forms;

namespace TextEnc
{
    class FirstOpen
    {
        private protected void CreateAdminIfNotExit()
        {
            DB db = new DB();

            SQLiteCommand command = new SQLiteCommand($"SELECT admin FROM users", db.getConnection());

            db.openConnection();

            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                SQLiteCommand command1 = new SQLiteCommand("INSERT INTO users(login, password, cryptokey) VALUES(@login, @password, @cryptokey)", db.getConnection());

                //для генерации ключа
                Crypt crypt = new Crypt();
                string key = crypt.GenerateKey();

                command1.Parameters.AddWithValue("@login", "admin").Size = 50;
                command1.Parameters.AddWithValue("@password", "admin").Size = 50;
                command1.Parameters.AddWithValue("@cryptokey", key).Size = crypt.keyLength;

                db.openConnection();

                try
                {
                    command1.ExecuteNonQuery();
                }                    
                catch
                {
                    //MessageBox.Show("Произошла ошибка");
                } 
            }
            db.closeConnection();
        }

        public void CreateUsersIfNotExit()
        {
            DB db = new DB();

            SQLiteCommand command = new SQLiteCommand("create table if not exists users(id INTEGER NOT NULL UNIQUE, login TEXT NOT NULL UNIQUE, password  TEXT NOT NULL, cryptokey TEXT NOT NULL, PRIMARY KEY(id AUTOINCREMENT))", db.getConnection());

            db.openConnection();
            try
            {
                command.ExecuteNonQuery();
                CreateAdminIfNotExit();
            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
            }
            db.closeConnection();
        }
    }
}
