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
    public partial class menu_laporan : Form
    {
        public menu_laporan()
        {
            InitializeComponent();
        }

        private void menu_laporan_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cetak_Click(object sender, EventArgs e)
        {

        }
    }
}
