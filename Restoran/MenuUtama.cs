using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran
{
    public partial class MenuUtama : Form
    {
        public MenuUtama()
        {
            InitializeComponent();
        }

        private void btn_menu_admin_Click(object sender, EventArgs e)
        {
           
            this.Hide();

            login_admin frm2 = new login_admin();
            frm2.Show();

           
        }

        private void MenuUtama_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
