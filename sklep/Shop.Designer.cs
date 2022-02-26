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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.flyMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAwatar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_flyMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimalize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.shopItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.shopItems.Location = new System.Drawing.Point(3, 3);
            this.shopItems.Name = "shopItems";
            this.shopItems.RowCount = 2;
            this.shopItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.shopItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.shopItems.Size = new System.Drawing.Size(883, 778);
            this.shopItems.TabIndex = 13;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox6.Location = new System.Drawing.Point(445, 392);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(434, 382);
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Location = new System.Drawing.Point(4, 392);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(434, 382);
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Location = new System.Drawing.Point(445, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(434, 381);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(434, 381);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(303, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(897, 810);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.tabPage1.Controls.Add(this.shopItems);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(889, 784);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sklep";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.vScrollBar1);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(889, 784);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Koszyk";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(82)))), ((int)(((byte)(81)))));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.pictureBox7, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(855, 113);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox7.Location = new System.Drawing.Point(4, 4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(120, 107);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 737);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 44);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(513, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 44);
            this.panel3.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(3, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Do zapłaty: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.Lime;
            this.label11.Location = new System.Drawing.Point(123, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(219, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "12211231223123 zł";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(858, 3);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(28, 778);
            this.vScrollBar1.TabIndex = 1;
            this.vScrollBar1.Visible = false;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1200, 850);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_flyMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimalize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.shopItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private TableLayoutPanel shopItems;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private VScrollBar vScrollBar1;
        private Panel panel2;
        private Panel panel3;
        private Label label10;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox7;
    }
}