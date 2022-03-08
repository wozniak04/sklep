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
            this.userAwatar_List = new System.Windows.Forms.ImageList(this.components);
            this.listNawigation = new System.Windows.Forms.ImageList(this.components);
            this.tPasswordRepeat = new System.Windows.Forms.TextBox();
            this.userAwatar = new System.Windows.Forms.PictureBox();
            this.Contrast = new System.Windows.Forms.PictureBox();
            this.btnRegister_Apply = new System.Windows.Forms.Button();
            this.userChange_Left = new System.Windows.Forms.PictureBox();
            this.userChange_Right = new System.Windows.Forms.PictureBox();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.tUser = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.btnMinimalize = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.boxRegister = new System.Windows.Forms.TableLayoutPanel();
            this.tUser_Error = new System.Windows.Forms.Label();
            this.tEmail_Error = new System.Windows.Forms.Label();
            this.tPassword_Error = new System.Windows.Forms.Label();
            this.tPasswordRepeat_Error = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.userAwatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userChange_Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userChange_Right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimalize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.boxRegister.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
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
            // tPasswordRepeat
            // 
            this.tPasswordRepeat.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tPasswordRepeat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tPasswordRepeat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tPasswordRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tPasswordRepeat.Location = new System.Drawing.Point(169, 604);
            this.tPasswordRepeat.Multiline = true;
            this.tPasswordRepeat.Name = "tPasswordRepeat";
            this.tPasswordRepeat.Size = new System.Drawing.Size(494, 34);
            this.tPasswordRepeat.TabIndex = 21;
            this.tPasswordRepeat.Text = "Powtórz hasło";
            this.tPasswordRepeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tPasswordRepeat.Enter += new System.EventHandler(this.PasswordR_Clear);
            this.tPasswordRepeat.Leave += new System.EventHandler(this.PasswordR_Return);
            // 
            // userAwatar
            // 
            this.userAwatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userAwatar.Image = global::sklep.Properties.Resources.user0;
            this.userAwatar.Location = new System.Drawing.Point(126, 38);
            this.userAwatar.Name = "userAwatar";
            this.userAwatar.Size = new System.Drawing.Size(241, 278);
            this.userAwatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userAwatar.TabIndex = 0;
            this.userAwatar.TabStop = false;
            // 
            // Contrast
            // 
            this.Contrast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contrast.Image = global::sklep.Properties.Resources.contrast;
            this.Contrast.Location = new System.Drawing.Point(669, 3);
            this.Contrast.Name = "Contrast";
            this.Contrast.Size = new System.Drawing.Size(162, 114);
            this.Contrast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Contrast.TabIndex = 20;
            this.Contrast.TabStop = false;
            this.Contrast.Click += new System.EventHandler(this.Contrast_Click);
            // 
            // btnRegister_Apply
            // 
            this.btnRegister_Apply.BackColor = System.Drawing.Color.Lime;
            this.btnRegister_Apply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegister_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister_Apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRegister_Apply.Location = new System.Drawing.Point(169, 644);
            this.btnRegister_Apply.Name = "btnRegister_Apply";
            this.btnRegister_Apply.Size = new System.Drawing.Size(494, 34);
            this.btnRegister_Apply.TabIndex = 19;
            this.btnRegister_Apply.Text = "Zatwierdź";
            this.btnRegister_Apply.UseVisualStyleBackColor = false;
            this.btnRegister_Apply.Click += new System.EventHandler(this.btnRegister_Apply_Click_1);
            // 
            // userChange_Left
            // 
            this.userChange_Left.Dock = System.Windows.Forms.DockStyle.Right;
            this.userChange_Left.Image = global::sklep.Properties.Resources.left_arrow;
            this.userChange_Left.Location = new System.Drawing.Point(3, 38);
            this.userChange_Left.Name = "userChange_Left";
            this.userChange_Left.Size = new System.Drawing.Size(117, 278);
            this.userChange_Left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.userChange_Left.TabIndex = 11;
            this.userChange_Left.TabStop = false;
            this.userChange_Left.Click += new System.EventHandler(this.userChange_Left_Click);
            // 
            // userChange_Right
            // 
            this.userChange_Right.Dock = System.Windows.Forms.DockStyle.Left;
            this.userChange_Right.Image = global::sklep.Properties.Resources.right_arrow;
            this.userChange_Right.Location = new System.Drawing.Point(373, 38);
            this.userChange_Right.Name = "userChange_Right";
            this.userChange_Right.Size = new System.Drawing.Size(118, 278);
            this.userChange_Right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.userChange_Right.TabIndex = 12;
            this.userChange_Right.TabStop = false;
            this.userChange_Right.Click += new System.EventHandler(this.userChange_Right_Click);
            // 
            // tEmail
            // 
            this.tEmail.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tEmail.Location = new System.Drawing.Point(169, 524);
            this.tEmail.Multiline = true;
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(494, 34);
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
            this.tUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tUser.Location = new System.Drawing.Point(169, 484);
            this.tUser.Multiline = true;
            this.tUser.Name = "tUser";
            this.tUser.Size = new System.Drawing.Size(494, 34);
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
            this.tPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tPassword.Location = new System.Drawing.Point(169, 564);
            this.tPassword.Multiline = true;
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(494, 34);
            this.tPassword.TabIndex = 16;
            this.tPassword.Text = "Hasło";
            this.tPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tPassword.Enter += new System.EventHandler(this.Password_Clear);
            this.tPassword.Leave += new System.EventHandler(this.Password_Return);
            // 
            // btnMinimalize
            // 
            this.btnMinimalize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimalize.Image = global::sklep.Properties.Resources.minimize_sign;
            this.btnMinimalize.Location = new System.Drawing.Point(1130, 0);
            this.btnMinimalize.Name = "btnMinimalize";
            this.btnMinimalize.Size = new System.Drawing.Size(35, 40);
            this.btnMinimalize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimalize.TabIndex = 7;
            this.btnMinimalize.TabStop = false;
            this.btnMinimalize.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 40);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 6;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = global::sklep.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(1165, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 40);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 11;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnMinimalize_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(82)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnMinimalize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 40);
            this.panel1.TabIndex = 12;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.boxRegister, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 810);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // boxRegister
            // 
            this.boxRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(82)))), ((int)(((byte)(81)))));
            this.boxRegister.ColumnCount = 3;
            this.boxRegister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.boxRegister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.boxRegister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.boxRegister.Controls.Add(this.tUser, 1, 2);
            this.boxRegister.Controls.Add(this.tPasswordRepeat, 1, 5);
            this.boxRegister.Controls.Add(this.btnRegister_Apply, 1, 6);
            this.boxRegister.Controls.Add(this.tEmail, 1, 3);
            this.boxRegister.Controls.Add(this.tPassword, 1, 4);
            this.boxRegister.Controls.Add(this.tUser_Error, 2, 2);
            this.boxRegister.Controls.Add(this.tEmail_Error, 2, 3);
            this.boxRegister.Controls.Add(this.tPassword_Error, 2, 4);
            this.boxRegister.Controls.Add(this.tPasswordRepeat_Error, 2, 5);
            this.boxRegister.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.boxRegister.Controls.Add(this.Contrast, 2, 0);
            this.boxRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxRegister.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.boxRegister.Location = new System.Drawing.Point(183, 3);
            this.boxRegister.Name = "boxRegister";
            this.boxRegister.RowCount = 8;
            this.boxRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.boxRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.boxRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.boxRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.boxRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.boxRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.boxRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.boxRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.boxRegister.Size = new System.Drawing.Size(834, 804);
            this.boxRegister.TabIndex = 9;
            // 
            // tUser_Error
            // 
            this.tUser_Error.AutoSize = true;
            this.tUser_Error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tUser_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tUser_Error.ForeColor = System.Drawing.Color.Red;
            this.tUser_Error.Location = new System.Drawing.Point(669, 481);
            this.tUser_Error.Name = "tUser_Error";
            this.tUser_Error.Size = new System.Drawing.Size(162, 40);
            this.tUser_Error.TabIndex = 22;
            this.tUser_Error.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tEmail_Error
            // 
            this.tEmail_Error.AutoSize = true;
            this.tEmail_Error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tEmail_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tEmail_Error.ForeColor = System.Drawing.Color.Red;
            this.tEmail_Error.Location = new System.Drawing.Point(669, 521);
            this.tEmail_Error.Name = "tEmail_Error";
            this.tEmail_Error.Size = new System.Drawing.Size(162, 40);
            this.tEmail_Error.TabIndex = 23;
            this.tEmail_Error.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tPassword_Error
            // 
            this.tPassword_Error.AutoSize = true;
            this.tPassword_Error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tPassword_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tPassword_Error.ForeColor = System.Drawing.Color.Red;
            this.tPassword_Error.Location = new System.Drawing.Point(669, 561);
            this.tPassword_Error.Name = "tPassword_Error";
            this.tPassword_Error.Size = new System.Drawing.Size(162, 40);
            this.tPassword_Error.TabIndex = 24;
            this.tPassword_Error.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tPasswordRepeat_Error
            // 
            this.tPasswordRepeat_Error.AutoSize = true;
            this.tPasswordRepeat_Error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tPasswordRepeat_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tPasswordRepeat_Error.ForeColor = System.Drawing.Color.Red;
            this.tPasswordRepeat_Error.Location = new System.Drawing.Point(669, 601);
            this.tPasswordRepeat_Error.Name = "tPasswordRepeat_Error";
            this.tPasswordRepeat_Error.Size = new System.Drawing.Size(162, 40);
            this.tPasswordRepeat_Error.TabIndex = 25;
            this.tPasswordRepeat_Error.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.userAwatar, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.userChange_Right, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.userChange_Left, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(169, 123);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(494, 355);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1200, 850);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rejestracja";
            this.Load += new System.EventHandler(this.Register_Load);
            this.Resize += new System.EventHandler(this.Register_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.userAwatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userChange_Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userChange_Right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimalize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.boxRegister.ResumeLayout(false);
            this.boxRegister.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        


        #endregion
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.ImageList userAwatar_List;
        private System.Windows.Forms.ImageList listNawigation;
        private System.Windows.Forms.PictureBox btnMinimalize;
        private System.Windows.Forms.PictureBox userAwatar;
        private System.Windows.Forms.Button btnRegister_Apply;
        private System.Windows.Forms.PictureBox userChange_Left;
        private System.Windows.Forms.PictureBox userChange_Right;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.TextBox tUser;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.PictureBox Contrast;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tPasswordRepeat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel boxRegister;
        private System.Windows.Forms.Label tUser_Error;
        private System.Windows.Forms.Label tEmail_Error;
        private System.Windows.Forms.Label tPassword_Error;
        private System.Windows.Forms.Label tPasswordRepeat_Error;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}