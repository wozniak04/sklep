
using System;

namespace sklep
{
    partial class Logging
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.tUser = new System.Windows.Forms.TextBox();
            this.tER_Password = new System.Windows.Forms.Label();
            this.tER_User = new System.Windows.Forms.Label();
            this.boxLogin = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tPassword_Error = new System.Windows.Forms.Label();
            this.tUser_Error = new System.Windows.Forms.Label();
            this.userAwatar = new System.Windows.Forms.PictureBox();
            this.Contrast = new System.Windows.Forms.PictureBox();
            this.btnMinimalize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.boxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAwatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimalize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Lime;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRegister.Location = new System.Drawing.Point(239, 528);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(302, 49);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Zarejestruj";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click_1);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Lime;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogin.Location = new System.Drawing.Point(267, 468);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(248, 42);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Zaloguj";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tPassword
            // 
            this.tPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.tPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tPassword.Location = new System.Drawing.Point(239, 402);
            this.tPassword.Multiline = true;
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(302, 35);
            this.tPassword.TabIndex = 10;
            this.tPassword.Text = "Hasło";
            this.tPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tPassword.Enter += new System.EventHandler(this.Password_Clear);
            this.tPassword.Leave += new System.EventHandler(this.Password_Return);
            // 
            // tUser
            // 
            this.tUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.tUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tUser.Location = new System.Drawing.Point(239, 331);
            this.tUser.Multiline = true;
            this.tUser.Name = "tUser";
            this.tUser.Size = new System.Drawing.Size(302, 35);
            this.tUser.TabIndex = 9;
            this.tUser.Text = "Nazwa użytkownika";
            this.tUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tUser.Enter += new System.EventHandler(this.User_Clear);
            this.tUser.Leave += new System.EventHandler(this.User_Return);
            // 
            // tER_Password
            // 
            this.tER_Password.AutoSize = true;
            this.tER_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.tER_Password.Location = new System.Drawing.Point(580, 402);
            this.tER_Password.Name = "tER_Password";
            this.tER_Password.Size = new System.Drawing.Size(0, 20);
            this.tER_Password.TabIndex = 8;
            // 
            // tER_User
            // 
            this.tER_User.AutoSize = true;
            this.tER_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.tER_User.Location = new System.Drawing.Point(580, 331);
            this.tER_User.Name = "tER_User";
            this.tER_User.Size = new System.Drawing.Size(0, 20);
            this.tER_User.TabIndex = 6;
            // 
            // boxLogin
            // 
            this.boxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(82)))), ((int)(((byte)(81)))));
            this.boxLogin.Controls.Add(this.button1);
            this.boxLogin.Controls.Add(this.tPassword_Error);
            this.boxLogin.Controls.Add(this.tUser_Error);
            this.boxLogin.Controls.Add(this.btnRegister);
            this.boxLogin.Controls.Add(this.userAwatar);
            this.boxLogin.Controls.Add(this.Contrast);
            this.boxLogin.Controls.Add(this.btnLogin);
            this.boxLogin.Controls.Add(this.tER_User);
            this.boxLogin.Controls.Add(this.tPassword);
            this.boxLogin.Controls.Add(this.tER_Password);
            this.boxLogin.Controls.Add(this.tUser);
            this.boxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.boxLogin.Location = new System.Drawing.Point(207, 68);
            this.boxLogin.Name = "boxLogin";
            this.boxLogin.Size = new System.Drawing.Size(764, 733);
            this.boxLogin.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 611);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tPassword_Error
            // 
            this.tPassword_Error.AutoSize = true;
            this.tPassword_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tPassword_Error.ForeColor = System.Drawing.Color.Red;
            this.tPassword_Error.Location = new System.Drawing.Point(562, 417);
            this.tPassword_Error.Name = "tPassword_Error";
            this.tPassword_Error.Size = new System.Drawing.Size(0, 20);
            this.tPassword_Error.TabIndex = 24;
            // 
            // tUser_Error
            // 
            this.tUser_Error.AutoSize = true;
            this.tUser_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tUser_Error.ForeColor = System.Drawing.Color.Red;
            this.tUser_Error.Location = new System.Drawing.Point(562, 346);
            this.tUser_Error.Name = "tUser_Error";
            this.tUser_Error.Size = new System.Drawing.Size(0, 20);
            this.tUser_Error.TabIndex = 23;
            // 
            // userAwatar
            // 
            this.userAwatar.Image = global::sklep.Properties.Resources.user0;
            this.userAwatar.Location = new System.Drawing.Point(267, 89);
            this.userAwatar.Name = "userAwatar";
            this.userAwatar.Size = new System.Drawing.Size(248, 203);
            this.userAwatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userAwatar.TabIndex = 0;
            this.userAwatar.TabStop = false;
            // 
            // Contrast
            // 
            this.Contrast.Image = global::sklep.Properties.Resources.contrast;
            this.Contrast.Location = new System.Drawing.Point(670, 18);
            this.Contrast.Name = "Contrast";
            this.Contrast.Size = new System.Drawing.Size(75, 50);
            this.Contrast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Contrast.TabIndex = 7;
            this.Contrast.TabStop = false;
            this.Contrast.Click += new System.EventHandler(this.Contrast_Click);
            // 
            // btnMinimalize
            // 
            this.btnMinimalize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimalize.Image = global::sklep.Properties.Resources.minimize_sign;
            this.btnMinimalize.Location = new System.Drawing.Point(1130, 0);
            this.btnMinimalize.Name = "btnMinimalize";
            this.btnMinimalize.Size = new System.Drawing.Size(35, 40);
            this.btnMinimalize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimalize.TabIndex = 10;
            this.btnMinimalize.TabStop = false;
            this.btnMinimalize.Click += new System.EventHandler(this.btnMinimalize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = global::sklep.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(1165, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 40);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 8;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(82)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.btnMinimalize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 40);
            this.panel1.TabIndex = 11;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Logging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1200, 850);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.boxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Logging";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.boxLogin.ResumeLayout(false);
            this.boxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAwatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimalize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        

        #endregion
        private System.Windows.Forms.Label tER_Password;
        private System.Windows.Forms.Label tER_User;
        private System.Windows.Forms.PictureBox userAwatar;
        private System.Windows.Forms.TextBox tUser;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox Contrast;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel boxLogin;
        private System.Windows.Forms.PictureBox btnMinimalize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tPassword_Error;
        private System.Windows.Forms.Label tUser_Error;
        private System.Windows.Forms.Button button1;
    }
}

