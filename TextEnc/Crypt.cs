using System;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace TextEnc
{
    class Crypt
    {
        public int keyLength = 20;
        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        public string GetKey(string username)
        {
            string key = "";

            DB db = new DB();

            SQLiteCommand command = new SQLiteCommand("SELECT cryptokey FROM users WHERE login = @uL", db.getConnection());
            command.Parameters.AddWithValue("@uL", username).Size = 50;

            db.openConnection();

            try
            {
                var result = command.ExecuteScalar();
                key = Convert.ToString(result);
            }
            catch { MessageBox.Show("Ошибка при получении ключа"); }

            db.closeConnection();

            return key;
        }


        public void BDGenerateKey(string username)
        {
            DialogResult dialogResult1 = MessageBox.Show("При генерации нового ключа необходимо сменить пароль. Все документы будут удалены.\nВы уверены, что хотите сгенерировать новый ключ?", "Генерация ключа", MessageBoxButtons.YesNo);
            if (dialogResult1 == DialogResult.No) return;

            Crypt crypt = new Crypt();
            string key = crypt.GenerateKey();

            DB db = new DB();

            SQLiteCommand command = new SQLiteCommand("SELECT password FROM users WHERE login = @uL", db.getConnection());
            command.Parameters.AddWithValue("@uL", username).Size = 50;

            SQLiteCommand command1 = new SQLiteCommand($"UPDATE users SET cryptokey=@uK WHERE login = @uL", db.getConnection());
            command1.Parameters.AddWithValue("@uK", key).Size = crypt.keyLength;
            command1.Parameters.AddWithValue("@uL", username).Size = 50;

            SQLiteCommand command2 = new SQLiteCommand($"DELETE FROM {username}", db.getConnection());

            db.openConnection();

            string result = command.ExecuteScalar().ToString();

            command2.ExecuteNonQuery();

            if (command1.ExecuteNonQuery() == 1)
            {
                MessageBox.Show($"Новый ключ для пользователя {username} успешно сгенерирован");
            }

            else MessageBox.Show("Произошла ошибка при генерации ключа");

            db.closeConnection();

            PassChangeNoConfim passChangeNoConfim = new PassChangeNoConfim();
            passChangeNoConfim.username = username;

            DialogResult dr = new DialogResult();

            db.openConnection();

            while (dr != DialogResult.OK || command.ExecuteScalar().ToString() == result) dr = passChangeNoConfim.ShowDialog();

            db.closeConnection();
        }

        public string GenerateKey()
        {
            string key = "";

            Random rand = new Random();
            int i = 1;

            for (int j = 0; j < keyLength; j++)
            {
                do { key += rand.Next(2); i++; }
                while (i % 8 != 1);
                if (j != keyLength) key += " ";
            }
            key = key.Remove(key.Length - 1);

            return key;
        }



        public string CryptStr(string text, string key)
        {
            byte[] byteText = Encoding.Unicode.GetBytes(text);

            string[] binText = byteText.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')).ToArray();

            string[] keys = key.Split(' ');

            if (binText.Length < keys.Length)
            {
                string[] keysNew = keys;
                for (int i = 0; i < binText.Length; i++) keysNew[i] = keys[i];
                keys = keysNew;
            }

            else if (keys.Length < binText.Length)
            {
                string[] keysNew = new string[binText.Length];

                int i = 0;
                for (; i < keys.Length; i++) keysNew[i] = keys[i];

                int j = 0;

                do
                {
                    if (j == keys.Length) j = 0;
                    keysNew[i] = keys[j];
                    j++; i++;
                } while (i < binText.Length);
                keys = keysNew;
            }

            //XOR-шифрование
            string one = "1";
            string zero = "0"; // чтобы избежать ошибки при сравнении

            string[] binCrypText = new string[keys.Length];

            for (int i = 0; i < keys.Length; i++)
            {
                string st1 = binText[i];
                string st2 = keys[i];
                string cT = "";
                for (int j = 0; j < 8; j++)
                {
                    if ((Convert.ToString(st1[j]) == one && Convert.ToString(st2[j]) == zero)
                        || (Convert.ToString(st1[j]) == zero && Convert.ToString(st2[j]) == one))
                        cT += "1";
                    else cT += "0";
                }
                binCrypText[i] = cT;
            }
            // конец шифрования

            byte[] byteCrypText = binCrypText.Select(x => Convert.ToByte(x, 2)).ToArray();

            return Encoding.Unicode.GetString(byteCrypText);
        }
    }
}
