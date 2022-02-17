using System;
using System.Drawing;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.tER_User = new System.Windows.Forms.Label();
            this.tER_Email = new System.Windows.Forms.Label();
            this.tER_Password = new System.Windows.Forms.Label();
            this.userAwatar_List = new System.Windows.Forms.ImageList(this.components);
            this.listNawigation = new System.Windows.Forms.ImageList(this.components);
            this.boxRegister = new System.Windows.Forms.Panel();
            this.btnRegister_Apply = new System.Windows.Forms.Button();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.tUser = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.Contrast = new System.Windows.Forms.PictureBox();
            this.userAwatar = new System.Windows.Forms.PictureBox();
            this.userChange_Left = new System.Windows.Forms.PictureBox();
            this.userChange_Right = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.btnMinimalize = new System.Windows.Forms.PictureBox();
            this.boxRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAwatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userChange_Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userChange_Right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimalize)).BeginInit();
            this.SuspendLayout();
            // 
            // tER_User
            // 
            this.tER_User.AutoSize = true;
            this.tER_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.tER_User.Location = new System.Drawing.Point(1386, 505);
            this.tER_User.Name = "tER_User";
            this.tER_User.Size = new System.Drawing.Size(29, 13);
            this.tER_User.TabIndex = 6;
            this.tER_User.Text = "label";
            // 
            // tER_Email
            // 
            this.tER_Email.AutoSize = true;
            this.tER_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.tER_Email.Location = new System.Drawing.Point(1386, 576);
            this.tER_Email.Name = "tER_Email";
            this.tER_Email.Size = new System.Drawing.Size(29, 13);
            this.tER_Email.TabIndex = 7;
            this.tER_Email.Text = "label";
            // 
            // tER_Password
            // 
            this.tER_Password.AutoSize = true;
            this.tER_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.tER_Password.Location = new System.Drawing.Point(1386, 639);
            this.tER_Password.Name = "tER_Password";
            this.tER_Password.Size = new System.Drawing.Size(29, 13);
            this.tER_Password.TabIndex = 8;
            this.tER_Password.Text = "label";
            // 
            // userAwatar_List
            // 
            this.userAwatar_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("userAwatar_List.ImageStream")));
            this.userAwatar_List.TransparentColor = System.Drawing.Color.Transparent;
            this.userAwatar_List.Images.SetKeyName(0, "user0.png");
            this.userAwatar_List.Images.SetKeyName(1, "user1.png");
            this.userAwatar_List.Images.SetKeyName(2, "user2.png");
            this.userAwatar_List.Images.SetKeyName(3, "user3.png");
            this.userAwatar_List.Images.SetKeyName(4, "user4.png");
            this.userAwatar_List.Images.SetKeyName(5, "user5.png");
            this.userAwatar_List.Images.SetKeyName(6, "user6.png");
            this.userAwatar_List.Images.SetKeyName(7, "user7.png");
            this.userAwatar_List.Images.SetKeyName(8, "user8.png");
            this.userAwatar_List.Images.SetKeyName(9, "user9.png");
            this.userAwatar_List.Images.SetKeyName(10, "user10.png");
            this.userAwatar_List.Images.SetKeyName(11, "user11.png");
            this.userAwatar_List.Images.SetKeyName(12, "user12.png");
            // 
            // listNawigation
            // 
            this.listNawigation.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listNawigation.ImageStream")));
            this.listNawigation.TransparentColor = System.Drawing.Color.Transparent;
            this.listNawigation.Images.SetKeyName(0, "left-arrow.png");
            this.listNawigation.Images.SetKeyName(1, "right-arrow.png");
            this.listNawigation.Images.SetKeyName(2, "back.png");
            this.listNawigation.Images.SetKeyName(3, "menu.png");
            this.listNawigation.Images.SetKeyName(4, "contrast.png");
            this.listNawigation.Images.SetKeyName(5, "power-off.png");
            // 
            // boxRegister
            // 
            this.boxRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(82)))), ((int)(((byte)(81)))));
            this.boxRegister.Controls.Add(this.Contrast);
            this.boxRegister.Controls.Add(this.userAwatar);
            this.boxRegister.Controls.Add(this.btnRegister_Apply);
            this.boxRegister.Controls.Add(this.userChange_Left);
            this.boxRegister.Controls.Add(this.userChange_Right);
            this.boxRegister.Controls.Add(this.tEmail);
            this.boxRegister.Controls.Add(this.tUser);
            this.boxRegister.Controls.Add(this.tPassword);
            this.boxRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.boxRegister.Location = new System.Drawing.Point(203, 26);
            this.boxRegister.Name = "boxRegister";
            this.boxRegister.Size = new System.Drawing.Size(764, 716);
            this.boxRegister.TabIndex = 8;
            // 
            // btnRegister_Apply
            // 
            this.btnRegister_Apply.BackColor = System.Drawing.Color.Lime;
            this.btnRegister_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister_Apply.Location = new System.Drawing.Point(252, 533);
            this.btnRegister_Apply.Name = "btnRegister_Apply";
            this.btnRegister_Apply.Size = new System.Drawing.Size(248, 41);
            this.btnRegister_Apply.TabIndex = 19;
            this.btnRegister_Apply.Text = "Zatwierdź";
            this.btnRegister_Apply.UseVisualStyleBackColor = false;
            this.btnRegister_Apply.Click += new System.EventHandler(this.btnRegister_Apply_Click_1);
            // 
            // tEmail
            // 
            this.tEmail.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tEmail.Location = new System.Drawing.Point(230, 469);
            this.tEmail.Multiline = true;
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(302, 35);
            this.tEmail.TabIndex = 17;
            this.tEmail.Text = "Email";
            this.tEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tEmail.Enter += new System.EventHandler(this.Email_Clear);
            this.tEmail.Leave += new System.EventHandler(this.Email_Return);
            // 
            // tUser
            // 
            this.tUser.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tUser.Location = new System.Drawing.Point(230, 335);
            this.tUser.Multiline = true;
            this.tUser.Name = "tUser";
            this.tUser.Size = new System.Drawing.Size(302, 35);
            this.tUser.TabIndex = 15;
            this.tUser.Text = "Nazwa użytkownika";
            this.tUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tUser.Enter += new System.EventHandler(this.User_Clear);
            this.tUser.Leave += new System.EventHandler(this.User_Return);
            // 
            // tPassword
            // 
            this.tPassword.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tPassword.Location = new System.Drawing.Point(230, 406);
            this.tPassword.Multiline = true;
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(302, 35);
            this.tPassword.TabIndex = 16;
            this.tPassword.Text = "Hasło";
            this.tPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tPassword.Enter += new System.EventHandler(this.Password_Clear);
            this.tPassword.Leave += new System.EventHandler(this.Password_Return);
            // 
            // Contrast
            // 
            this.Contrast.Image = global::sklep.Properties.Resources.contrast;
            this.Contrast.Location = new System.Drawing.Point(652, 17);
            this.Contrast.Name = "Contrast";
            this.Contrast.Size = new System.Drawing.Size(91, 66);
            this.Contrast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Contrast.TabIndex = 20;
            this.Contrast.TabStop = false;
            this.Contrast.Click += new System.EventHandler(this.Contrast_Click);
            // 
            // userAwatar
            // 
            this.userAwatar.Location = new System.Drawing.Point(252, 99);
            this.userAwatar.Name = "userAwatar";
            this.userAwatar.Size = new System.Drawing.Size(248, 203);
            this.userAwatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userAwatar.TabIndex = 0;
            this.userAwatar.TabStop = false;
            // 
            // userChange_Left
            // 
            this.userChange_Left.Image = global::sklep.Properties.Resources.left_arrow;
            this.userChange_Left.Location = new System.Drawing.Point(210, 150);
            this.userChange_Left.Name = "userChange_Left";
            this.userChange_Left.Size = new System.Drawing.Size(63, 101);
            this.userChange_Left.TabIndex = 11;
            this.userChange_Left.TabStop = false;
            this.userChange_Left.Click += new System.EventHandler(this.userChange_Left_Click);
            // 
            // userChange_Right
            // 
            this.userChange_Right.Image = global::sklep.Properties.Resources.right_arrow;
            this.userChange_Right.Location = new System.Drawing.Point(479, 150);
            this.userChange_Right.Name = "userChange_Right";
            this.userChange_Right.Size = new System.Drawing.Size(73, 101);
            this.userChange_Right.TabIndex = 12;
            this.userChange_Right.TabStop = false;
            this.userChange_Right.Click += new System.EventHandler(this.userChange_Right_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::sklep.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(1060, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 48);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 7;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.Image = global::sklep.Properties.Resources.back1;
            this.btnBack.Location = new System.Drawing.Point(1130, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(70, 800);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBack.TabIndex = 6;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnMinimalize
            // 
            this.btnMinimalize.Image = global::sklep.Properties.Resources.minimize_sign;
            this.btnMinimalize.Location = new System.Drawing.Point(990, 12);
            this.btnMinimalize.Name = "btnMinimalize";
            this.btnMinimalize.Size = new System.Drawing.Size(64, 50);
            this.btnMinimalize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimalize.TabIndex = 11;
            this.btnMinimalize.TabStop = false;
            this.btnMinimalize.Click += new System.EventHandler(this.btnMinimalize_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.btnMinimalize);
            this.Controls.Add(this.boxRegister);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tER_User);
            this.Controls.Add(this.tER_Email);
            this.Controls.Add(this.tER_Password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rejestracja";
            this.boxRegister.ResumeLayout(false);
            this.boxRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAwatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userChange_Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userChange_Right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimalize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void User_Clear(object sender, EventArgs e)
        {
            if (tUser.Text == "Nazwa użytkownika")
            {
                tUser.Clear();
            }
        }

        private void User_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tUser.Text))
            {
                tUser.Text = "Nazwa użytkownika";
            }
        }

        private void Password_Clear(object sender, EventArgs e)
        {
            if (tPassword.Text == "Hasło")
            {
                tPassword.Clear();
            }
        }

        private void Password_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tPassword.Text))
            {
                tPassword.Text = "Hasło";
            }
        }

        private void Email_Clear(object sender, EventArgs e)
        {
            if (tEmail.Text == "Email")
            {
                tEmail.Clear();
            }
        }

        private void Email_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tEmail.Text))
            {
                tEmail.Text = "Email";
            }
        }

        //information about registration
        private void btnRegister_Apply_Click_1(object sender, EventArgs e)
        {
            Register_Alert regAlert = new Register_Alert();
            regAlert.Show();
        }

        //return to main window
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logging Logging = new Logging();
            Logging.ShowDialog();
            this.Close();
        }

        //Changing the user image functions
        int count = -1;
        private void userChange_Left_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count--;
            }

            userAwatar.Image = userAwatar_List.Images[count];
        }

        private void userChange_Right_Click(object sender, EventArgs e)
        {

            if (count < 12)
            {
                count++;
            }
            userAwatar.Image = userAwatar_List.Images[count];
        }
        //Close window function
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Contrast function
        private void Contrast_Click(object sender, EventArgs e)
        {

            if (this.BackColor == Color.FromArgb(90, 92, 91))
            {
                this.BackColor = Color.FromArgb(225, 227, 225);
                boxRegister.BackColor = Color.FromArgb(169, 171, 169);
                tUser.BackColor = Color.FromArgb(225, 227, 225);
                tPassword.BackColor = Color.FromArgb(225, 227, 225);
                tEmail.BackColor = Color.FromArgb(225, 227, 225);
            }
            else
            {
                this.BackColor = Color.FromArgb(90, 92, 91);
                boxRegister.BackColor = Color.FromArgb(80, 82, 81);
                tUser.BackColor = Color.FromArgb(90, 92, 91);
                tPassword.BackColor = Color.FromArgb(90, 92, 91);
                tEmail.BackColor = Color.FromArgb(90, 92, 91);
            }
        }


        #endregion
        private System.Windows.Forms.Label tER_User;
        private System.Windows.Forms.Label tER_Email;
        private System.Windows.Forms.Label tER_Password;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.ImageList userAwatar_List;
        private System.Windows.Forms.ImageList listNawigation;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel boxRegister;
        private System.Windows.Forms.PictureBox userAwatar;
        private System.Windows.Forms.Button btnRegister_Apply;
        private System.Windows.Forms.PictureBox userChange_Left;
        private System.Windows.Forms.PictureBox userChange_Right;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.TextBox tUser;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.PictureBox Contrast;
        private System.Windows.Forms.PictureBox btnMinimalize;
    }
}