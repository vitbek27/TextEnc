namespace TextEnc
{
    partial class Accounts
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ibOpen = new FontAwesome.Sharp.IconButton();
            this.ibGenKey = new FontAwesome.Sharp.IconButton();
            this.ibNewPass = new FontAwesome.Sharp.IconButton();
            this.ibDelete = new FontAwesome.Sharp.IconButton();
            this.ibInfo = new FontAwesome.Sharp.IconButton();
            this.ibAdd = new FontAwesome.Sharp.IconButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.ibOpen);
            this.panel1.Controls.Add(this.ibGenKey);
            this.panel1.Controls.Add(this.ibNewPass);
            this.panel1.Controls.Add(this.ibDelete);
            this.panel1.Controls.Add(this.ibInfo);
            this.panel1.Controls.Add(this.ibAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 73);
            this.panel1.TabIndex = 2;
            // 
            // ibOpen
            // 
            this.ibOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibOpen.Dock = System.Windows.Forms.DockStyle.Left;
            this.ibOpen.FlatAppearance.BorderSize = 0;
            this.ibOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibOpen.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibOpen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ibOpen.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.ibOpen.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(218)))), ((int)(((byte)(131)))));
            this.ibOpen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibOpen.IconSize = 32;
            this.ibOpen.Location = new System.Drawing.Point(292, 0);
            this.ibOpen.Name = "ibOpen";
            this.ibOpen.Rotation = 0D;
            this.ibOpen.Size = new System.Drawing.Size(73, 73);
            this.ibOpen.TabIndex = 8;
            this.ibOpen.UseVisualStyleBackColor = true;
            this.ibOpen.Click += new System.EventHandler(this.ibOpen_Click_1);
            // 
            // ibGenKey
            // 
            this.ibGenKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibGenKey.Dock = System.Windows.Forms.DockStyle.Left;
            this.ibGenKey.FlatAppearance.BorderSize = 0;
            this.ibGenKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibGenKey.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibGenKey.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ibGenKey.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.ibGenKey.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibGenKey.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibGenKey.IconSize = 32;
            this.ibGenKey.Location = new System.Drawing.Point(219, 0);
            this.ibGenKey.Name = "ibGenKey";
            this.ibGenKey.Rotation = 0D;
            this.ibGenKey.Size = new System.Drawing.Size(73, 73);
            this.ibGenKey.TabIndex = 7;
            this.ibGenKey.UseVisualStyleBackColor = true;
            this.ibGenKey.Click += new System.EventHandler(this.ibGenKey_Click);
            // 
            // ibNewPass
            // 
            this.ibNewPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibNewPass.Dock = System.Windows.Forms.DockStyle.Left;
            this.ibNewPass.FlatAppearance.BorderSize = 0;
            this.ibNewPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibNewPass.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibNewPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ibNewPass.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.ibNewPass.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibNewPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibNewPass.IconSize = 32;
            this.ibNewPass.Location = new System.Drawing.Point(146, 0);
            this.ibNewPass.Name = "ibNewPass";
            this.ibNewPass.Rotation = 0D;
            this.ibNewPass.Size = new System.Drawing.Size(73, 73);
            this.ibNewPass.TabIndex = 3;
            this.ibNewPass.UseVisualStyleBackColor = true;
            this.ibNewPass.Click += new System.EventHandler(this.ibEdit_Click);
            // 
            // ibDelete
            // 
            this.ibDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.ibDelete.FlatAppearance.BorderSize = 0;
            this.ibDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibDelete.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.ibDelete.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibDelete.IconSize = 32;
            this.ibDelete.Location = new System.Drawing.Point(727, 0);
            this.ibDelete.Name = "ibDelete";
            this.ibDelete.Rotation = 0D;
            this.ibDelete.Size = new System.Drawing.Size(73, 73);
            this.ibDelete.TabIndex = 2;
            this.ibDelete.UseVisualStyleBackColor = true;
            this.ibDelete.Click += new System.EventHandler(this.ibDelete_Click);
            // 
            // ibInfo
            // 
            this.ibInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.ibInfo.FlatAppearance.BorderSize = 0;
            this.ibInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibInfo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ibInfo.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.ibInfo.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibInfo.IconSize = 32;
            this.ibInfo.Location = new System.Drawing.Point(73, 0);
            this.ibInfo.Name = "ibInfo";
            this.ibInfo.Rotation = 0D;
            this.ibInfo.Size = new System.Drawing.Size(73, 73);
            this.ibInfo.TabIndex = 1;
            this.ibInfo.UseVisualStyleBackColor = true;
            this.ibInfo.Click += new System.EventHandler(this.ibInfo_Click);
            // 
            // ibAdd
            // 
            this.ibAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.ibAdd.FlatAppearance.BorderSize = 0;
            this.ibAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.ibAdd.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibAdd.IconSize = 32;
            this.ibAdd.Location = new System.Drawing.Point(0, 0);
            this.ibAdd.Name = "ibAdd";
            this.ibAdd.Rotation = 0D;
            this.ibAdd.Size = new System.Drawing.Size(73, 73);
            this.ibAdd.TabIndex = 0;
            this.ibAdd.UseVisualStyleBackColor = true;
            this.ibAdd.Click += new System.EventHandler(this.ibAdd_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbUsers
            // 
            this.lbUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbUsers.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 17;
            this.lbUsers.Location = new System.Drawing.Point(0, 73);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(800, 377);
            this.lbUsers.TabIndex = 4;
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lbUsers);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Accounts";
            this.Load += new System.EventHandler(this.Accounts_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton ibNewPass;
        private FontAwesome.Sharp.IconButton ibDelete;
        private FontAwesome.Sharp.IconButton ibInfo;
        private FontAwesome.Sharp.IconButton ibAdd;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lbUsers;
        private FontAwesome.Sharp.IconButton ibOpen;
        private FontAwesome.Sharp.IconButton ibGenKey;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}