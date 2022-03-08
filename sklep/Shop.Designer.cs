using System;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_flyMenu = new System.Windows.Forms.PictureBox();
            this.btnMinimalize = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.listProducts = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pPrice5 = new System.Windows.Forms.Label();
            this.pPrice4 = new System.Windows.Forms.Label();
            this.pPrice3 = new System.Windows.Forms.Label();
            this.pPrice2 = new System.Windows.Forms.Label();
            this.pPrice1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shopLayoutProduct = new System.Windows.Forms.TableLayoutPanel();
            this.pDescripton4 = new System.Windows.Forms.Label();
            this.pDescripton3 = new System.Windows.Forms.Label();
            this.pDescripton2 = new System.Windows.Forms.Label();
            this.pDescripton1 = new System.Windows.Forms.Label();
            this.pDescription5 = new System.Windows.Forms.Label();
            this.ShopLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flyMenu = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.userAwatar = new System.Windows.Forms.PictureBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.shopMenuOption = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.Contrast = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.shopCart = new System.Windows.Forms.PictureBox();
            this.flyMenu_Category = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_flyMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimalize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.shopLayoutProduct.SuspendLayout();
            this.ShopLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flyMenu.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAwatar)).BeginInit();
            this.shopMenuOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopCart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(82)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.btn_flyMenu);
            this.panel1.Controls.Add(this.btnMinimalize);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 41);
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
            this.btn_flyMenu.Size = new System.Drawing.Size(64, 41);
            this.btn_flyMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_flyMenu.TabIndex = 1;
            this.btn_flyMenu.TabStop = false;
            this.btn_flyMenu.Click += new System.EventHandler(this.btn_flyMenu_Click);
            // 
            // btnMinimalize
            // 
            this.btnMinimalize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimalize.Image = global::sklep.Properties.Resources.minimize_sign;
            this.btnMinimalize.Location = new System.Drawing.Point(1124, 0);
            this.btnMinimalize.Name = "btnMinimalize";
            this.btnMinimalize.Size = new System.Drawing.Size(35, 41);
            this.btnMinimalize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimalize.TabIndex = 12;
            this.btnMinimalize.TabStop = false;
            this.btnMinimalize.Click += new System.EventHandler(this.btnMinimalize_Click);
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.Image = global::sklep.Properties.Resources.close;
            this.btnBack.Location = new System.Drawing.Point(1159, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(35, 41);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(181, 633);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 31);
            this.label5.TabIndex = 25;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(181, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 31);
            this.label4.TabIndex = 24;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(181, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "label3";
            // 
            // pPrice5
            // 
            this.pPrice5.AutoSize = true;
            this.pPrice5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.pPrice5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pPrice5.Location = new System.Drawing.Point(713, 633);
            this.pPrice5.Name = "pPrice5";
            this.pPrice5.Size = new System.Drawing.Size(78, 62);
            this.pPrice5.TabIndex = 20;
            this.pPrice5.Text = "2200 zł";
            this.pPrice5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pPrice4
            // 
            this.pPrice4.AutoSize = true;
            this.pPrice4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrice4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.pPrice4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pPrice4.Location = new System.Drawing.Point(713, 475);
            this.pPrice4.Name = "pPrice4";
            this.pPrice4.Size = new System.Drawing.Size(82, 157);
            this.pPrice4.TabIndex = 19;
            this.pPrice4.Text = "3500 zł";
            this.pPrice4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pPrice3
            // 
            this.pPrice3.AutoSize = true;
            this.pPrice3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrice3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.pPrice3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pPrice3.Location = new System.Drawing.Point(713, 317);
            this.pPrice3.Name = "pPrice3";
            this.pPrice3.Size = new System.Drawing.Size(82, 157);
            this.pPrice3.TabIndex = 18;
            this.pPrice3.Text = "500 zł";
            this.pPrice3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pPrice2
            // 
            this.pPrice2.AutoSize = true;
            this.pPrice2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.pPrice2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pPrice2.Location = new System.Drawing.Point(713, 159);
            this.pPrice2.Name = "pPrice2";
            this.pPrice2.Size = new System.Drawing.Size(82, 157);
            this.pPrice2.TabIndex = 17;
            this.pPrice2.Text = "1800 zł";
            this.pPrice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pPrice1
            // 
            this.pPrice1.AutoSize = true;
            this.pPrice1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pPrice1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pPrice1.Location = new System.Drawing.Point(713, 1);
            this.pPrice1.Name = "pPrice1";
            this.pPrice1.Size = new System.Drawing.Size(82, 157);
            this.pPrice1.TabIndex = 16;
            this.pPrice1.Text = "1500 zł";
            this.pPrice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PaleGreen;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(802, 636);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 151);
            this.button5.TabIndex = 15;
            this.button5.Text = "kup";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PaleGreen;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(802, 478);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 151);
            this.button4.TabIndex = 12;
            this.button4.Text = "kup";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleGreen;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(802, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 151);
            this.button3.TabIndex = 9;
            this.button3.Text = "kup";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleGreen;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(802, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 151);
            this.button2.TabIndex = 5;
            this.button2.Text = "kup";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(802, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 151);
            this.button1.TabIndex = 0;
            this.button1.Text = "kup";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::sklep.Properties.Resources.cyg;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(181, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 157);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::sklep.Properties.Resources.dell;
            this.pictureBox2.Location = new System.Drawing.Point(4, 162);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(170, 151);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(4, 320);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(170, 151);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(4, 478);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(170, 151);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Image = global::sklep.Properties.Resources.gam;
            this.pictureBox5.Location = new System.Drawing.Point(4, 636);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(170, 151);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(181, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 157);
            this.label2.TabIndex = 22;
            this.label2.Text = "label2";
            // 
            // shopLayoutProduct
            // 
            this.shopLayoutProduct.AutoScroll = true;
            this.shopLayoutProduct.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.shopLayoutProduct.ColumnCount = 5;
            this.shopLayoutProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.shopLayoutProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.shopLayoutProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.shopLayoutProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.shopLayoutProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.shopLayoutProduct.Controls.Add(this.pDescripton4, 2, 3);
            this.shopLayoutProduct.Controls.Add(this.pDescripton3, 2, 2);
            this.shopLayoutProduct.Controls.Add(this.pDescripton2, 2, 1);
            this.shopLayoutProduct.Controls.Add(this.pDescripton1, 2, 0);
            this.shopLayoutProduct.Controls.Add(this.label2, 1, 1);
            this.shopLayoutProduct.Controls.Add(this.pictureBox5, 0, 4);
            this.shopLayoutProduct.Controls.Add(this.pictureBox4, 0, 3);
            this.shopLayoutProduct.Controls.Add(this.pictureBox3, 0, 2);
            this.shopLayoutProduct.Controls.Add(this.pictureBox2, 0, 1);
            this.shopLayoutProduct.Controls.Add(this.label1, 1, 0);
            this.shopLayoutProduct.Controls.Add(this.pictureBox1, 0, 0);
            this.shopLayoutProduct.Controls.Add(this.button1, 4, 0);
            this.shopLayoutProduct.Controls.Add(this.button2, 4, 1);
            this.shopLayoutProduct.Controls.Add(this.button3, 4, 2);
            this.shopLayoutProduct.Controls.Add(this.button4, 4, 3);
            this.shopLayoutProduct.Controls.Add(this.button5, 4, 4);
            this.shopLayoutProduct.Controls.Add(this.pPrice1, 3, 0);
            this.shopLayoutProduct.Controls.Add(this.pPrice2, 3, 1);
            this.shopLayoutProduct.Controls.Add(this.pPrice3, 3, 2);
            this.shopLayoutProduct.Controls.Add(this.pPrice4, 3, 3);
            this.shopLayoutProduct.Controls.Add(this.pPrice5, 3, 4);
            this.shopLayoutProduct.Controls.Add(this.label3, 1, 2);
            this.shopLayoutProduct.Controls.Add(this.label4, 1, 3);
            this.shopLayoutProduct.Controls.Add(this.pDescription5, 2, 4);
            this.shopLayoutProduct.Controls.Add(this.label5, 1, 4);
            this.shopLayoutProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shopLayoutProduct.Location = new System.Drawing.Point(301, 3);
            this.shopLayoutProduct.Name = "shopLayoutProduct";
            this.shopLayoutProduct.RowCount = 5;
            this.shopLayoutProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.shopLayoutProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.shopLayoutProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.shopLayoutProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.shopLayoutProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.shopLayoutProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.shopLayoutProduct.Size = new System.Drawing.Size(890, 791);
            this.shopLayoutProduct.TabIndex = 13;
            // 
            // pDescripton4
            // 
            this.pDescripton4.AutoSize = true;
            this.pDescripton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDescripton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pDescripton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pDescripton4.Location = new System.Drawing.Point(447, 475);
            this.pDescripton4.Name = "pDescripton4";
            this.pDescripton4.Size = new System.Drawing.Size(259, 157);
            this.pDescripton4.TabIndex = 29;
            this.pDescripton4.Text = "opis";
            // 
            // pDescripton3
            // 
            this.pDescripton3.AutoSize = true;
            this.pDescripton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDescripton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pDescripton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pDescripton3.Location = new System.Drawing.Point(447, 317);
            this.pDescripton3.Name = "pDescripton3";
            this.pDescripton3.Size = new System.Drawing.Size(259, 157);
            this.pDescripton3.TabIndex = 28;
            this.pDescripton3.Text = "opis";
            // 
            // pDescripton2
            // 
            this.pDescripton2.AutoSize = true;
            this.pDescripton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDescripton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pDescripton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pDescripton2.Location = new System.Drawing.Point(447, 159);
            this.pDescripton2.Name = "pDescripton2";
            this.pDescripton2.Size = new System.Drawing.Size(259, 157);
            this.pDescripton2.TabIndex = 27;
            this.pDescripton2.Text = "opis";
            // 
            // pDescripton1
            // 
            this.pDescripton1.AutoSize = true;
            this.pDescripton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDescripton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pDescripton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pDescripton1.Location = new System.Drawing.Point(447, 1);
            this.pDescripton1.Name = "pDescripton1";
            this.pDescripton1.Size = new System.Drawing.Size(259, 157);
            this.pDescripton1.TabIndex = 26;
            this.pDescripton1.Text = "opis";
            // 
            // pDescription5
            // 
            this.pDescription5.AutoSize = true;
            this.pDescription5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDescription5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pDescription5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pDescription5.Location = new System.Drawing.Point(447, 633);
            this.pDescription5.Name = "pDescription5";
            this.pDescription5.Size = new System.Drawing.Size(259, 157);
            this.pDescription5.TabIndex = 30;
            this.pDescription5.Text = "opis";
            // 
            // ShopLayout
            // 
            this.ShopLayout.ColumnCount = 1;
            this.ShopLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ShopLayout.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.ShopLayout.Controls.Add(this.panel1, 0, 0);
            this.ShopLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShopLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.ShopLayout.Location = new System.Drawing.Point(0, 0);
            this.ShopLayout.Name = "ShopLayout";
            this.ShopLayout.RowCount = 2;
            this.ShopLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ShopLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ShopLayout.Size = new System.Drawing.Size(1200, 850);
            this.ShopLayout.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.shopLayoutProduct, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flyMenu, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1194, 797);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flyMenu
            // 
            this.flyMenu.ColumnCount = 1;
            this.flyMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.flyMenu.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.flyMenu.Controls.Add(this.shopMenuOption, 0, 1);
            this.flyMenu.Controls.Add(this.flyMenu_Category, 0, 2);
            this.flyMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyMenu.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.flyMenu.Location = new System.Drawing.Point(3, 3);
            this.flyMenu.Name = "flyMenu";
            this.flyMenu.RowCount = 3;
            this.flyMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.flyMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.flyMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.flyMenu.Size = new System.Drawing.Size(292, 791);
            this.flyMenu.TabIndex = 17;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.userAwatar, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lbUserName, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(286, 310);
            this.tableLayoutPanel5.TabIndex = 19;
            // 
            // userAwatar
            // 
            this.userAwatar.BackColor = System.Drawing.Color.Transparent;
            this.userAwatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userAwatar.Image = global::sklep.Properties.Resources.user0;
            this.userAwatar.Location = new System.Drawing.Point(3, 3);
            this.userAwatar.Name = "userAwatar";
            this.userAwatar.Size = new System.Drawing.Size(137, 304);
            this.userAwatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userAwatar.TabIndex = 4;
            this.userAwatar.TabStop = false;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbUserName.Location = new System.Drawing.Point(153, 0);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(130, 310);
            this.lbUserName.TabIndex = 5;
            this.lbUserName.Text = "Nazwa użytkownika";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shopMenuOption
            // 
            this.shopMenuOption.ColumnCount = 3;
            this.shopMenuOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.shopMenuOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.shopMenuOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.shopMenuOption.Controls.Add(this.label9, 2, 0);
            this.shopMenuOption.Controls.Add(this.Contrast, 0, 1);
            this.shopMenuOption.Controls.Add(this.btnClose, 1, 1);
            this.shopMenuOption.Controls.Add(this.shopCart, 2, 1);
            this.shopMenuOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shopMenuOption.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.shopMenuOption.Location = new System.Drawing.Point(3, 319);
            this.shopMenuOption.Name = "shopMenuOption";
            this.shopMenuOption.RowCount = 2;
            this.shopMenuOption.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.shopMenuOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.shopMenuOption.Size = new System.Drawing.Size(286, 73);
            this.shopMenuOption.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(193, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 30);
            this.label9.TabIndex = 10;
            this.label9.Text = "0";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label9.UseCompatibleTextRendering = true;
            this.label9.Visible = false;
            // 
            // Contrast
            // 
            this.Contrast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contrast.Image = global::sklep.Properties.Resources.contrast;
            this.Contrast.Location = new System.Drawing.Point(3, 33);
            this.Contrast.Name = "Contrast";
            this.Contrast.Size = new System.Drawing.Size(89, 37);
            this.Contrast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Contrast.TabIndex = 8;
            this.Contrast.TabStop = false;
            this.Contrast.Click += new System.EventHandler(this.Contrast_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Image = global::sklep.Properties.Resources.power_off;
            this.btnClose.Location = new System.Drawing.Point(98, 33);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 37);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 7;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // shopCart
            // 
            this.shopCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shopCart.Image = ((System.Drawing.Image)(resources.GetObject("shopCart.Image")));
            this.shopCart.Location = new System.Drawing.Point(193, 33);
            this.shopCart.Name = "shopCart";
            this.shopCart.Size = new System.Drawing.Size(90, 37);
            this.shopCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shopCart.TabIndex = 9;
            this.shopCart.TabStop = false;
            this.shopCart.Click += new System.EventHandler(this.shopCart_Click);
            // 
            // flyMenu_Category
            // 
            this.flyMenu_Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(82)))), ((int)(((byte)(81)))));
            this.flyMenu_Category.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.flyMenu_Category.ColumnCount = 1;
            this.flyMenu_Category.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.flyMenu_Category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyMenu_Category.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.flyMenu_Category.Location = new System.Drawing.Point(3, 398);
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
            this.flyMenu_Category.Size = new System.Drawing.Size(286, 390);
            this.flyMenu_Category.TabIndex = 6;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1200, 850);
            this.Controls.Add(this.ShopLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(360, 718);
            this.Name = "Shop";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Shop_Load);
            this.Resize += new System.EventHandler(this.Shop_Resize);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_flyMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimalize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.shopLayoutProduct.ResumeLayout(false);
            this.shopLayoutProduct.PerformLayout();
            this.ShopLayout.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flyMenu.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAwatar)).EndInit();
            this.shopMenuOption.ResumeLayout(false);
            this.shopMenuOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopCart)).EndInit();
            this.ResumeLayout(false);

        }

        private void btn_flyMenu_Click(object sender, EventArgs e)
        {
            if (flyMenu.Visible == true)
            {
                flyMenu.Visible = false;
                tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.Absolute;
                tableLayoutPanel1.ColumnStyles[0].Width = 0;
                
            }

            else
            {
                flyMenu.Visible = true;
                tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.Percent;
                tableLayoutPanel1.ColumnStyles[0].Width = 25;
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
                
                shopLayoutProduct.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
                shopLayoutProduct.BackColor = BackColor = Color.FromArgb(225, 227, 225);

                void ChangeLabelColor(Control control)
                {
                    if (control is Label)
                    {
                        Label lbl = (Label)control;
                        if (lbl.Text.StartsWith("opis") || lbl.Name.StartsWith("label") || lbl.Name.StartsWith("pPrice"))
                        {
                            lbl.ForeColor = Color.Black;
                        }
                    }
                    else
                    {
                        foreach (Control child in control.Controls)
                        {
                            ChangeLabelColor(child);
                        }
                    }
                }
                ChangeLabelColor(this);
            }
            else
            {
                //128; 255; 128
                this.BackColor = Color.FromArgb(90, 92, 91);
                lbUserName.ForeColor = Color.GreenYellow;
                flyMenu.BackColor = BackColor = Color.FromArgb(90, 92, 91);

                void ChangeLabelColor2(Control control)
                {
                    if (control is Label)
                    {
                        Label lbl = (Label)control;
                        if (lbl.Text.StartsWith("opis") || lbl.Name.StartsWith("label") || lbl.Name.StartsWith("pPrice"))
                        {
                            lbl.ForeColor = Color.FromArgb(128, 255, 128);
                        }
                    }
                    else
                    {
                        foreach (Control child in control.Controls)
                        {
                            ChangeLabelColor2(child);
                        }
                    }
                }
                ChangeLabelColor2(this);
                panel1.BackColor = Color.FromArgb(90, 92, 91);

                flyMenu_Category.BackColor = Color.FromArgb(80, 82, 81);
                flyMenu_Category.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

                shopLayoutProduct.BackColor = BackColor = Color.FromArgb(90, 92, 91);
                shopLayoutProduct.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            }
        }

        



        #endregion
        private System.Windows.Forms.PictureBox btn_flyMenu;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Panel panel1;
        private PictureBox btnMinimalize;
        private ImageList listProducts;
        private TableLayoutPanel shopLayoutProduct;
        private Label label2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label pPrice1;
        private Label pPrice2;
        private Label pPrice3;
        private Label pPrice4;
        private Label pPrice5;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label pDescripton4;
        private Label pDescripton3;
        private Label pDescripton2;
        private Label pDescripton1;
        private TableLayoutPanel ShopLayout;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel flyMenu;
        private TableLayoutPanel tableLayoutPanel5;
        private PictureBox userAwatar;
        private Label lbUserName;
        private TableLayoutPanel shopMenuOption;
        private Label label9;
        private PictureBox Contrast;
        private PictureBox btnClose;
        private PictureBox shopCart;
        private TableLayoutPanel flyMenu_Category;
        private Label pDescription5;
    }
}