﻿using System;
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
    public partial class menu_admin : Form
    {
       
        public menu_admin()
        {
            InitializeComponent();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {

            this.Close();

            kelola_menu frm2 = new kelola_menu();
            frm2.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();

            login_admin frm2 = new login_admin();
            frm2.Show();

        }

        private void menu_admin_Load(object sender, EventArgs e)
        {

        }
    }
}
