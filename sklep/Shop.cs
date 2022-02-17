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

namespace sklep
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }

        private void btn_flyMenu_Click(object sender, EventArgs e)
        {
            if (flyMenu.BackColor == Color.FromArgb(80, 82, 81))
            {
                flyMenu.BackColor = Color.Transparent;
                
                flyMenu_Category.Visible = false;
                
                userAwatar.Visible = false;
                lbUserName.Visible = false;
               
               
            }
            else { 
                
                flyMenu.BackColor = Color.FromArgb(80, 82, 81);
                
                flyMenu_Category.Visible = true;
                
                userAwatar.Visible = true;
                lbUserName.Visible = true;
                
            }
            
        }

    }
}
