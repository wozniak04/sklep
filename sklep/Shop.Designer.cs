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
            this.flyMenu_Category = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listProducts = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutRoot = new System.Windows.Forms.FlowLayoutPanel();
            this.produkt1 = new System.Windows.Forms.FlowLayoutPanel();
            this.nazwaP1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.produkt2 = new System.Windows.Forms.FlowLayoutPanel();
            this.nazwaP2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.produkt3 = new System.Windows.Forms.FlowLayoutPanel();
            this.nazwaP3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.produkt4 = new System.Windows.Forms.FlowLayoutPanel();
            this.nazwaP4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.produkt5 = new System.Windows.Forms.FlowLayoutPanel();
            this.nazwaP5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btn_flyMenu = new System.Windows.Forms.PictureBox();
            this.btnMinimalize = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.shopCart = new System.Windows.Forms.PictureBox();
            this.Contrast = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.userAwatar = new System.Windows.Forms.PictureBox();
            this.flyMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutRoot.SuspendLayout();
            this.produkt1.SuspendLayout();
            this.produkt2.SuspendLayout();
            this.produkt3.SuspendLayout();
            this.produkt4.SuspendLayout();
            this.produkt5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_flyMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimalize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAwatar)).BeginInit();
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
            // listProducts
            // 
            this.listProducts.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.listProducts.ImageSize = new System.Drawing.Size(16, 16);
            this.listProducts.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // flowLayoutRoot
            // 
            this.flowLayoutRoot.AutoScroll = true;
            this.flowLayoutRoot.Controls.Add(this.produkt1);
            this.flowLayoutRoot.Controls.Add(this.produkt2);
            this.flowLayoutRoot.Controls.Add(this.produkt3);
            this.flowLayoutRoot.Controls.Add(this.produkt4);
            this.flowLayoutRoot.Controls.Add(this.produkt5);
            this.flowLayoutRoot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flowLayoutRoot.Location = new System.Drawing.Point(309, 59);
            this.flowLayoutRoot.Name = "flowLayoutRoot";
            this.flowLayoutRoot.Size = new System.Drawing.Size(720, 537);
            this.flowLayoutRoot.TabIndex = 13;
            this.flowLayoutRoot.Click += new System.EventHandler(this.flowLayoutRoot_Click);
            // 
            // produkt1
            // 
            this.produkt1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.produkt1.Controls.Add(this.pictureBox1);
            this.produkt1.Controls.Add(this.nazwaP1);
            this.produkt1.Controls.Add(this.button1);
            this.produkt1.Location = new System.Drawing.Point(3, 3);
            this.produkt1.Name = "produkt1";
            this.produkt1.Size = new System.Drawing.Size(688, 104);
            this.produkt1.TabIndex = 0;
            // 
            // nazwaP1
            // 
            this.nazwaP1.AutoSize = true;
            this.nazwaP1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwaP1.Location = new System.Drawing.Point(109, 0);
            this.nazwaP1.Name = "nazwaP1";
            this.nazwaP1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.nazwaP1.Size = new System.Drawing.Size(97, 39);
            this.nazwaP1.TabIndex = 1;
            this.nazwaP1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(409, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(200, 23, 3, 3);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(152, 49);
            this.button1.TabIndex = 2;
            this.button1.TabStop = false;
            this.button1.Text = "sprawdź produkt";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // produkt2
            // 
            this.produkt2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.produkt2.Controls.Add(this.pictureBox2);
            this.produkt2.Controls.Add(this.nazwaP2);
            this.produkt2.Controls.Add(this.button2);
            this.produkt2.Location = new System.Drawing.Point(3, 113);
            this.produkt2.Name = "produkt2";
            this.produkt2.Size = new System.Drawing.Size(688, 104);
            this.produkt2.TabIndex = 1;
            // 
            // nazwaP2
            // 
            this.nazwaP2.AutoSize = true;
            this.nazwaP2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwaP2.Location = new System.Drawing.Point(109, 0);
            this.nazwaP2.Name = "nazwaP2";
            this.nazwaP2.Size = new System.Drawing.Size(97, 33);
            this.nazwaP2.TabIndex = 2;
            this.nazwaP2.Text = "label1";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(409, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(200, 23, 3, 3);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(152, 49);
            this.button2.TabIndex = 3;
            this.button2.TabStop = false;
            this.button2.Text = "sprawdź produkt";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // produkt3
            // 
            this.produkt3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.produkt3.Controls.Add(this.pictureBox3);
            this.produkt3.Controls.Add(this.nazwaP3);
            this.produkt3.Controls.Add(this.button3);
            this.produkt3.Location = new System.Drawing.Point(3, 223);
            this.produkt3.Name = "produkt3";
            this.produkt3.Size = new System.Drawing.Size(688, 104);
            this.produkt3.TabIndex = 2;
            // 
            // nazwaP3
            // 
            this.nazwaP3.AutoSize = true;
            this.nazwaP3.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwaP3.Location = new System.Drawing.Point(109, 0);
            this.nazwaP3.Name = "nazwaP3";
            this.nazwaP3.Size = new System.Drawing.Size(97, 33);
            this.nazwaP3.TabIndex = 2;
            this.nazwaP3.Text = "label1";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(409, 23);
            this.button3.Margin = new System.Windows.Forms.Padding(200, 23, 3, 3);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button3.Size = new System.Drawing.Size(152, 49);
            this.button3.TabIndex = 3;
            this.button3.TabStop = false;
            this.button3.Text = "sprawdź produkt";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // produkt4
            // 
            this.produkt4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.produkt4.Controls.Add(this.pictureBox4);
            this.produkt4.Controls.Add(this.nazwaP4);
            this.produkt4.Controls.Add(this.button4);
            this.produkt4.Location = new System.Drawing.Point(3, 333);
            this.produkt4.Name = "produkt4";
            this.produkt4.Size = new System.Drawing.Size(688, 104);
            this.produkt4.TabIndex = 3;
            // 
            // nazwaP4
            // 
            this.nazwaP4.AutoSize = true;
            this.nazwaP4.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwaP4.Location = new System.Drawing.Point(109, 0);
            this.nazwaP4.Name = "nazwaP4";
            this.nazwaP4.Size = new System.Drawing.Size(97, 33);
            this.nazwaP4.TabIndex = 2;
            this.nazwaP4.Text = "label1";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(409, 23);
            this.button4.Margin = new System.Windows.Forms.Padding(200, 23, 3, 3);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button4.Size = new System.Drawing.Size(152, 49);
            this.button4.TabIndex = 3;
            this.button4.TabStop = false;
            this.button4.Text = "sprawdź produkt";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // produkt5
            // 
            this.produkt5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.produkt5.Controls.Add(this.pictureBox5);
            this.produkt5.Controls.Add(this.nazwaP5);
            this.produkt5.Controls.Add(this.button5);
            this.produkt5.Location = new System.Drawing.Point(3, 443);
            this.produkt5.Name = "produkt5";
            this.produkt5.Size = new System.Drawing.Size(688, 104);
            this.produkt5.TabIndex = 4;
            // 
            // nazwaP5
            // 
            this.nazwaP5.AutoSize = true;
            this.nazwaP5.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwaP5.Location = new System.Drawing.Point(109, 0);
            this.nazwaP5.Name = "nazwaP5";
            this.nazwaP5.Size = new System.Drawing.Size(97, 33);
            this.nazwaP5.TabIndex = 2;
            this.nazwaP5.Text = "label1";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(409, 23);
            this.button5.Margin = new System.Windows.Forms.Padding(200, 23, 3, 3);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button5.Size = new System.Drawing.Size(152, 49);
            this.button5.TabIndex = 3;
            this.button5.TabStop = false;
            this.button5.Text = "sprawdź produkt";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sklep.Properties.Resources.cyg;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::sklep.Properties.Resources.dell;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::sklep.Properties.Resources.gam;
            this.pictureBox3.ImageLocation = "";
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 94);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::sklep.Properties.Resources.strze;
            this.pictureBox4.ImageLocation = "";
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 94);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::sklep.Properties.Resources.xkom;
            this.pictureBox5.ImageLocation = "";
            this.pictureBox5.Location = new System.Drawing.Point(3, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 94);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // btn_flyMenu
            // 
            this.btn_flyMenu.BackColor = System.Drawing.Color.Transparent;
            this.btn_flyMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_flyMenu.Image = global::sklep.Properties.Resources.menu;
            this.btn_flyMenu.Location = new System.Drawing.Point(0, 0);
            this.btn_flyMenu.Name = "btn_flyMenu";
            this.btn_flyMenu.Size = new System.Drawing.Size(64, 40);
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
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1200, 850);
            this.Controls.Add(this.flowLayoutRoot);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flyMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Shop";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.flyMenu.ResumeLayout(false);
            this.flyMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flowLayoutRoot.ResumeLayout(false);
            this.produkt1.ResumeLayout(false);
            this.produkt1.PerformLayout();
            this.produkt2.ResumeLayout(false);
            this.produkt2.PerformLayout();
            this.produkt3.ResumeLayout(false);
            this.produkt3.PerformLayout();
            this.produkt4.ResumeLayout(false);
            this.produkt4.PerformLayout();
            this.produkt5.ResumeLayout(false);
            this.produkt5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_flyMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimalize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAwatar)).EndInit();
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

                

            }
            else
            {
                this.BackColor = Color.FromArgb(90, 92, 91);
                lbUserName.ForeColor = Color.GreenYellow;

                flyMenu.BackColor = BackColor = Color.FromArgb(90, 92, 91);

                panel1.BackColor = Color.FromArgb(90, 92, 91);

                flyMenu_Category.BackColor = Color.FromArgb(80, 82, 81);
                flyMenu_Category.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

                
            }
        }



        #endregion
        private System.Windows.Forms.PictureBox btn_flyMenu;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.PictureBox userAwatar;
        private System.Windows.Forms.Panel flyMenu;
        private System.Windows.Forms.TableLayoutPanel flyMenu_Category;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Contrast;
        private PictureBox btnMinimalize;
        private Label label9;
        private PictureBox shopCart;
        private ImageList listProducts;
        private FlowLayoutPanel flowLayoutRoot;
        private FlowLayoutPanel produkt1;
        private PictureBox pictureBox1;
        private Label nazwaP1;
        private FlowLayoutPanel produkt2;
        private PictureBox pictureBox2;
        private FlowLayoutPanel produkt3;
        private PictureBox pictureBox3;
        private FlowLayoutPanel produkt4;
        private PictureBox pictureBox4;
        private FlowLayoutPanel produkt5;
        private PictureBox pictureBox5;
        private Label nazwaP2;
        private Label nazwaP3;
        private Label nazwaP4;
        private Label nazwaP5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}