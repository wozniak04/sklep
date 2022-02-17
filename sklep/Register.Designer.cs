using System;

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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegister_Apply = new System.Windows.Forms.Button();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.tUser = new System.Windows.Forms.TextBox();
            this.userChange_Right = new System.Windows.Forms.PictureBox();
            this.userChange_Left = new System.Windows.Forms.PictureBox();
            this.userAwatar = new System.Windows.Forms.PictureBox();
            this.userAwatar_List = new System.Windows.Forms.ImageList(this.components);
            this.listNawigation = new System.Windows.Forms.ImageList(this.components);
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userChange_Right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userChange_Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAwatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
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
            this.tER_Email.Location = new System.Drawing.Point(584, 385);
            this.tER_Email.Name = "tER_Email";
            this.tER_Email.Size = new System.Drawing.Size(47, 20);
            this.tER_Email.TabIndex = 7;
            this.tER_Email.Text = "label";
            // 
            // tER_Password
            // 
            this.tER_Password.AutoSize = true;
            this.tER_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.tER_Password.Location = new System.Drawing.Point(584, 448);
            this.tER_Password.Name = "tER_Password";
            this.tER_Password.Size = new System.Drawing.Size(47, 20);
            this.tER_Password.TabIndex = 8;
            this.tER_Password.Text = "label";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(82)))), ((int)(((byte)(81)))));
            this.groupBox1.Controls.Add(this.btnRegister_Apply);
            this.groupBox1.Controls.Add(this.tEmail);
            this.groupBox1.Controls.Add(this.tPassword);
            this.groupBox1.Controls.Add(this.tUser);
            this.groupBox1.Controls.Add(this.userChange_Right);
            this.groupBox1.Controls.Add(this.userChange_Left);
            this.groupBox1.Controls.Add(this.tER_Password);
            this.groupBox1.Controls.Add(this.tER_Email);
            this.groupBox1.Controls.Add(this.tER_User);
            this.groupBox1.Controls.Add(this.userAwatar);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(203, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 716);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnRegister_Apply
            // 
            this.btnRegister_Apply.BackColor = System.Drawing.Color.Lime;
            this.btnRegister_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister_Apply.Location = new System.Drawing.Point(257, 512);
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
            this.tEmail.Location = new System.Drawing.Point(235, 448);
            this.tEmail.Multiline = true;
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(302, 35);
            this.tEmail.TabIndex = 17;
            this.tEmail.Text = "Email";
            this.tEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tEmail.Enter += new System.EventHandler(this.Email_Clear);
            this.tEmail.Leave += new System.EventHandler(this.Email_Return);
            // 
            // tPassword
            // 
            this.tPassword.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tPassword.Location = new System.Drawing.Point(235, 385);
            this.tPassword.Multiline = true;
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(302, 35);
            this.tPassword.TabIndex = 16;
            this.tPassword.Text = "Hasło";
            this.tPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tPassword.Enter += new System.EventHandler(this.Password_Clear);
            this.tPassword.Leave += new System.EventHandler(this.Password_Return);
            // 
            // tUser
            // 
            this.tUser.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tUser.Location = new System.Drawing.Point(235, 314);
            this.tUser.Multiline = true;
            this.tUser.Name = "tUser";
            this.tUser.Size = new System.Drawing.Size(302, 35);
            this.tUser.TabIndex = 15;
            this.tUser.Text = "Nazwa użytkownika";
            this.tUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tUser.Enter += new System.EventHandler(this.User_Clear);
            this.tUser.Leave += new System.EventHandler(this.User_Return);
            // 
            // userChange_Right
            // 
            this.userChange_Right.Image = global::sklep.Properties.Resources.right_arrow;
            this.userChange_Right.Location = new System.Drawing.Point(484, 129);
            this.userChange_Right.Name = "userChange_Right";
            this.userChange_Right.Size = new System.Drawing.Size(73, 101);
            this.userChange_Right.TabIndex = 12;
            this.userChange_Right.TabStop = false;
            this.userChange_Right.Click += new System.EventHandler(this.userChange_Right_Click);
            // 
            // userChange_Left
            // 
            this.userChange_Left.Image = global::sklep.Properties.Resources.left_arrow;
            this.userChange_Left.Location = new System.Drawing.Point(215, 129);
            this.userChange_Left.Name = "userChange_Left";
            this.userChange_Left.Size = new System.Drawing.Size(63, 101);
            this.userChange_Left.TabIndex = 11;
            this.userChange_Left.TabStop = false;
            this.userChange_Left.Click += new System.EventHandler(this.userChange_Left_Click);
            // 
            // userAwatar
            // 
            this.userAwatar.Location = new System.Drawing.Point(257, 78);
            this.userAwatar.Name = "userAwatar";
            this.userAwatar.Size = new System.Drawing.Size(248, 203);
            this.userAwatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userAwatar.TabIndex = 0;
            this.userAwatar.TabStop = false;
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
            // 
            // btnBack
            // 
            this.btnBack.Image = global::sklep.Properties.Resources.back1;
            this.btnBack.Location = new System.Drawing.Point(1089, 26);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(70, 54);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 6;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Register";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rejestracja";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userChange_Right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userChange_Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAwatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);

        }

        

        
        
        #endregion
        private System.Windows.Forms.PictureBox userAwatar;
        private System.Windows.Forms.Label tER_User;
        private System.Windows.Forms.Label tER_Email;
        private System.Windows.Forms.Label tER_Password;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.PictureBox userChange_Right;
        private System.Windows.Forms.PictureBox userChange_Left;
        private System.Windows.Forms.ImageList userAwatar_List;
        private System.Windows.Forms.ImageList listNawigation;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.TextBox tUser;
        private System.Windows.Forms.Button btnRegister_Apply;
    }
}