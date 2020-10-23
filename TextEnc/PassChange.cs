using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TextEnc
{
    public partial class PassChange : Form
    {
        public string username { get; set; }
        public PassChange()
        {
            InitializeComponent();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ResetFields()
        {
            tbOldPass.PasswordChar = ' ';
            tbNewPass.PasswordChar = ' ';
            tbConfirmPass.PasswordChar = ' ';

            tbOldPass.Text = "Текущий пароль";
            tbNewPass.Text = "Новый пароль";
            tbConfirmPass.Text = "Подтвердите пароль";
        }

        public bool CheckPass(string login, string password)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter();

            SQLiteCommand command = new SQLiteCommand("SELECT * FROM users WHERE login = @uL", db.getConnection());
            command.Parameters.AddWithValue("@uL", login).Size = 50;

            adapter.SelectCommand = command;

            try { adapter.Fill(table); }
            catch { MessageBox.Show("Произошла ошибка"); return false; }

            if (table.Rows.Count > 0)
            {
                try
                {
                    if (login == "admin" && password == "admin" &&
                        table.Rows[0][2].ToString() == "admin" &&
                        table.Rows[0][1].ToString() == "admin")
                        return true;

                    if (table.Rows[0][2].ToString() == "admin")
                        return false;

                    string passDB = table.Rows[0][2].ToString(); //шифрованный хэш

                    Crypt crypt = new Crypt();
                    string hashDB = crypt.CryptStr(passDB, table.Rows[0][3].ToString()); //расшифрованный хэш

                    if (hashDB != crypt.GetHash(password))
                    {
                        return false;
                    }
                }

                catch
                {
                    db.closeConnection();
                    return false;
                }
            }
            else
            {
                db.closeConnection();
                return false;
            }
            db.closeConnection();
            return true;
        }

        private void bChangePass_Click(object sender, EventArgs e)
        {
            string password0 = tbOldPass.Text;
            string password1 = tbNewPass.Text;
            string password2 = tbConfirmPass.Text;

            if (password0 == "" || password0 == "Текущий пароль")
            {
                MessageBox.Show("Введите текущий пароль");
                ResetFields();
                return;
            }

            if (password1 == "" || password1 == "Новый пароль")
            {
                MessageBox.Show("Введите новый пароль");
                ResetFields();
                return;
            }
            if (password2 == "" || password2 == "Подтвердите пароль")
            {
                MessageBox.Show("Подтвердите пароль");
                ResetFields();
                return;
            }
            if (password1 != password2)
            {
                MessageBox.Show("Пароли не совпадают");
                ResetFields();
                return;
            }

            if (CheckPass(username, password0) == false)
            {
                MessageBox.Show("Ошибка при вводе текущего пароля");
                ResetFields();
                return;
            }

            DB db = new DB();

            //для шифрования пароля
            Crypt crypt = new Crypt();
            string key = crypt.GetKey(username);
            string hash = crypt.GetHash(password2);

            SQLiteCommand command = new SQLiteCommand($"UPDATE users SET password=@uP WHERE login = @uL", db.getConnection());
            command.Parameters.AddWithValue("@uP", crypt.CryptStr(hash, key)).Size = 50;
            command.Parameters.AddWithValue("@uL", username).Size = 50;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show($"Новый пароль для пользователя {username} был успешно создан");
                db.closeConnection();
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Произошла ошибка при записи пароля");
                ResetFields();
            }

            db.closeConnection();

            ResetFields();
            this.Hide();
        }

        private void tbOldPass_Click(object sender, EventArgs e)
        {
            tbOldPass.Clear();
            tbOldPass.PasswordChar = '*';
        }

        private void tbNewPass_Click(object sender, EventArgs e)
        {
            tbNewPass.Clear();
            tbNewPass.PasswordChar = '*';
        }

        private void tbConfirmPass_Click(object sender, EventArgs e)
        {
            tbConfirmPass.Clear();
            tbConfirmPass.PasswordChar = '*';
        }

        private void PassChange_Load(object sender, EventArgs e)
        {
            lUs.Text = username;
        }
    }
}
