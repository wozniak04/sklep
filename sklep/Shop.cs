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
            flyMenu.BackColor = Color.FromArgb(80, 82, 81);
            
        }

        private void btn_flyMenu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            flyMenu.BackColor = Color.Transparent;
            
        }
    }
}
