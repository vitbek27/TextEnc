using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TextEnc
{
    public partial class OpenDoc : Form
    {
        private List<string> docs = new List<string>();
        public string username { get; set; }
        public string doc { get; set; }
        public string docName { get; set; }
        public OpenDoc()
        {
            InitializeComponent();
        }

        private void OpenDoc_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            SQLiteCommand command = new SQLiteCommand($"SELECT docname FROM {username}", db.getConnection());

            db.openConnection();

            var rd = command.ExecuteReader();

            while (rd.Read()) docs.Add(rd["docname"].ToString());

            db.closeConnection();

            lbDocs.Items.AddRange(docs.ToArray());
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bOpen_Click(object sender, EventArgs e)
        {
            if (lbDocs.SelectedItem == null || Convert.ToString(lbDocs.SelectedItem) == "") return;

            DB db = new DB();

            SQLiteCommand command = new SQLiteCommand($"SELECT doc FROM {username} WHERE docName = @uDoc", db.getConnection());

            command.Parameters.AddWithValue("@uDoc", Convert.ToString(lbDocs.SelectedItem)).Size = 50;

            db.openConnection();

            try
            {
                var result = command.ExecuteScalar();
                doc = Convert.ToString(result);
                docName = Convert.ToString(lbDocs.SelectedItem);
            }
            catch { MessageBox.Show("Ошибка при получении документа"); }

            db.closeConnection();

            this.Hide();
        }
    }
}
