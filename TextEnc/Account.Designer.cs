namespace TextEnc
{
    partial class Account
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lChangePass = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lGenerateKey = new System.Windows.Forms.Panel();
            this.lGenKey = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lDeleteAcc = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.lGenerateKey.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lChangePass);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 50);
            this.panel1.TabIndex = 0;
            // 
            // lChangePass
            // 
            this.lChangePass.AutoSize = true;
            this.lChangePass.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lChangePass.Location = new System.Drawing.Point(12, 19);
            this.lChangePass.Name = "lChangePass";
            this.lChangePass.Size = new System.Drawing.Size(120, 17);
            this.lChangePass.TabIndex = 1;
            this.lChangePass.Text = "Сменить пароль";
            this.lChangePass.Click += new System.EventHandler(this.lChangePass_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 1);
            this.panel2.TabIndex = 1;
            // 
            // lGenerateKey
            // 
            this.lGenerateKey.Controls.Add(this.lGenKey);
            this.lGenerateKey.Dock = System.Windows.Forms.DockStyle.Top;
            this.lGenerateKey.Location = new System.Drawing.Point(0, 51);
            this.lGenerateKey.Name = "lGenerateKey";
            this.lGenerateKey.Size = new System.Drawing.Size(560, 50);
            this.lGenerateKey.TabIndex = 2;
            // 
            // lGenKey
            // 
            this.lGenKey.AutoSize = true;
            this.lGenKey.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lGenKey.Location = new System.Drawing.Point(12, 19);
            this.lGenKey.Name = "lGenKey";
            this.lGenKey.Size = new System.Drawing.Size(196, 17);
            this.lGenKey.TabIndex = 1;
            this.lGenKey.Text = "Сгенерировать новый ключ";
            this.lGenKey.Click += new System.EventHandler(this.lGenKey_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 101);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(560, 1);
            this.panel4.TabIndex = 3;
            // 
            // lDeleteAcc
            // 
            this.lDeleteAcc.AutoSize = true;
            this.lDeleteAcc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDeleteAcc.ForeColor = System.Drawing.Color.Black;
            this.lDeleteAcc.Location = new System.Drawing.Point(12, 19);
            this.lDeleteAcc.Name = "lDeleteAcc";
            this.lDeleteAcc.Size = new System.Drawing.Size(121, 17);
            this.lDeleteAcc.TabIndex = 1;
            this.lDeleteAcc.Text = "Удалить аккаунт";
            this.lDeleteAcc.Click += new System.EventHandler(this.lDeleteAcc_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lDeleteAcc);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 102);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(560, 50);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 152);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(560, 1);
            this.panel6.TabIndex = 5;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 346);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lGenerateKey);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Account";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.lGenerateKey.ResumeLayout(false);
            this.lGenerateKey.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lChangePass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel lGenerateKey;
        private System.Windows.Forms.Label lGenKey;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lDeleteAcc;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}