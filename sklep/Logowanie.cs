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

        private void button1_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
        }
    }
}
