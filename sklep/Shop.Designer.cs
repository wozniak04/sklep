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
            ((System.ComponentModel.ISupportInitialize)(this.userAwatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_flyMenu)).BeginInit();
            this.flyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbUserName.ForeColor = System.Drawing.Color.GreenYellow;
            this.lbUserName.Location = new System.Drawing.Point(137, 12);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(147, 20);
            this.lbUserName.TabIndex = 5;
            this.lbUserName.Text = "Nazwa użytkownika";
            // 
            // userAwatar
            // 
            this.userAwatar.BackColor = System.Drawing.Color.Transparent;
            this.userAwatar.Dock = System.Windows.Forms.DockStyle.Top;
            this.userAwatar.Image = global::sklep.Properties.Resources.user0;
            this.userAwatar.Location = new System.Drawing.Point(0, 0);
            this.userAwatar.Name = "userAwatar";
            this.userAwatar.Size = new System.Drawing.Size(287, 128);
            this.userAwatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.userAwatar.TabIndex = 4;
            this.userAwatar.TabStop = false;
            // 
            // btn_flyMenu
            // 
            this.btn_flyMenu.BackColor = System.Drawing.Color.Transparent;
            this.btn_flyMenu.Image = global::sklep.Properties.Resources.menu;
            this.btn_flyMenu.Location = new System.Drawing.Point(331, 12);
            this.btn_flyMenu.Name = "btn_flyMenu";
            this.btn_flyMenu.Size = new System.Drawing.Size(75, 50);
            this.btn_flyMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_flyMenu.TabIndex = 1;
            this.btn_flyMenu.TabStop = false;
            this.btn_flyMenu.Click += new System.EventHandler(this.btn_flyMenu_Click);
            this.btn_flyMenu.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.btn_flyMenu_MouseDoubleClick);
            // 
            // flyMenu
            // 
            this.flyMenu.Controls.Add(this.lbUserName);
            this.flyMenu.Controls.Add(this.userAwatar);
            this.flyMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.flyMenu.Location = new System.Drawing.Point(0, 0);
            this.flyMenu.Name = "flyMenu";
            this.flyMenu.Size = new System.Drawing.Size(287, 761);
            this.flyMenu.TabIndex = 6;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.flyMenu);
            this.Controls.Add(this.btn_flyMenu);
            this.Name = "Shop";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.userAwatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_flyMenu)).EndInit();
            this.flyMenu.ResumeLayout(false);
            this.flyMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btn_flyMenu;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.PictureBox userAwatar;
        private System.Windows.Forms.Panel flyMenu;
    }
}