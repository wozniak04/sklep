using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace sklep
{
    public partial class Register : Form
    {
        public Register()
        {

            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(RoundCorner(0, 0, Width, Height, 20, 20));
            userAwatar.Image = userAwatar_List.Images[0];
        }
        Walidacja walid = new Walidacja();

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

                if (!walid.checkUsername(tUser.Text))
                {
                    tUser_Error.Text = "użytkownik o takiej nazwie istnieje";
                }
                else
                {
                    tUser_Error.Text = "";
                }
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
            else
            {
                if (!walid.checkPassword(tPassword.Text))
                {
                    tPassword_Error.Text = "hasło powinno zawierać 8 znakoów";
                }
                else
                {
                    tPassword_Error.Text = "";
                }
            }
           
        }

        private void PasswordR_Clear(object sender, EventArgs e)
        {
            if (tPasswordR.Text == "Powtórz Hasło")
            {
                tPasswordR.Clear();
            }
            
        }

        private void PasswordR_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tPasswordR.Text))
            {
                tPasswordR.Text = "Powtórz Hasło";
            }
           
            else
            {
                if (!walid.check2Password(tPassword.Text, tPasswordR.Text))
                {
                    tPasswordRepeat_Error.Text = "hasła są różne";
                }
                else 
                {
                    tPasswordRepeat_Error.Text = "";
                }
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
            else
            {
                if (!walid.checkemail(tEmail.Text))
                {
                    tEmail_Error.Text = "nie ma takiego maila";
                }
                else
                {
                    tEmail_Error.Text = "";
                }
            }
        }

        //information about registration
        private void btnRegister_Apply_Click_1(object sender, EventArgs e)
        {
            if (walid.czygit()) 
            {
                var data = new DataAcces();
                if (data.insert(tUser.Text, tPassword.Text, tEmail.Text))
                {
                    var login = new Logging();
                    login.ShowDialog();
                    this.Close();
                }
            }
            
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
            var kolor = new Kolory();

            if (this.BackColor == Color.FromArgb(kolor.kolor111,kolor.kolor112, kolor.kolor113))
            {
                this.BackColor = Color.FromArgb(kolor.kolor211, kolor.kolor212, kolor.kolor213);
                boxRegister.BackColor = Color.FromArgb(kolor.kolor221, kolor.kolor222, kolor.kolor223);
                tUser.BackColor = Color.FromArgb(kolor.kolor211, kolor.kolor212, kolor.kolor213);
                tPassword.BackColor = Color.FromArgb(kolor.kolor211, kolor.kolor212, kolor.kolor213);
                tEmail.BackColor = Color.FromArgb(kolor.kolor211, kolor.kolor212, kolor.kolor213);
            }
            else
            {
                this.BackColor = Color.FromArgb(kolor.kolor111, kolor.kolor112, kolor.kolor113);
                boxRegister.BackColor = Color.FromArgb(kolor.kolor121, kolor.kolor122, kolor.kolor123);
                tUser.BackColor = Color.FromArgb(kolor.kolor111, kolor.kolor112, kolor.kolor113);
                tPassword.BackColor = Color.FromArgb(kolor.kolor111, kolor.kolor112, kolor.kolor113);
                tEmail.BackColor = Color.FromArgb(kolor.kolor111, kolor.kolor112, kolor.kolor113);
            }
        }
        

        private void btnMinimalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
    }
}

