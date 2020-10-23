using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TextEnc
{
    public partial class Accounts : Form
    {
        private List<string> users = new List<string>();
        public Accounts()
        {
            InitializeComponent();

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // // ToolTip отображается независимо от того, активна ли форма.
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.ibAdd, "Добавить");
            toolTip1.SetToolTip(this.ibInfo, "Получить сведения");
            toolTip1.SetToolTip(this.ibNewPass, "Сменить пароль");
            toolTip1.SetToolTip(this.ibGenKey, "Сгенерировать ключ");
            toolTip1.SetToolTip(this.ibOpen, "Войти");
            toolTip1.SetToolTip(this.ibDelete, "Удалить");
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            SetUsers();
        }

        private protected void SetUsers()
        {
            DB db = new DB();

            SQLiteCommand command = new SQLiteCommand($"SELECT login FROM users WHERE NOT login = @uL", db.getConnection());
            command.Parameters.AddWithValue("@uL", "admin").Size = 50;

            db.openConnection();

            var rd = command.ExecuteReader();

            users.Clear();
            while (rd.Read())
            {
                users.Add(rd["login"].ToString());
            }

            db.closeConnection();

            lbUsers.Items.Clear();
           lbUsers.Items.AddRange(users.ToArray());
        }


        private void ibAdd_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();

            AddUser addUser = new AddUser();

            dr = addUser.ShowDialog();

            if (dr == DialogResult.OK) SetUsers();
        }

        private void ibInfo_Click(object sender, EventArgs e)
        {
            if (lbUsers.SelectedItem == null) return;
            Info info = new Info();
            info.username = Convert.ToString(lbUsers.SelectedItem);
            info.Show();
        }

        private void ibEdit_Click(object sender, EventArgs e)
        {
            if (lbUsers.SelectedItem == null) return;

            PassChangeNoConfim passChangeNoConfim = new PassChangeNoConfim();
            passChangeNoConfim.username = Convert.ToString(lbUsers.SelectedItem);

            DialogResult dr = new DialogResult();
            
            dr = passChangeNoConfim.ShowDialog();

            if (dr == DialogResult.OK) SetUsers();
        }

        private void ibDelete_Click(object sender, EventArgs e)
        {
            if (lbUsers.SelectedItem == null) return;
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить аккаунт?", "Удаление аккаунта", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;

            DB db = new DB();

            SQLiteCommand command = new SQLiteCommand("DELETE FROM users WHERE login = @login", db.getConnection());
            SQLiteCommand command2 = new SQLiteCommand($"DROP TABLE {Convert.ToString(lbUsers.SelectedItem)}", db.getConnection());

            command.Parameters.AddWithValue("@login", lbUsers.SelectedItem.ToString()).Size = 50;

            db.openConnection();

            command2.ExecuteNonQuery();

            if (command.ExecuteNonQuery() == 1)
            {
                SetUsers();
                MessageBox.Show("Аккаунт успешно удален");
            }

            else MessageBox.Show("Произошла ошибка при удалении");

            db.closeConnection();

            SetUsers();
        }

        private void ibGenKey_Click(object sender, EventArgs e)
        {
            if (lbUsers.SelectedItem == null) return;

            Crypt crypt = new Crypt();
            crypt.BDGenerateKey(lbUsers.SelectedItem.ToString());

            SetUsers();
        }

        private void ibOpen_Click_1(object sender, EventArgs e)
        {
            if (lbUsers.SelectedItem == null) return;

            TextEncrypter textEncrypter = new TextEncrypter();
            textEncrypter.username = Convert.ToString(lbUsers.SelectedItem);
            textEncrypter.admin = true;
            textEncrypter.Show();
            this.Hide();
        }
    }
}
