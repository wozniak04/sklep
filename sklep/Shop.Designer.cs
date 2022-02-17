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
            this.lbUserName = new System.Windows.Forms.Label();
            this.userAwatar = new System.Windows.Forms.PictureBox();
            this.btn_flyMenu = new System.Windows.Forms.PictureBox();
            this.flyMenu = new System.Windows.Forms.Panel();
            this.shopItems_Items = new System.Windows.Forms.TableLayoutPanel();
            this.flyMenu_Category = new System.Windows.Forms.TableLayoutPanel();
            this.shopItems_ChangingPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.userAwatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_flyMenu)).BeginInit();
            this.flyMenu.SuspendLayout();
            this.shopItems_ChangingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbUserName.ForeColor = System.Drawing.Color.GreenYellow;
            this.lbUserName.Location = new System.Drawing.Point(149, 12);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(147, 20);
            this.lbUserName.TabIndex = 5;
            this.lbUserName.Text = "Nazwa użytkownika";
            this.lbUserName.Visible = false;
            // 
            // userAwatar
            // 
            this.userAwatar.BackColor = System.Drawing.Color.Transparent;
            this.userAwatar.Image = global::sklep.Properties.Resources.user0;
            this.userAwatar.Location = new System.Drawing.Point(12, 12);
            this.userAwatar.Name = "userAwatar";
            this.userAwatar.Size = new System.Drawing.Size(128, 128);
            this.userAwatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.userAwatar.TabIndex = 4;
            this.userAwatar.TabStop = false;
            this.userAwatar.Visible = false;
            // 
            // btn_flyMenu
            // 
            this.btn_flyMenu.BackColor = System.Drawing.Color.Transparent;
            this.btn_flyMenu.Image = global::sklep.Properties.Resources.menu;
            this.btn_flyMenu.Location = new System.Drawing.Point(309, 12);
            this.btn_flyMenu.Name = "btn_flyMenu";
            this.btn_flyMenu.Size = new System.Drawing.Size(75, 50);
            this.btn_flyMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_flyMenu.TabIndex = 1;
            this.btn_flyMenu.TabStop = false;
            this.btn_flyMenu.Click += new System.EventHandler(this.btn_flyMenu_Click);
            // 
            // flyMenu
            // 
            this.flyMenu.Controls.Add(this.flyMenu_Category);
            this.flyMenu.Controls.Add(this.lbUserName);
            this.flyMenu.Controls.Add(this.userAwatar);
            this.flyMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.flyMenu.Location = new System.Drawing.Point(0, 0);
            this.flyMenu.Name = "flyMenu";
            this.flyMenu.Size = new System.Drawing.Size(303, 761);
            this.flyMenu.TabIndex = 6;
            // 
            // shopItems_Items
            // 
            this.shopItems_Items.AutoSize = true;
            this.shopItems_Items.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(82)))), ((int)(((byte)(81)))));
            this.shopItems_Items.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.shopItems_Items.ColumnCount = 2;
            this.shopItems_Items.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.shopItems_Items.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.shopItems_Items.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.shopItems_Items.Location = new System.Drawing.Point(303, 756);
            this.shopItems_Items.Name = "shopItems_Items";
            this.shopItems_Items.RowCount = 4;
            this.shopItems_Items.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.shopItems_Items.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.shopItems_Items.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.shopItems_Items.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.shopItems_Items.Size = new System.Drawing.Size(881, 5);
            this.shopItems_Items.TabIndex = 8;
            // 
            // flyMenu_Category
            // 
            this.flyMenu_Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(82)))), ((int)(((byte)(81)))));
            this.flyMenu_Category.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.flyMenu_Category.ColumnCount = 1;
            this.flyMenu_Category.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.flyMenu_Category.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flyMenu_Category.Location = new System.Drawing.Point(0, 186);
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
            this.flyMenu_Category.Size = new System.Drawing.Size(303, 575);
            this.flyMenu_Category.TabIndex = 6;
            this.flyMenu_Category.Visible = false;
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
            this.shopItems_ChangingPanel.Controls.Add(this.pictureBox1, 0, 0);
            this.shopItems_ChangingPanel.Controls.Add(this.pictureBox2, 9, 0);
            this.shopItems_ChangingPanel.Location = new System.Drawing.Point(309, 68);
            this.shopItems_ChangingPanel.Name = "shopItems_ChangingPanel";
            this.shopItems_ChangingPanel.RowCount = 1;
            this.shopItems_ChangingPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.shopItems_ChangingPanel.Size = new System.Drawing.Size(870, 100);
            this.shopItems_ChangingPanel.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::sklep.Properties.Resources.left_arrow;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::sklep.Properties.Resources.right_arrow;
            this.pictureBox2.Location = new System.Drawing.Point(775, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(82)))), ((int)(((byte)(81)))));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(309, 186);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(870, 575);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.shopItems_ChangingPanel);
            this.Controls.Add(this.shopItems_Items);
            this.Controls.Add(this.flyMenu);
            this.Controls.Add(this.btn_flyMenu);
            this.Name = "Shop";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.userAwatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_flyMenu)).EndInit();
            this.flyMenu.ResumeLayout(false);
            this.flyMenu.PerformLayout();
            this.shopItems_ChangingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btn_flyMenu;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.PictureBox userAwatar;
        private System.Windows.Forms.Panel flyMenu;
        private System.Windows.Forms.TableLayoutPanel shopItems_Items;
        private System.Windows.Forms.TableLayoutPanel flyMenu_Category;
        private System.Windows.Forms.TableLayoutPanel shopItems_ChangingPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}