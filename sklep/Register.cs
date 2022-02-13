using System;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

            tUser.MouseHover += new EventHandler(this.User_Clear);
            tUser.MouseLeave += new EventHandler(this.User_Return);
            
            tEmail.MouseHover += new EventHandler(this.Email_Clear);
            tEmail.MouseLeave += new EventHandler(this.Email_Return);

            tPassword.MouseHover += new EventHandler(this.Password_Clear);
            tPassword.MouseLeave += new EventHandler(this.Password_Return);

            tLogin.MouseHover += new EventHandler(this.Login_Clear);
            tLogin.MouseLeave += new EventHandler(this.Login_Return);
        }
        
        // User clear and return text functions 
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
        }

        // Login Email and return text functions 
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
        // Password clear and return text functions 
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

        // Login clear and return text functions 
        private void Login_Clear(object sender, EventArgs e)
        {
            if (tLogin.Text == "Login")
            {
                tLogin.Clear();
            }
        }
        private void Login_Return(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tLogin.Text))
            {
                tLogin.Text = "Login";
            }
        }

        //Show a notification about registration
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register_Alert regAlert = new Register_Alert();
            regAlert.Show();
        }

        //Return button 
        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
