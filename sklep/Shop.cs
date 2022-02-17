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
               
            }
            else { 
                
                flyMenu.BackColor = Color.FromArgb(80, 82, 81);
                
                flyMenu_Category.Visible = true;
                
                userAwatar.Visible = true;
                lbUserName.Visible = true;
                btnClose.Visible = true;
                
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
