using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace sklep
{
    public partial class Register : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr RoundCorner(
            int leftRect,
            int topRect,
            int rigthRect,
            int bottomRect,
            int widthEllipse,
            int heightEllipse
        );

        

        public Register()
        {
            
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(RoundCorner(0, 0, Width, Height, 20, 20));
            userAwatar.Image = userAwatar_List.Images[0];
        }

        private void btnMinimalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
    }
}

