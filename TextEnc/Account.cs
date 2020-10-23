using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TextEnc
{
    public partial class Account : Form
    {
        public string username { get; set; }
        public Account()
        {
            InitializeComponent();
        }

        private void lChangePass_Click(object sender, EventArgs e)
        {
            PassChange passChange = new PassChange();
            passChange.username = username;

            passChange.Show();
        }

        private void lDeleteAcc_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить аккаунт?", "Удаление аккаунта", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;

            DB db = new DB();

            SQLiteCommand command = new SQLiteCommand("DELETE FROM users WHERE login = @login", db.getConnection());
            command.Parameters.AddWithValue("@login", username).Size = 50;

            SQLiteCommand command2 = new SQLiteCommand($"DROP TABLE {username}", db.getConnection());

            db.openConnection();

            command2.ExecuteNonQuery();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно удален");
                Login login = new Login();
                this.Hide();
                login.Show();
            }

            else MessageBox.Show("Произошла ошибка при удалении");

            db.closeConnection();

            this.Close();
        }

        private void lGenKey_Click(object sender, EventArgs e)
        {
            Crypt crypt = new Crypt();
            crypt.BDGenerateKey(username);

            Document document = new Document();
        }
    }
}
