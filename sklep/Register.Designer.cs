namespace sklep
{
    partial class Register
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
            this.tPassword = new System.Windows.Forms.TextBox();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.tLogin = new System.Windows.Forms.TextBox();
            this.tUser = new System.Windows.Forms.TextBox();
            this.tER_User = new System.Windows.Forms.Label();
            this.tER_Email = new System.Windows.Forms.Label();
            this.tER_Password = new System.Windows.Forms.Label();
            this.tER_Login = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // tPassword
            // 
            this.tPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.tPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tPassword.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tPassword.Location = new System.Drawing.Point(223, 427);
            this.tPassword.Multiline = true;
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(325, 35);
            this.tPassword.TabIndex = 2;
            this.tPassword.Text = "Hasło";
            this.tPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tPassword.Enter += new System.EventHandler(this.Password_Clear);
            this.tPassword.Leave += new System.EventHandler(this.Password_Return);
            // 
            // tEmail
            // 
            this.tEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.tEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tEmail.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tEmail.Location = new System.Drawing.Point(223, 374);
            this.tEmail.Multiline = true;
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(325, 35);
            this.tEmail.TabIndex = 1;
            this.tEmail.Text = "Email";
            this.tEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tEmail.Enter += new System.EventHandler(this.Email_Clear);
            this.tEmail.Leave += new System.EventHandler(this.Email_Return);
            // 
            // tLogin
            // 
            this.tLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.tLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tLogin.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tLogin.Location = new System.Drawing.Point(223, 480);
            this.tLogin.Multiline = true;
            this.tLogin.Name = "tLogin";
            this.tLogin.Size = new System.Drawing.Size(325, 35);
            this.tLogin.TabIndex = 3;
            this.tLogin.Text = "Login";
            this.tLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tLogin.Enter += new System.EventHandler(this.Login_Clear);
            this.tLogin.Leave += new System.EventHandler(this.Login_Return);
            // 
            // tUser
            // 
            this.tUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.tUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tUser.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tUser.Location = new System.Drawing.Point(223, 312);
            this.tUser.Multiline = true;
            this.tUser.Name = "tUser";
            this.tUser.Size = new System.Drawing.Size(325, 35);
            this.tUser.TabIndex = 4;
            this.tUser.Text = "Nazwa użytkownika";
            this.tUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tUser.Enter += new System.EventHandler(this.User_Clear);
            this.tUser.Leave += new System.EventHandler(this.User_Return);
            // 
            // tER_User
            // 
            this.tER_User.AutoSize = true;
            this.tER_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.tER_User.Location = new System.Drawing.Point(584, 314);
            this.tER_User.Name = "tER_User";
            this.tER_User.Size = new System.Drawing.Size(47, 20);
            this.tER_User.TabIndex = 6;
            this.tER_User.Text = "label";
            // 
            // tER_Email
            // 
            this.tER_Email.AutoSize = true;
            this.tER_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.tER_Email.Location = new System.Drawing.Point(584, 374);
            this.tER_Email.Name = "tER_Email";
            this.tER_Email.Size = new System.Drawing.Size(47, 20);
            this.tER_Email.TabIndex = 7;
            this.tER_Email.Text = "label";
            // 
            // tER_Password
            // 
            this.tER_Password.AutoSize = true;
            this.tER_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.tER_Password.Location = new System.Drawing.Point(584, 427);
            this.tER_Password.Name = "tER_Password";
            this.tER_Password.Size = new System.Drawing.Size(47, 20);
            this.tER_Password.TabIndex = 8;
            this.tER_Password.Text = "label";
            // 
            // tER_Login
            // 
            this.tER_Login.AutoSize = true;
            this.tER_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.tER_Login.Location = new System.Drawing.Point(584, 480);
            this.tER_Login.Name = "tER_Login";
            this.tER_Login.Size = new System.Drawing.Size(47, 20);
            this.tER_Login.TabIndex = 9;
            this.tER_Login.Text = "label";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(82)))), ((int)(((byte)(81)))));
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.tER_Login);
            this.groupBox1.Controls.Add(this.tER_Password);
            this.groupBox1.Controls.Add(this.tER_Email);
            this.groupBox1.Controls.Add(this.tER_User);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.tUser);
            this.groupBox1.Controls.Add(this.tLogin);
            this.groupBox1.Controls.Add(this.tEmail);
            this.groupBox1.Controls.Add(this.tPassword);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(227, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 702);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::sklep.Properties.Resources.right_arrow;
            this.pictureBox3.Location = new System.Drawing.Point(539, 142);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(79, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::sklep.Properties.Resources.left_arrow1;
            this.pictureBox2.Location = new System.Drawing.Point(138, 142);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(230)))), ((int)(((byte)(83)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Location = new System.Drawing.Point(257, 551);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(248, 44);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Zatwierdź";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sklep.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(257, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Image = global::sklep.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(1089, 26);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(70, 54);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 6;
            this.btnBack.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rejestracja";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.TextBox tLogin;
        private System.Windows.Forms.TextBox tUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tER_User;
        private System.Windows.Forms.Label tER_Email;
        private System.Windows.Forms.Label tER_Password;
        private System.Windows.Forms.Label tER_Login;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}