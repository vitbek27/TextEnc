using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TextEnc
{
    public partial class Info : Form
    {
        public string username { get; set; }
        public Info()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public string textsCounter(string username)
        {
            DB db = new DB();

            SQLiteCommand command = new SQLiteCommand($"SELECT COUNT(*) FROM {username}", db.getConnection());
            
            try
            {
                db.openConnection();

                var result = command.ExecuteScalar();

                db.closeConnection();
                return Convert.ToString(result);
            }
            catch
            {
                db.closeConnection(); 
                return "0";
            }
        }

        private void Info_Load(object sender, EventArgs e)
        {
            lLogin.Text = username;

            DB db = new DB();

            DataTable table = new DataTable();

            SQLiteCommand command = new SQLiteCommand("SELECT password FROM users WHERE login = @uL", db.getConnection());
            command.Parameters.AddWithValue("@uL", username).Size = 50;

            db.openConnection();

            try
            {
                var result = command.ExecuteScalar();
                lPassword.Text = Convert.ToString(result);

                lTexts.Text = textsCounter(username);
            }
            catch { MessageBox.Show("Документы не найдены"); }
            MessageBox.Show("Документы не найдены");

            db.closeConnection();

            return;
        }
    }
}
