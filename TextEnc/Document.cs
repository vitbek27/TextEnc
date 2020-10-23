using FontAwesome.Sharp;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TextEnc
{
    public partial class Document : Form
    {
        public string username { get; set; }
        public string doc { get; set; }
        public string docName { get; set; }

        private bool encrypted = false;

        public Document()
        {
            InitializeComponent();

            openFileDialog1.Filter = "txt files (*.txt)|*.txt";

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // ToolTip отображается независимо от того, активна ли форма.
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.ibOpenNew, "Открыть файл");
            toolTip1.SetToolTip(this.ibOpen, "Открыть");
            toolTip1.SetToolTip(this.ibSave, "Сохранить");
            toolTip1.SetToolTip(this.ibErase, "Очистить");
            toolTip1.SetToolTip(this.ibCrypt, "Преобразовать");
            toolTip1.SetToolTip(this.ibDelete, "Удалить");
        }

        private void ibOpen_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            SQLiteCommand command = new SQLiteCommand($"SELECT docname FROM {username}", db.getConnection());

            DataTable table = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count <= 0)
            {
                MessageBox.Show("Документы не найдены");
                return;
            }

            DialogResult dr = new DialogResult();

            OpenDoc openDoc = new OpenDoc();
            openDoc.username = username;

            dr = openDoc.ShowDialog();
            if (dr == DialogResult.OK)
            {
                tbText.Clear();
                if (openDoc.doc != "")
                {
                    doc = openDoc.doc;
                    tbText.Text = doc;
                    docName = openDoc.docName;

                    encrypted = true;
                    ibCrypt.IconChar = IconChar.Lock;
                }
                else MessageBox.Show("Документ пуст");
            }
        }
        private void ibOpenNew_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DB db = new DB();

                SQLiteDataAdapter adapter = new SQLiteDataAdapter();

                DataTable table = new DataTable();

                SQLiteCommand command = new SQLiteCommand($"SELECT * FROM {username} WHERE docname = @dN", db.getConnection());
                command.Parameters.AddWithValue("@dN",
                    Path.GetFileNameWithoutExtension(openFileDialog1.FileName)).Size = 50;

                adapter.SelectCommand = command;
                try { adapter.Fill(table); }
                catch { MessageBox.Show("Ошибка"); return; }

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Документ с таким именем уже существует"); return;
                }

                tbText.Clear();
                tbText.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.Default);
                docName = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                
                encrypted = false;
                ibCrypt.IconChar = IconChar.Unlock;
            }
        }

        private void ibDelete_Click(object sender, EventArgs e)
        {
            if (tbText.Text == "") return;

            DialogResult dialogResult = MessageBox.Show($"Вы уверены, что хотите удалить документ {docName}?", "Удаление документа", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;

            DB db = new DB();

            SQLiteCommand command = new SQLiteCommand($"DELETE FROM {username} WHERE docname = @uD", db.getConnection());
            command.Parameters.AddWithValue("@uD", docName).Size = 50;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Документ успешно удален");

                doc = "";
                docName = "";
                tbText.Text = "";
                encrypted = false;
                ibCrypt.IconChar = IconChar.Unlock;
            }
            else MessageBox.Show("Произошла ошибка при удалении");

            db.closeConnection();
        }

        private void ibSave_Click(object sender, EventArgs e)
        {
            if (tbText.Text == "") return;

            DB db = new DB();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter();

            DataTable table = new DataTable();

            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM {username} WHERE docname = @dN", db.getConnection());
            command.Parameters.AddWithValue("@dN", docName).Size = 50;

            adapter.SelectCommand = command;
            try { adapter.Fill(table); }
            catch { MessageBox.Show("Ошибка"); return; }

            if (table.Rows.Count > 0)
            {
                //проверяем, есть ли такое же имя; имя должно быть уникальным
                SQLiteCommand command1 = new SQLiteCommand($"SELECT doc FROM {username} WHERE docName = @dN", db.getConnection());
                command1.Parameters.AddWithValue("@dN", docName).Size = 50;

                db.openConnection();

                try
                {
                    var result = command1.ExecuteScalar();
                    if (Convert.ToString(result) == tbText.Text)
                    {
                        db.closeConnection();
                        //MessageBox.Show("проверка");
                        return;
                    }
                }
                catch { MessageBox.Show("Ошибка"); return; }

                if (!encrypted)
                {
                    MessageBox.Show("Зашифруйте текст перед сохранением");
                    return;
                }

                SQLiteCommand command2 = new SQLiteCommand($"UPDATE {username} SET doc=@doc WHERE docname = @dN", db.getConnection());
                command2.Parameters.AddWithValue("@doc", tbText.Text);
                command2.Parameters.AddWithValue("@dN", docName).Size = 50;


                if (command2.ExecuteNonQuery() == 1)
                {
                    db.closeConnection();
                    MessageBox.Show("Документ сохранен");
                    return;
                }
            }
            else
            {
                if (!encrypted)
                {
                    MessageBox.Show("Зашифруйте текст перед сохранением");
                    return;
                }

                SQLiteCommand command2 = new SQLiteCommand($"INSERT INTO {username} (doc, docname) VALUES (@doc, @dN)", db.getConnection());

                command2.Parameters.AddWithValue("@doc", tbText.Text);
                command2.Parameters.AddWithValue("@dN", docName).Size = 50;

                db.openConnection();

                if (command2.ExecuteNonQuery() == 1)
                {
                    db.closeConnection();
                    MessageBox.Show("Документ сохранен");
                    return;
                }
            }
        }

        private void Document_Load(object sender, EventArgs e)
        {
            Info info = new Info();

            if (info.textsCounter(username) == "0") tbText.Clear();
        }

        private void ibCrypt_Click_1(object sender, EventArgs e)
        {
            if (tbText.Text == "") { MessageBox.Show("Нет текста для преобразования"); return; }

            tbText.ReadOnly = false;

            Crypt crypt = new Crypt();

            tbText.Text = crypt.CryptStr(tbText.Text, crypt.GetKey(username));

            tbText.ReadOnly = true;

            encrypted = (!encrypted) ? true : false;
            ibCrypt.IconChar = (!encrypted) ? IconChar.Unlock : IconChar.Lock;
        }

        public void Erase()
        {
            tbText.Clear();
        }

        private void ibErase_Click(object sender, EventArgs e)
        {
            if (tbText.Text == "") return;

            DialogResult dialogResult = MessageBox.Show("Очистить текстовое поле?", "Очистка текста", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;

            Erase();
        }
    }
}
