using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TextEnc
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }


        private void bAdd_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string password = tbPassword.Text;
            {
                if (login == "" || login == "Логин")
                {
                    MessageBox.Show("Введите логин");
                    return;
                }

                if (password == "" || password == "Пароль")
                {
                    MessageBox.Show("Введите пароль");
                    return;
                }

                if (isUserExists()) return;

                DB db = new DB();

                SQLiteCommand command = new SQLiteCommand("INSERT INTO users(login, password, cryptokey) VALUES(@login, @password, @cryptokey)", db.getConnection());

                //для шифрования пароля
                Crypt crypt = new Crypt();
                string key = crypt.GenerateKey();
                string hash = crypt.GetHash(password);

                command.Parameters.AddWithValue("@login", login).Size = 50;
                command.Parameters.AddWithValue("@password", crypt.CryptStr(hash, key)).Size = 50;
                command.Parameters.AddWithValue("@cryptokey", key).Size = crypt.keyLength;

                SQLiteCommand command2 = new SQLiteCommand($"CREATE TABLE {login} (docname nvarchar(50) NOT NULL, doc ntext NOT NULL);", db.getConnection());

                db.openConnection();

                command2.ExecuteNonQuery();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Аккаунт успешно создан");
                else
                    MessageBox.Show("Произошла ошибка");

                db.closeConnection();

                this.Hide();
            }
        }

        private bool isUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter();

            SQLiteCommand command = new SQLiteCommand("SELECT * FROM users WHERE login = @uL", db.getConnection());
            command.Parameters.AddWithValue("@uL", tbLogin.Text).Size = 50;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0 || tbLogin.Text == "users")
            {
                MessageBox.Show("Пользователь с таким логином уже существует, введите другой.");
                return true;
            }

            else
                return false;
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tbLogin_Click(object sender, EventArgs e)
        {
            tbLogin.Clear();
        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            tbPassword.Clear();
            tbPassword.PasswordChar = '*';
        }
    }
}
