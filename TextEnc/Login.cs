using System;
using System.Drawing;
using System.Windows.Forms;

namespace TextEnc
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            string loginUser = tbLogin.Text;
            string passwordUser = tbPassword.Text;

            FirstOpen firstOpen = new FirstOpen();
            firstOpen.CreateUsersIfNotExit();

            PassChange passChange = new PassChange();
            if (passChange.CheckPass(loginUser, passwordUser) == false)
            {
                MessageBox.Show("Ошибка в пароле или логине");
                return;
            }

            this.Hide();

            if (loginUser != "admin")
            {
                TextEncrypter textEncrypter = new TextEncrypter();
                textEncrypter.username = tbLogin.Text;
                textEncrypter.admin = false;
                textEncrypter.Show();
                return;
            }
            else
            {
                Admin admin = new Admin();
                this.Hide();
                admin.Show();
                return;
            }
        }


        private void bReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }
        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void lbExit_MouseEnter(object sender, EventArgs e)
        {
            lbExit.ForeColor = Color.FromArgb(247, 218, 131);
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
