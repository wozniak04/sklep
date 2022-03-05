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
            Region = System.Drawing.Region.FromHrgn(RoundCorner(0, 0, Width, Height, 20, 20));
            
        }
        private bool haslo { get; set; }
        private bool nazwa { get; set; }

        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 1;
        const int HTCAPTION = 2;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_NCHITTEST: 
                    if(m.Result == (IntPtr)HTCLIENT)
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

        private void Logging_Resize(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(RoundCorner(0, 0, Width, Height, 20, 20));
        }

        private void Logging_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Contrast_Click(object sender, EventArgs e)
        {
          
            if (this.BackColor == Color.FromArgb(90, 92, 91))
            {
                this.BackColor = Color.FromArgb(225, 227, 225);
                boxLogin.BackColor = Color.FromArgb(169, 171, 169);
                panel1.BackColor = Color.FromArgb(169, 171, 169);
                tUser.BackColor = Color.FromArgb(225, 227, 225);
                tPassword.BackColor = Color.FromArgb(225, 227, 225);
            }
            else {
                this.BackColor = Color.FromArgb(90, 92, 91);
                boxLogin.BackColor = Color.FromArgb(80, 82, 81);
                panel1.BackColor = Color.FromArgb(80, 82, 81);
                tUser.BackColor = Color.FromArgb(90, 92, 91);
                tPassword.BackColor = Color.FromArgb(90, 92, 91);   
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.nazwa == true && this.haslo == true)
            {
                this.Hide();
                var Shop = new Shop(tUser.Text);
                Shop.ShowDialog();
                this.Close();
            }
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var Register = new Register();
            Register.ShowDialog();
            this.Close();
        }
        private void User_Clear(object sender, EventArgs e)
        {
            if (tUser.Text == "Nazwa użytkownika")
            {
                tUser.Clear();
                tUser.Font = new Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold)));
            }
        }
        private void User_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tUser.Text))
            {
                tUser.Text = "Nazwa użytkownika";
                this.tUser.Font = new Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            }
            else
            {

                var data = new DataAcces();
                if (!data.getUser(tUser.Text.ToString()))
                {
                    tER_User.Text = "Taki użytkownik nie istnieje.";
                    this.nazwa = false;
                }
                else
                {
                    tER_User.Text = "";
                    this.nazwa = true;
                }



            }
        }
        private void Password_Clear(object sender, EventArgs e)
        {
            if (tPassword.Text != "Hasło")
            {
                tPassword.PasswordChar = '•';
            }
            else
            {
                if (tPassword.Text == "Hasło")
                {
                    tPassword.Clear();
                    if (tPassword.Text != "Hasło")
                    {
                        tPassword.PasswordChar = '•';
                    }
                    tPassword.Font = new Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold)));
                }
            }
        }
        private void Password_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tPassword.Text))
            {
                tPassword.Text = "Hasło";
                if (tPassword.Text == "Hasło")
                {
                    tPassword.PasswordChar = default;
                }
                this.tUser.Font = new Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            }
            else
            {
                if (this.nazwa == true)
                {
                    var data = new DataAcces();
                    if (!data.getpassword(tPassword.Text.ToString()))
                    {
                        tER_Password.Text = "Podane hasło jest złe.";
                        this.haslo = false;
                    }
                    else
                    {
                        tER_Password.Text = "";
                        this.haslo = true;
                    }
                }


            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Shop = new Shop(tUser.Text);
            Shop.ShowDialog();
            this.Close();
        }

        
    }
}
