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

        private void User_Clear(object sender, EventArgs e)
        {
            if (tUser.Text == "Nazwa użytkownika")
            {
                tUser.Clear();
            }
        }

        private void User_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tUser.Text))
            {
                tUser.Text = "Nazwa użytkownika";
            }
            else
            {
                var walid = new Walidacja();

                //tER_User.Text = walid.checkUsername(tUser.Text.ToString());
            }
        }

        private void Password_Clear(object sender, EventArgs e)
        {
            if (tPassword.Text == "Hasło")
            {
                tPassword.Clear();
            }
        }

        private void Password_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tPassword.Text))
            {
                tPassword.Text = "Hasło";
            }
        }

        private void Email_Clear(object sender, EventArgs e)
        {
            if (tEmail.Text == "Email")
            {
                tEmail.Clear();
            }
        }

        private void Email_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tEmail.Text))
            {
                tEmail.Text = "Email";
            }
        }

        //information about registration
        private void btnRegister_Apply_Click_1(object sender, EventArgs e)
        {
            Register_Alert regAlert = new Register_Alert();
            regAlert.Show();
        }

        //return to main window
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logging Logging = new Logging();
            Logging.ShowDialog();
            this.Close();
        }

        //Changing the user image functions
        int count = -1;
        private void userChange_Left_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count--;
            }

            userAwatar.Image = userAwatar_List.Images[count];
        }

        private void userChange_Right_Click(object sender, EventArgs e)
        {

            if (count < 12)
            {
                count++;
            }
            userAwatar.Image = userAwatar_List.Images[count];
        }
        //Close window function
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Contrast function
        private void Contrast_Click(object sender, EventArgs e)
        {

            if (this.BackColor == Color.FromArgb(90, 92, 91))
            {
                this.BackColor = Color.FromArgb(225, 227, 225);
                boxRegister.BackColor = Color.FromArgb(169, 171, 169);
                tUser.BackColor = Color.FromArgb(225, 227, 225);
                tPassword.BackColor = Color.FromArgb(225, 227, 225);
                tEmail.BackColor = Color.FromArgb(225, 227, 225);
            }
            else
            {
                this.BackColor = Color.FromArgb(90, 92, 91);
                boxRegister.BackColor = Color.FromArgb(80, 82, 81);
                tUser.BackColor = Color.FromArgb(90, 92, 91);
                tPassword.BackColor = Color.FromArgb(90, 92, 91);
                tEmail.BackColor = Color.FromArgb(90, 92, 91);
            }
        }



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

