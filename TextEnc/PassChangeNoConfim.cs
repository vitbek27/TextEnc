using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TextEnc
{
    public partial class PassChangeNoConfim : Form
    {
        public string username { get; set; }
        public PassChangeNoConfim()
        {
            InitializeComponent();
        }

        private void PassChangeNoConfim_Load(object sender, EventArgs e)
        {
            lUs.Text = username;
        }
        private void ResetFields()
        {

            tbNewPass.PasswordChar = ' ';
            tbConfirmPass.PasswordChar = ' ';


            tbNewPass.Text = "Новый пароль";
            tbConfirmPass.Text = "Подтвердите пароль";
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tbNewPass_Click_1(object sender, EventArgs e)
        {
            tbNewPass.Clear();
            tbNewPass.PasswordChar = '*';
        }

        private void tbConfirmPass_Click_1(object sender, EventArgs e)
        {
            tbConfirmPass.Clear();
            tbConfirmPass.PasswordChar = '*';
        }

        private void bChange_Click(object sender, EventArgs e)
        {
            string password1 = tbNewPass.Text;
            string password2 = tbConfirmPass.Text;

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
    }
}
