using System;
using System.Windows.Forms;
using System.Drawing;

namespace sklep
{
    partial class Shop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop));
            this.lbUserName = new System.Windows.Forms.Label();
            this.flyMenu = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.shopCart = new System.Windows.Forms.PictureBox();
            this.Contrast = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.flyMenu_Category = new System.Windows.Forms.TableLayoutPanel();
            this.userAwatar = new System.Windows.Forms.PictureBox();
            this.shopItems_ChangingPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_flyMenu = new System.Windows.Forms.PictureBox();
            this.btnMinimalize = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.listProducts = new System.Windows.Forms.ImageList(this.components);
            this.shopItems = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.flyMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAwatar)).BeginInit();
            this.shopItems_ChangingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_flyMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimalize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.shopItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbUserName.ForeColor = System.Drawing.Color.GreenYellow;
            this.lbUserName.Location = new System.Drawing.Point(120, 59);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(147, 20);
            this.lbUserName.TabIndex = 5;
            this.lbUserName.Text = "Nazwa użytkownika";
            // 
            // flyMenu
            // 
            this.flyMenu.Controls.Add(this.label9);
            this.flyMenu.Controls.Add(this.shopCart);
            this.flyMenu.Controls.Add(this.Contrast);
            this.flyMenu.Controls.Add(this.btnClose);
            this.flyMenu.Controls.Add(this.flyMenu_Category);
            this.flyMenu.Controls.Add(this.lbUserName);
            this.flyMenu.Controls.Add(this.userAwatar);
            this.flyMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.flyMenu.Location = new System.Drawing.Point(0, 0);
            this.flyMenu.Name = "flyMenu";
            this.flyMenu.Size = new System.Drawing.Size(303, 850);
            this.flyMenu.TabIndex = 6;
            this.flyMenu.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(233, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "0";
            this.label9.Visible = false;
            // 
            // shopCart
            // 
            this.shopCart.Image = ((System.Drawing.Image)(resources.GetObject("shopCart.Image")));
            this.shopCart.Location = new System.Drawing.Point(227, 119);
            this.shopCart.Name = "shopCart";
            this.shopCart.Size = new System.Drawing.Size(40, 40);
            this.shopCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shopCart.TabIndex = 9;
            this.shopCart.TabStop = false;
            this.shopCart.Click += new System.EventHandler(this.shopCart_Click);
            // 
            // Contrast
            // 
            this.Contrast.Image = global::sklep.Properties.Resources.contrast;
            this.Contrast.Location = new System.Drawing.Point(130, 119);
            this.Contrast.Name = "Contrast";
            this.Contrast.Size = new System.Drawing.Size(40, 40);
            this.Contrast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Contrast.TabIndex = 8;
            this.Contrast.TabStop = false;
            this.Contrast.Click += new System.EventHandler(this.Contrast_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::sklep.Properties.Resources.back;
            this.btnClose.Location = new System.Drawing.Point(176, 119);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 40);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 7;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // flyMenu_Category
            // 
            this.flyMenu_Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(82)))), ((int)(((byte)(81)))));
            this.flyMenu_Category.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.flyMenu_Category.ColumnCount = 1;
            this.flyMenu_Category.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.flyMenu_Category.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flyMenu_Category.Location = new System.Drawing.Point(0, 182);
            this.flyMenu_Category.Name = "flyMenu_Category";
            this.flyMenu_Category.RowCount = 9;
            this.flyMenu_Category.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.flyMenu_Category.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.flyMenu_Category.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.flyMenu_Category.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.flyMenu_Category.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.flyMenu_Category.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.flyMenu_Category.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.flyMenu_Category.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.flyMenu_Category.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.flyMenu_Category.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.flyMenu_Category.Size = new System.Drawing.Size(303, 668);
            this.flyMenu_Category.TabIndex = 6;
            // 
            // userAwatar
            // 
            this.userAwatar.BackColor = System.Drawing.Color.Transparent;
            this.userAwatar.Image = global::sklep.Properties.Resources.user0;
            this.userAwatar.Location = new System.Drawing.Point(8, 71);
            this.userAwatar.Name = "userAwatar";
            this.userAwatar.Size = new System.Drawing.Size(105, 97);
            this.userAwatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userAwatar.TabIndex = 4;
            this.userAwatar.TabStop = false;
            // 
            // shopItems_ChangingPanel
            // 
            this.shopItems_ChangingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(82)))), ((int)(((byte)(81)))));
            this.shopItems_ChangingPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.shopItems_ChangingPanel.ColumnCount = 10;
            this.shopItems_ChangingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.shopItems_ChangingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.shopItems_ChangingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.shopItems_ChangingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.shopItems_ChangingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.shopItems_ChangingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.shopItems_ChangingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.shopItems_ChangingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.shopItems_ChangingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.shopItems_ChangingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.shopItems_ChangingPanel.Controls.Add(this.label8, 8, 0);
            this.shopItems_ChangingPanel.Controls.Add(this.label7, 7, 0);
            this.shopItems_ChangingPanel.Controls.Add(this.label6, 6, 0);
            this.shopItems_ChangingPanel.Controls.Add(this.label5, 5, 0);
            this.shopItems_ChangingPanel.Controls.Add(this.label3, 3, 0);
            this.shopItems_ChangingPanel.Controls.Add(this.label2, 2, 0);
            this.shopItems_ChangingPanel.Controls.Add(this.pictureBox1, 0, 0);
            this.shopItems_ChangingPanel.Controls.Add(this.pictureBox2, 9, 0);
            this.shopItems_ChangingPanel.Controls.Add(this.label1, 1, 0);
            this.shopItems_ChangingPanel.Controls.Add(this.label4, 4, 0);
            this.shopItems_ChangingPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.shopItems_ChangingPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shopItems_ChangingPanel.Location = new System.Drawing.Point(303, 750);
            this.shopItems_ChangingPanel.Margin = new System.Windows.Forms.Padding(0);
            this.shopItems_ChangingPanel.Name = "shopItems_ChangingPanel";
            this.shopItems_ChangingPanel.RowCount = 1;
            this.shopItems_ChangingPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.shopItems_ChangingPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.shopItems_ChangingPanel.Size = new System.Drawing.Size(897, 100);
            this.shopItems_ChangingPanel.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(716, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 55);
            this.label8.TabIndex = 9;
            this.label8.Text = "8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(627, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 55);
            this.label7.TabIndex = 8;
            this.label7.Text = "7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(538, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 55);
            this.label6.TabIndex = 7;
            this.label6.Text = "6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 55);
            this.label5.TabIndex = 6;
            this.label5.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 55);
            this.label3.TabIndex = 4;
            this.label3.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::sklep.Properties.Resources.left_arrow;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::sklep.Properties.Resources.right_arrow;
            this.pictureBox2.Location = new System.Drawing.Point(805, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(93, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 98);
            this.label1.TabIndex = 2;
            this.label1.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 55);
            this.label4.TabIndex = 5;
            this.label4.Text = "4";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.btn_flyMenu);
            this.panel1.Controls.Add(this.btnMinimalize);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(303, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 40);
            this.panel1.TabIndex = 12;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btn_flyMenu
            // 
            this.btn_flyMenu.BackColor = System.Drawing.Color.Transparent;
            this.btn_flyMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_flyMenu.Image = global::sklep.Properties.Resources.menu;
            this.btn_flyMenu.Location = new System.Drawing.Point(0, 0);
            this.btn_flyMenu.Name = "btn_flyMenu";
            this.btn_flyMenu.Size = new System.Drawing.Size(86, 40);
            this.btn_flyMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_flyMenu.TabIndex = 1;
            this.btn_flyMenu.TabStop = false;
            this.btn_flyMenu.Click += new System.EventHandler(this.btn_flyMenu_Click);
            // 
            // btnMinimalize
            // 
            this.btnMinimalize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimalize.Image = global::sklep.Properties.Resources.minimize_sign;
            this.btnMinimalize.Location = new System.Drawing.Point(827, 0);
            this.btnMinimalize.Name = "btnMinimalize";
            this.btnMinimalize.Size = new System.Drawing.Size(35, 40);
            this.btnMinimalize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimalize.TabIndex = 12;
            this.btnMinimalize.TabStop = false;
            this.btnMinimalize.Click += new System.EventHandler(this.btnMinimalize_Click);
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.Image = global::sklep.Properties.Resources.close;
            this.btnBack.Location = new System.Drawing.Point(862, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(35, 40);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 11;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // listProducts
            // 
            this.listProducts.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.listProducts.ImageSize = new System.Drawing.Size(16, 16);
            this.listProducts.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // shopItems
            // 
            this.shopItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(82)))), ((int)(((byte)(81)))));
            this.shopItems.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.shopItems.ColumnCount = 2;
            this.shopItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.shopItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.shopItems.Controls.Add(this.pictureBox6, 1, 1);
            this.shopItems.Controls.Add(this.pictureBox5, 0, 1);
            this.shopItems.Controls.Add(this.pictureBox4, 1, 0);
            this.shopItems.Controls.Add(this.pictureBox3, 0, 0);
            this.shopItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shopItems.Location = new System.Drawing.Point(303, 40);
            this.shopItems.Name = "shopItems";
            this.shopItems.RowCount = 2;
            this.shopItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.shopItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.shopItems.Size = new System.Drawing.Size(897, 710);
            this.shopItems.TabIndex = 13;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox6.Location = new System.Drawing.Point(452, 358);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(441, 348);
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Location = new System.Drawing.Point(4, 358);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(441, 348);
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Location = new System.Drawing.Point(452, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(441, 347);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(441, 347);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1200, 850);
            this.Controls.Add(this.shopItems);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shopItems_ChangingPanel);
            this.Controls.Add(this.flyMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Shop";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.flyMenu.ResumeLayout(false);
            this.flyMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAwatar)).EndInit();
            this.shopItems_ChangingPanel.ResumeLayout(false);
            this.shopItems_ChangingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_flyMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimalize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.shopItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        private void btn_flyMenu_Click(object sender, EventArgs e)
        {
            if (flyMenu.Visible == true)
            {
                flyMenu.Visible = false;
            }

            else
            {
                flyMenu.Visible = true;
            }
                

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logging Logging = new Logging();
            Logging.ShowDialog();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Contrast_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.FromArgb(90, 92, 91))
            {
                this.BackColor = Color.FromArgb(225, 227, 225);
                lbUserName.ForeColor = Color.Black;

                flyMenu.BackColor = BackColor = Color.FromArgb(225, 227, 225);

                panel1.BackColor = Color.FromArgb(225, 227, 225);

                flyMenu_Category.BackColor = Color.FromArgb(169, 171, 169);
                flyMenu_Category.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;

                shopItems.BackColor = Color.FromArgb(169, 171, 169);
                shopItems.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;

                shopItems_ChangingPanel.BackColor = Color.FromArgb(169, 171, 169);
                shopItems_ChangingPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            }
            else
            {
                this.BackColor = Color.FromArgb(90, 92, 91);
                lbUserName.ForeColor = Color.GreenYellow;

                flyMenu.BackColor = BackColor = Color.FromArgb(90, 92, 91);

                panel1.BackColor = Color.FromArgb(90, 92, 91);

                flyMenu_Category.BackColor = Color.FromArgb(80, 82, 81);
                flyMenu_Category.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

                shopItems.BackColor = Color.FromArgb(80, 82, 81);
                shopItems.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

                shopItems_ChangingPanel.BackColor = Color.FromArgb(80, 82, 81);
                shopItems_ChangingPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            }
        }



        #endregion
        private System.Windows.Forms.PictureBox btn_flyMenu;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.PictureBox userAwatar;
        private System.Windows.Forms.Panel flyMenu;
        private System.Windows.Forms.TableLayoutPanel flyMenu_Category;
        private System.Windows.Forms.TableLayoutPanel shopItems_ChangingPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Contrast;
        private PictureBox btnMinimalize;
        private Label label9;
        private PictureBox shopCart;
        private ImageList listProducts;
        private TableLayoutPanel shopItems;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
    }
}