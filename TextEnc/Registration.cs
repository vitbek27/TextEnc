using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TextEnc
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void bRegister_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            string login = tbLogin.Text;
            string password = tbPassword.Text;

            if (login == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (password == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            if (isUserExists())
            {
                MessageBox.Show("Пользователь с таким логином уже существует, введите другой.");
                return;
            }

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

            if (command.ExecuteNonQuery() == 1)
            {
                command2.ExecuteNonQuery();
                MessageBox.Show("Аккаунт успешно создан");
            }
            else
                MessageBox.Show("Произошла ошибка");

            db.closeConnection();

            this.Hide();

            if (login == "admin")
            {
                Admin admin = new Admin();
                admin.Show();
                return;
            }

            TextEncrypter textEncrypter = new TextEncrypter();
            textEncrypter.username = login;
            if (login != "admin") textEncrypter.admin = false;

            textEncrypter.Show();
        }

        private protected bool isUserExists()
        {
            string login = tbLogin.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter();

            SQLiteCommand command = new SQLiteCommand("SELECT * FROM users WHERE login = @uL", db.getConnection());
            command.Parameters.AddWithValue("@uL", login).Size = 50;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0 || login == "users")
            {
                return true;
            }

            else
                return false;
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
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
