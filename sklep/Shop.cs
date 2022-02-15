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
using Krypton.Toolkit;
namespace sklep
{
    public partial class Shop : KryptonForm
    {
        public Shop()
        {
            InitializeComponent();
        }

        private void btn_flyMenu_Click(object sender, EventArgs e)
        {
            flyMenu.StateCommon.Color1 = Color.FromArgb(80, 82, 81);
            
        }

        private void btn_flyMenu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            flyMenu.StateCommon.Color1 = Color.Transparent;
            
        }
    }
}
