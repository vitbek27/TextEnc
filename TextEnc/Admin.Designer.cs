namespace TextEnc
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.lbExit = new System.Windows.Forms.Label();
            this.pToolBox = new System.Windows.Forms.Panel();
            this.ibWinMin = new FontAwesome.Sharp.IconButton();
            this.ibWin = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ibDocs = new FontAwesome.Sharp.IconButton();
            this.ibAccounts = new FontAwesome.Sharp.IconButton();
            this.ibExit = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pDesktop = new System.Windows.Forms.Panel();
            this.pToolBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbExit.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbExit.Location = new System.Drawing.Point(783, 0);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(17, 17);
            this.lbExit.TabIndex = 8;
            this.lbExit.Text = "X";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // pToolBox
            // 
            this.pToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.pToolBox.Controls.Add(this.ibWinMin);
            this.pToolBox.Controls.Add(this.ibWin);
            this.pToolBox.Controls.Add(this.lbExit);
            this.pToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pToolBox.Location = new System.Drawing.Point(0, 0);
            this.pToolBox.Name = "pToolBox";
            this.pToolBox.Size = new System.Drawing.Size(800, 22);
            this.pToolBox.TabIndex = 6;
            this.pToolBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pToolBox_MouseDown_1);
            // 
            // ibWinMin
            // 
            this.ibWinMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.ibWinMin.FlatAppearance.BorderSize = 0;
            this.ibWinMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibWinMin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibWinMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.ibWinMin.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibWinMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibWinMin.IconSize = 22;
            this.ibWinMin.Location = new System.Drawing.Point(703, 0);
            this.ibWinMin.Name = "ibWinMin";
            this.ibWinMin.Rotation = 0D;
            this.ibWinMin.Size = new System.Drawing.Size(40, 22);
            this.ibWinMin.TabIndex = 11;
            this.ibWinMin.UseVisualStyleBackColor = true;
            this.ibWinMin.Click += new System.EventHandler(this.ibWinMin_Click);
            // 
            // ibWin
            // 
            this.ibWin.Dock = System.Windows.Forms.DockStyle.Right;
            this.ibWin.FlatAppearance.BorderSize = 0;
            this.ibWin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibWin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibWin.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.ibWin.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibWin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibWin.IconSize = 22;
            this.ibWin.Location = new System.Drawing.Point(743, 0);
            this.ibWin.Name = "ibWin";
            this.ibWin.Rotation = 0D;
            this.ibWin.Size = new System.Drawing.Size(40, 22);
            this.ibWin.TabIndex = 10;
            this.ibWin.UseVisualStyleBackColor = true;
            this.ibWin.Click += new System.EventHandler(this.ibWin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.ibDocs);
            this.panel1.Controls.Add(this.ibAccounts);
            this.panel1.Controls.Add(this.ibExit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 428);
            this.panel1.TabIndex = 9;
            // 
            // ibDocs
            // 
            this.ibDocs.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibDocs.FlatAppearance.BorderSize = 0;
            this.ibDocs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibDocs.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibDocs.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ibDocs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ibDocs.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.ibDocs.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibDocs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibDocs.IconSize = 32;
            this.ibDocs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibDocs.Location = new System.Drawing.Point(0, 132);
            this.ibDocs.Name = "ibDocs";
            this.ibDocs.Rotation = 0D;
            this.ibDocs.Size = new System.Drawing.Size(173, 59);
            this.ibDocs.TabIndex = 6;
            this.ibDocs.Text = "Смена пароля";
            this.ibDocs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibDocs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibDocs.UseVisualStyleBackColor = true;
            this.ibDocs.Click += new System.EventHandler(this.ibDocs_Click);
            // 
            // ibAccounts
            // 
            this.ibAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibAccounts.FlatAppearance.BorderSize = 0;
            this.ibAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibAccounts.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibAccounts.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ibAccounts.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ibAccounts.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.ibAccounts.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibAccounts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibAccounts.IconSize = 32;
            this.ibAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibAccounts.Location = new System.Drawing.Point(0, 73);
            this.ibAccounts.Name = "ibAccounts";
            this.ibAccounts.Rotation = 0D;
            this.ibAccounts.Size = new System.Drawing.Size(173, 59);
            this.ibAccounts.TabIndex = 5;
            this.ibAccounts.Text = "Пользователи";
            this.ibAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibAccounts.UseVisualStyleBackColor = true;
            this.ibAccounts.Click += new System.EventHandler(this.ibAccounts_Click);
            // 
            // ibExit
            // 
            this.ibExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ibExit.FlatAppearance.BorderSize = 0;
            this.ibExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibExit.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ibExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ibExit.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.ibExit.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibExit.IconSize = 32;
            this.ibExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibExit.Location = new System.Drawing.Point(0, 371);
            this.ibExit.Name = "ibExit";
            this.ibExit.Rotation = 0D;
            this.ibExit.Size = new System.Drawing.Size(173, 57);
            this.ibExit.TabIndex = 4;
            this.ibExit.Text = "Выйти";
            this.ibExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibExit.UseVisualStyleBackColor = true;
            this.ibExit.Click += new System.EventHandler(this.ibExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pDesktop
            // 
            this.pDesktop.BackColor = System.Drawing.Color.White;
            this.pDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDesktop.Location = new System.Drawing.Point(173, 22);
            this.pDesktop.Name = "pDesktop";
            this.pDesktop.Size = new System.Drawing.Size(627, 428);
            this.pDesktop.TabIndex = 10;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pDesktop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pToolBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Load);
            this.pToolBox.ResumeLayout(false);
            this.pToolBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.Panel pToolBox;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton ibDocs;
        private FontAwesome.Sharp.IconButton ibAccounts;
        private FontAwesome.Sharp.IconButton ibExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pDesktop;
        private FontAwesome.Sharp.IconButton ibWin;
        private FontAwesome.Sharp.IconButton ibWinMin;
    }
}