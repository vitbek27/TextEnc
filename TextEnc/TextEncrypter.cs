using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TextEnc
{
    public partial class TextEncrypter : Form
    {
        public string username { get; set; }
        public bool admin { get; set; }

        private IconButton currentBtn;
        //private Form currentChildForm;

        Document documents = new Document();
        
        
        public TextEncrypter()
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

        private void pToolBox_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ibDocs_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            documents.username = username;

            Info info = new Info();
            if (info.textsCounter(username) == "0") documents.Erase();

            OpenChildForm(documents);
        }

        private void ibAccount_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Account account = new Account();
            account.username = username;
            OpenChildForm(account);
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите выйти?", "Выход", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;

            Application.Exit();
        }

        private void ibExit_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите выйти?", "Смена аккаунта", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;

            if (admin)
            {
                this.Hide();
                Admin admin = new Admin();
                admin.Show();
                return;
            }
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
