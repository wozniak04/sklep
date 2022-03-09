using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.IO;

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

        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 1;
        const int HTCAPTION = 2;
        private string nazwa;
        public Shop(string nazwa)
        {
            this.nazwa = nazwa;
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(RoundCorner(0, 0, Width, Height, 20, 20));
            lbUserName.Text = nazwa;
            var polacz = new DataAcces();

            label1.Text = polacz.nazwa(1);
            pPrice1.Text = polacz.cena(1) + "zł";
            pDescripton1.Text = polacz.opis(1);
            label2.Text = polacz.nazwa(2);
            pPrice2.Text = polacz.cena(2) + "zł";
            pDescripton2.Text = polacz.opis(2);
            label3.Text = polacz.nazwa(3);
            pPrice3.Text = polacz.cena(3) + "zł";
            pDescripton3.Text = polacz.opis(3);
            label4.Text = polacz.nazwa(4);
            pPrice4.Text = polacz.cena(4) + "zł";
            pDescripton4.Text = polacz.opis(4);
            label5.Text = polacz.nazwa(5);
            pPrice5.Text = polacz.cena(5) + "zł";
            pDescription5.Text = polacz.opis(5);
            if (polacz.getZdjecie(nazwa) != null)
            {
                using (MemoryStream ms = new MemoryStream(polacz.getZdjecie(nazwa)))
                {
                    userAwatar.Image = Image.FromStream(ms);
                }
            }
        }   

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

        private void Shop_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(RoundCorner(0, 0, Width, Height, 20, 20));
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Shop_Resize(object sender, EventArgs e)
        {
            
            Region = System.Drawing.Region.FromHrgn(RoundCorner(0, 0, Width, Height, 20, 20));
        }
        
        

        private void btnMinimalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - move.X;
                this.Top += e.Y - move.Y;
            }
        }
        Point move;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = new Point(e.X, e.Y);
        }

        private void shopCart_Click(object sender, EventArgs e)
        {
            //opening a form of bought products
            Shop_Cart sCart = new Shop_Cart(nazwa);          
            sCart.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pol = new DataAcces();
            if(!pol.insertOferty(lbUserName.Text,(byte[])new ImageConverter().ConvertTo(pictureBox1.Image,typeof(byte[])) , label1.Text, int.Parse(pPrice1.Text.Remove(pPrice1.Text.Length - 2))))
            {
                MessageBox.Show("bład");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pol = new DataAcces();
            if(!pol.insertOferty(lbUserName.Text, (byte[])new ImageConverter().ConvertTo(pictureBox2.Image, typeof(byte[])), label2.Text, int.Parse(pPrice2.Text.Remove(pPrice2.Text.Length - 2))))
            {
                MessageBox.Show("bład");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var pol = new DataAcces();
            if(!pol.insertOferty(lbUserName.Text, (byte[])new ImageConverter().ConvertTo(pictureBox3.Image, typeof(byte[])), label3.Text, int.Parse(pPrice3.Text.Remove(pPrice3.Text.Length - 2))))
            {
                MessageBox.Show("bład");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var pol = new DataAcces();
            if(!pol.insertOferty(lbUserName.Text, (byte[])new ImageConverter().ConvertTo(pictureBox4.Image, typeof(byte[])), label4.Text, int.Parse(pPrice4.Text.Remove(pPrice4.Text.Length - 2))))
            {
                MessageBox.Show("bład");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var pol = new DataAcces();
            if(!pol.insertOferty(lbUserName.Text, (byte[])new ImageConverter().ConvertTo(pictureBox5.Image, typeof(byte[])), label5.Text, int.Parse(pPrice5.Text.Remove(pPrice5.Text.Length - 2))))
            {
                MessageBox.Show("bład");
            }
        }

        
    }
}

