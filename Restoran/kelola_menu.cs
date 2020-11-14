using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran
{
    public partial class kelola_menu : Form
    {
        public int ID;
        public kelola_menu()
        {
            InitializeComponent();
        }
        public void Initial()
        {
            this.pictureBox2.Image = null; 
            this.ID = 0;
            this.txt_nama_menu.Text = "";
            this.txt_harga.Text = "0";
            this.txt_keterangan.Text = "";
            this.txt_foto.Text = "";
            this.btn_simpan.Enabled = true;
            this.btn_update.Enabled = false;
            this.btn_hapus.Enabled = false;
            MappingToDataGrid();
        }
        public void MappingToDataGrid()
        {
            dataGridView1.ClearSelection();
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Nama Menu", typeof(string));
            table.Columns.Add("Jenis", typeof(string));
            table.Columns.Add("Harga Satuan", typeof(decimal));
            table.Columns.Add("Keterangan", typeof(string));

            var getMenu = GetListMenu();
            
            foreach(var menu in getMenu)
            {
                var jenis = "";
                if(menu.jenis.Value == 1)
                {
                    jenis = "makanan";
                }
                else if (menu.jenis.Value == 2)
                {
                    jenis = "minuman";
                }
                table.Rows.Add(menu.id, menu.nama_menu, jenis,menu.harga_satuan,menu.keterangan);
            }

            dataGridView1.DataSource = table;
        }
        public List<tbl_menu> GetListMenu()
        {
            using (var ctx = new db_dataEntities())
            {
                var getMenu = ctx.tbl_menu.Where(o => o.is_active == 1).ToList();
                return getMenu;
            }
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
            Initial();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            ObjectCache cache = MemoryCache.Default;
            dynamic user = cache.Get("userLogin");
            var jenis = 0;
            if (this.cmb_jenis.SelectedItem == "Makanan")
            {
                jenis = 1;
            }
            else if(this.cmb_jenis.SelectedItem == "Minuman")
            {
                jenis = 2;
            }
            var menu = new tbl_menu()
            {
                is_active = 1,
                created_by = user.username,
                created_date = DateTime.Now,
                nama_menu = this.txt_nama_menu.Text,
                harga_satuan = decimal.Parse(this.txt_harga.Text),
                keterangan = this.txt_keterangan.Text,
                foto = this.txt_foto.Text,
                jenis = jenis
            };

            using (var ctx = new db_dataEntities())
            {
                ctx.tbl_menu.Add(menu);
                ctx.SaveChanges();
            }

            MessageBox.Show("Sukses Simpan");

            Initial();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }
  

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (e.RowIndex >= 0 && !string.IsNullOrEmpty(row.Cells[0].Value.ToString()))
            {
              
                var id = int.Parse(row.Cells[0].Value.ToString());
                using (var ctx = new db_dataEntities())
                {
                    var menu = ctx.tbl_menu.Where(o => o.id == id).FirstOrDefault();
                    this.txt_nama_menu.Text = menu.nama_menu;
                    this.txt_harga.Text = menu.harga_satuan.ToString();
                    this.txt_keterangan.Text = menu.keterangan;
                    this.txt_foto.Text = menu.foto;
                    if (!string.IsNullOrEmpty(menu.foto))
                    {
                        // display image in picture box  
                        pictureBox2.Image = new Bitmap(menu.foto);
                    }
                    else
                    {
                        pictureBox2.Image = null;
                    }
                    foreach(var jenis in this.cmb_jenis.Items)
                    {
                        var namaJenis = "";
                        if (menu.jenis == 1)
                        {
                            namaJenis = "Makanan";
                        }
                        else if (menu.jenis == 2)
                        {
                            namaJenis = "Minuman";
                        }

                        if(namaJenis == jenis)
                        {
                            this.cmb_jenis.SelectedItem = jenis.ToString();
                        }
                    }
                  
                }
                ID = id;
                this.btn_simpan.Enabled = false;
                this.btn_update.Enabled = true;
                this.btn_hapus.Enabled = true;
            }
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            ObjectCache cache = MemoryCache.Default;
            dynamic user = cache.Get("userLogin");

       
            var id = ID;

            if(id != 0)
            {
             
                using (var ctx = new db_dataEntities())
                {

                    var menu = ctx.tbl_menu.Where(o => o.id == id).FirstOrDefault();

                    var jenis = 0;
                    if (this.cmb_jenis.SelectedItem == "Makanan")
                    {
                        jenis = 1;
                    }
                    else if (this.cmb_jenis.SelectedItem == "Minuman")
                    {
                        jenis = 2;
                    }
                    menu.jenis = jenis;
                    menu.updated_by = user.username;
                    menu.updated_date = DateTime.Now;
                    menu.nama_menu = this.txt_nama_menu.Text;
                    menu.harga_satuan = decimal.Parse(this.txt_harga.Text);
                    menu.keterangan = this.txt_keterangan.Text;
                    menu.foto = this.txt_foto.Text;

                    ctx.tbl_menu.AddOrUpdate(menu);
                    ctx.SaveChanges();
                }

                MessageBox.Show("Sukses Update");

                Initial();
            }
          
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            ObjectCache cache = MemoryCache.Default;
            dynamic user = cache.Get("userLogin");

            int id = ID;

            if (id != 0)
            {

                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin mengahapus data ini?", "Warning",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (var ctx = new db_dataEntities())
                    {
                        var menu = ctx.tbl_menu.Where(o => o.id == id).FirstOrDefault();

                        menu.is_active = 0;
                        menu.deleted_by = user.username;
                        menu.deleted_date = DateTime.Now;

                        ctx.tbl_menu.AddOrUpdate(menu);
                        ctx.SaveChanges();
                    }
                    MessageBox.Show("Sukses Delete");
                    Initial();
                }
                else if (result == DialogResult.No)
                {
                    //code for No
                }
       
            }
          
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox2.Image = new Bitmap(open.FileName);
                // image file path  
                this.txt_foto.Text = open.FileName;
            }
        }
    }
}
