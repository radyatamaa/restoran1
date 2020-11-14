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
    public partial class login_admin : Form
    {
        public login_admin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            this.Hide();

            menu_admin frm2 = new menu_admin();
            frm2.Show();

        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {

            this.Hide();

            MenuUtama frm2 = new MenuUtama();
            frm2.Show();

        }

        private void login_admin_Load(object sender, EventArgs e)
        {

        }
    }
}
