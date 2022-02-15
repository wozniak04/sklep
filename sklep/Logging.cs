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
    }
}
