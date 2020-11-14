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
    public partial class kelola_menu : Form
    {
        public kelola_menu()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {

            this.Hide();

            menu_admin frm2 = new menu_admin();
            frm2.Show();

        }

        private void kelola_menu_Load(object sender, EventArgs e)
        {

        }
    }
}
