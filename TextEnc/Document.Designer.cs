namespace TextEnc
{
    partial class Document
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
            this.ibCrypt = new FontAwesome.Sharp.IconButton();
            this.ibErase = new FontAwesome.Sharp.IconButton();
            this.ibSave = new FontAwesome.Sharp.IconButton();
            this.ibDelete = new FontAwesome.Sharp.IconButton();
            this.ibOpen = new FontAwesome.Sharp.IconButton();
            this.ibOpenNew = new FontAwesome.Sharp.IconButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbText = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.ibCrypt);
            this.panel1.Controls.Add(this.ibErase);
            this.panel1.Controls.Add(this.ibSave);
            this.panel1.Controls.Add(this.ibDelete);
            this.panel1.Controls.Add(this.ibOpen);
            this.panel1.Controls.Add(this.ibOpenNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 73);
            this.panel1.TabIndex = 0;
            // 
            // ibCrypt
            // 
            this.ibCrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibCrypt.Dock = System.Windows.Forms.DockStyle.Left;
            this.ibCrypt.FlatAppearance.BorderSize = 0;
            this.ibCrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibCrypt.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibCrypt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ibCrypt.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.ibCrypt.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(218)))), ((int)(((byte)(131)))));
            this.ibCrypt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibCrypt.IconSize = 32;
            this.ibCrypt.Location = new System.Drawing.Point(292, 0);
            this.ibCrypt.Name = "ibCrypt";
            this.ibCrypt.Rotation = 0D;
            this.ibCrypt.Size = new System.Drawing.Size(73, 73);
            this.ibCrypt.TabIndex = 8;
            this.ibCrypt.UseVisualStyleBackColor = true;
            this.ibCrypt.Click += new System.EventHandler(this.ibCrypt_Click_1);
            // 
            // ibErase
            // 
            this.ibErase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibErase.Dock = System.Windows.Forms.DockStyle.Left;
            this.ibErase.FlatAppearance.BorderSize = 0;
            this.ibErase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibErase.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibErase.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ibErase.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.ibErase.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibErase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibErase.IconSize = 32;
            this.ibErase.Location = new System.Drawing.Point(219, 0);
            this.ibErase.Name = "ibErase";
            this.ibErase.Rotation = 0D;
            this.ibErase.Size = new System.Drawing.Size(73, 73);
            this.ibErase.TabIndex = 7;
            this.ibErase.UseVisualStyleBackColor = true;
            this.ibErase.Click += new System.EventHandler(this.ibErase_Click);
            // 
            // ibSave
            // 
            this.ibSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.ibSave.FlatAppearance.BorderSize = 0;
            this.ibSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ibSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.ibSave.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibSave.IconSize = 32;
            this.ibSave.Location = new System.Drawing.Point(146, 0);
            this.ibSave.Name = "ibSave";
            this.ibSave.Rotation = 0D;
            this.ibSave.Size = new System.Drawing.Size(73, 73);
            this.ibSave.TabIndex = 3;
            this.ibSave.UseVisualStyleBackColor = true;
            this.ibSave.Click += new System.EventHandler(this.ibSave_Click);
            // 
            // ibDelete
            // 
            this.ibDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.ibDelete.FlatAppearance.BorderSize = 0;
            this.ibDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
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
            // ibOpen
            // 
            this.ibOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibOpen.Dock = System.Windows.Forms.DockStyle.Left;
            this.ibOpen.FlatAppearance.BorderSize = 0;
            this.ibOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibOpen.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibOpen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ibOpen.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.ibOpen.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibOpen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibOpen.IconSize = 32;
            this.ibOpen.Location = new System.Drawing.Point(73, 0);
            this.ibOpen.Name = "ibOpen";
            this.ibOpen.Rotation = 0D;
            this.ibOpen.Size = new System.Drawing.Size(73, 73);
            this.ibOpen.TabIndex = 1;
            this.ibOpen.UseVisualStyleBackColor = true;
            this.ibOpen.Click += new System.EventHandler(this.ibOpen_Click);
            // 
            // ibOpenNew
            // 
            this.ibOpenNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibOpenNew.Dock = System.Windows.Forms.DockStyle.Left;
            this.ibOpenNew.FlatAppearance.BorderSize = 0;
            this.ibOpenNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibOpenNew.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibOpenNew.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            this.ibOpenNew.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibOpenNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibOpenNew.IconSize = 32;
            this.ibOpenNew.Location = new System.Drawing.Point(0, 0);
            this.ibOpenNew.Name = "ibOpenNew";
            this.ibOpenNew.Rotation = 0D;
            this.ibOpenNew.Size = new System.Drawing.Size(73, 73);
            this.ibOpenNew.TabIndex = 0;
            this.ibOpenNew.UseVisualStyleBackColor = true;
            this.ibOpenNew.Click += new System.EventHandler(this.ibOpenNew_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbText
            // 
            this.tbText.BackColor = System.Drawing.Color.White;
            this.tbText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbText.Location = new System.Drawing.Point(0, 73);
            this.tbText.Margin = new System.Windows.Forms.Padding(0);
            this.tbText.Name = "tbText";
            this.tbText.ReadOnly = true;
            this.tbText.Size = new System.Drawing.Size(800, 377);
            this.tbText.TabIndex = 1;
            this.tbText.Text = "";
            // 
            // Document
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Document";
            this.Load += new System.EventHandler(this.Document_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton ibDelete;
        private FontAwesome.Sharp.IconButton ibOpen;
        private FontAwesome.Sharp.IconButton ibOpenNew;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private FontAwesome.Sharp.IconButton ibSave;
        private System.Windows.Forms.RichTextBox tbText;
        private FontAwesome.Sharp.IconButton ibCrypt;
        private FontAwesome.Sharp.IconButton ibErase;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}