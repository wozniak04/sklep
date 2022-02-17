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
            userAwatar.Image = userAwatar_List.Images[0];
        }
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
            var Logging = new Logging();
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


    }
}

