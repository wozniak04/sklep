using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sklep
{
    public partial class Shop_Cart : Form
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
        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 1;
        const int HTCAPTION = 2;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    if (m.Result == (IntPtr)HTCLIENT)
                    {
                        m.Result = (IntPtr)HTCAPTION;
                    }
                    break;
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style = (cp.Style | 262144);
                return cp;
            }
        }
        public Shop_Cart()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(RoundCorner(0, 0, Width, Height, 20, 20));
        }

        private void Shop_Cart_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(RoundCorner(0, 0, Width, Height, 20, 20));
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Shop_Cart_Resize(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(RoundCorner(0, 0, Width, Height, 20, 20));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
}
