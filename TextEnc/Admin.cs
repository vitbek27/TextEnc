using FontAwesome.Sharp;
using System;
using System.Data.SQLite;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TextEnc
{
    public partial class Admin : Form
    {
        private IconButton currentBtn;
        public Admin()
        {
            InitializeComponent();

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(247, 218, 131);
                currentBtn.ForeColor = Color.FromArgb(56, 60, 89);
                currentBtn.IconColor = Color.FromArgb(56, 60, 89);
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(56, 60, 89);
                currentBtn.ForeColor = Color.WhiteSmoke;
                currentBtn.IconColor = Color.WhiteSmoke;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pDesktop.Controls.Add(childForm);
            pDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void pToolBox_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ibAccounts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Accounts accounts = new Accounts();
            OpenChildForm(accounts);
        }

        private void ibDocs_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AdminPass adminPass = new AdminPass();
            OpenChildForm(adminPass);
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            SQLiteCommand command = new SQLiteCommand("SELECT password FROM users WHERE login = @uL", db.getConnection());
            command.Parameters.AddWithValue("@uL", "admin").Size = 50;

            db.openConnection();

            string result = command.ExecuteScalar().ToString();

            if (result == "admin")
            {
                DialogResult dr = new DialogResult();

                PassChange passChange = new PassChange();
                passChange.username = "admin";

                while (dr != DialogResult.OK || command.ExecuteScalar().ToString() == "admin") dr = passChange.ShowDialog();
            }
            db.closeConnection();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите выйти?", "Выход", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;

            Application.Exit();
        }

        private void ibExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите выйти?", "Смена аккаунта", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;

            this.Hide();

            Login login = new Login();
            login.Show();
        }

        private void ibWinMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ibWin_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                ibWin.IconChar = IconChar.WindowRestore;

            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                ibWin.IconChar = IconChar.WindowMaximize;
            }
        }
    }
}
