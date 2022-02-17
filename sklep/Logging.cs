using System;
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
    
    public partial class Logging : Form
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
        public Logging()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(RoundCorner(0,0,Width,Height,20,20));
        }
        private bool haslo { get; set; }
        private bool nazwa { get; set; }

        private void Contrast_Click(object sender, EventArgs e)
        {
          
            if (this.BackColor == Color.FromArgb(90, 92, 91))
            {
                this.BackColor = Color.FromArgb(225, 227, 225);
                boxLogin.BackColor = Color.FromArgb(169, 171, 169);
                tUser.BackColor = Color.FromArgb(225, 227, 225);
                tPassword.BackColor = Color.FromArgb(225, 227, 225);
            }
            else {
                this.BackColor = Color.FromArgb(90, 92, 91);
                boxLogin.BackColor = Color.FromArgb(80, 82, 81);
                tUser.BackColor = Color.FromArgb(90, 92, 91);
                tPassword.BackColor = Color.FromArgb(90, 92, 91);   
            }
        }
    }
}
