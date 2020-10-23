using System;
using System.Windows.Forms;

namespace TextEnc
{
    public partial class AdminPass : Form
    {
        public AdminPass()
        {
            InitializeComponent();
        }

        private void lChangePass_Click(object sender, EventArgs e)
        {
            PassChange passChange = new PassChange();
            passChange.username = "admin";

            passChange.Show();
        }
    }
}
