using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace sklep
{
    public partial class Shop : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr RoundCorner(
            int leftRect,
            int topRect,
            int rigthRect,
            int bottomRect,
            int widthEllipse,
            int heightEllipse
            );
        public Shop()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(RoundCorner(0, 0, Width, Height, 20, 20));
        }

        private void btn_flyMenu_Click(object sender, EventArgs e)
        {
            if (flyMenu.BackColor == Color.FromArgb(80, 82, 81))
            {
                flyMenu.BackColor = Color.Transparent;
                
                flyMenu_Category.Visible = false;
                
                userAwatar.Visible = false;
                lbUserName.Visible = false;
                btnClose.Visible = false;
                Contrast.Visible = false;
               
            }
            else { 
                
                flyMenu.BackColor = Color.FromArgb(80, 82, 81);
                
                flyMenu_Category.Visible = true;
                
                userAwatar.Visible = true;
                lbUserName.Visible = true;
                btnClose.Visible = true;
                Contrast.Visible = true;
                
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logging Logging = new Logging();
            Logging.ShowDialog();
            this.Close();
        }

        private void Contrast_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.FromArgb(90, 92, 91))
            {
                this.BackColor = Color.FromArgb(225, 227, 225);
                lbUserName.ForeColor = Color.Black;
                
                flyMenu.BackColor = BackColor = Color.FromArgb(225, 227, 225);
                
                flyMenu_Category.BackColor = Color.FromArgb(169, 171, 169);
                flyMenu_Category.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;

                shopItems_Items.BackColor = Color.FromArgb(169, 171, 169);
                shopItems_Items.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;

                shopItems_ChangingPanel.BackColor = Color.FromArgb(169, 171, 169);
                shopItems_ChangingPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            }
            else
            {
                this.BackColor = Color.FromArgb(90, 92, 91);
                lbUserName.ForeColor = Color.GreenYellow;

                flyMenu.BackColor = BackColor = Color.FromArgb(90, 92, 91);
                

                flyMenu_Category.BackColor = Color.FromArgb(80, 82, 81);
                flyMenu_Category.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                
                shopItems_Items.BackColor = Color.FromArgb(80, 82, 81);
                shopItems_Items.CellBorderStyle= TableLayoutPanelCellBorderStyle.Single;

                shopItems_ChangingPanel.BackColor = Color.FromArgb(80, 82, 81);
                shopItems_ChangingPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            }
        }
    }
}

