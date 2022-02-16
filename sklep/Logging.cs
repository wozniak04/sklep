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
    public partial class Logging : Form
    {
        public Logging()
        {
            InitializeComponent();
        }

        
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Shop = new Shop();
            Shop.ShowDialog();
            this.Close();
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
                 var data = new DataAcces();
                 string nazwa = data.sprlogin(tUser.Text);
                 tER_User.Text = nazwa;
                
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
    }
}
