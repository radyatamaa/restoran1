using Restoran.Models;
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

        public int jenis;
        public int pageNow;

        public void Initial()
        {
            MenuMapping(1, 0, 3);
            jenis = 1;
            pageNow = 1;
        }
        private void btn_menu_admin_Click(object sender, EventArgs e)
        {
           
            this.Hide();

            login_admin frm2 = new login_admin();
            frm2.Show();

           
        }
        public void MenuMapping(int jenis,int page = 0,int size = 3)
        {
            var menus = GetMenu(jenis, page, size);
            var menuTerlaris = GetMenuTerlaris(jenis, 0, 3);
            for (int i = 0; i <= 5; i++)
            {
                if (i >= 0 && i <= 2)
                {
                    var imageMenu = this.Controls.Find("pcb_menu" + i.ToString(), true).FirstOrDefault();
                    var namaMenu = this.Controls.Find("lbl_menu" + i.ToString(), true).FirstOrDefault();
                    var hargaMenu = this.Controls.Find("lbl_harga" + i.ToString(), true).FirstOrDefault();
                    var label = this.Controls.Find("lbl" + i.ToString(), true).FirstOrDefault();
                    var labelPcs = this.Controls.Find("lbl_pcs" + i.ToString(), true).FirstOrDefault();
                    var labelOrder = this.Controls.Find("lbl_order" + i.ToString(), true).FirstOrDefault();
                    var labelQty = this.Controls.Find("lbl_qty" + i.ToString(), true).FirstOrDefault();

                    try
                    {
                        var menu = menuTerlaris[i];
                        if (menuTerlaris[i].foto != null)
                        {
                            imageMenu.BackgroundImage = new Bitmap(menuTerlaris[i].foto);
                        }
                        else
                        {
                            imageMenu.BackgroundImage = null;
                        }
                        namaMenu.Text = menuTerlaris[i].nama_menu;
                        hargaMenu.Text = menuTerlaris[i].harga_satuan.ToString();

                        imageMenu.Visible = true;
                        namaMenu.Visible = true;
                        hargaMenu.Visible = true;
                        label.Visible = true;
                        labelPcs.Visible = true;
                        labelOrder.Visible = true;
                        labelQty.Visible = true;
                    }
                    catch(Exception e)
                    {
                        imageMenu.Visible = false;
                        namaMenu.Visible = false;
                        hargaMenu.Visible = false;
                        label.Visible = false;
                        labelPcs.Visible = false;
                        labelOrder.Visible = false;
                        labelQty.Visible = false;
                    }
                                                       

                }

                if (i >= 3 && i <= 5)
                {
                    var imageMenu = this.Controls.Find("pcb_menu" + i.ToString(), true).FirstOrDefault();
                    var namaMenu = this.Controls.Find("lbl_menu" + i.ToString(), true).FirstOrDefault();
                    var hargaMenu = this.Controls.Find("lbl_harga" + i.ToString(), true).FirstOrDefault();
                    var label = this.Controls.Find("lbl" + i.ToString(), true).FirstOrDefault();
                    var labelPcs = this.Controls.Find("lbl_pcs" + i.ToString(), true).FirstOrDefault();
                    var labelOrder = this.Controls.Find("lbl_order" + i.ToString(), true).FirstOrDefault();
                    var labelQty = this.Controls.Find("lbl_qty" + i.ToString(), true).FirstOrDefault();
                   
                    try
                    {
                        var index = 0;
                        if (i == 3)
                        {
                            index = 0;
                        }
                        else if (i == 4)
                        {
                            index = 1;
                        }
                        else if (i == 5)
                        {
                            index = 2;
                        }

                        var menu = menus[index];
                        if (menus[index].foto != null)
                        {
                            imageMenu.BackgroundImage = new Bitmap(menus[index].foto);
                        }
                        else
                        {
                            imageMenu.BackgroundImage = null;
                        }
                        namaMenu.Text = menus[index].nama_menu;
                        hargaMenu.Text = menus[index].harga_satuan.ToString();

                        imageMenu.Visible = true;
                        namaMenu.Visible = true;
                        hargaMenu.Visible = true;
                        label.Visible = true;
                        labelPcs.Visible = true;
                        labelOrder.Visible = true;
                        labelQty.Visible = true;
                    }
                    catch(Exception e)
                    {
                        imageMenu.Visible = false;
                        namaMenu.Visible = false;
                        hargaMenu.Visible = false;
                        label.Visible = false;
                        labelPcs.Visible = false;
                        labelOrder.Visible = false;
                        labelQty.Visible = false;
                    }
                                       
                }
                              
            }


            var nextPage = GetCountMenu(jenis, page + 1, size);
            if(nextPage > 0)
            {
                btn_next_page.Visible = true;
            }
            else
            {
                btn_next_page.Visible = false;
            }

            if(page > 0)
            {
                var backPage = GetCountMenu(jenis, page - 1, size);
                if (backPage > 0)
                {
                    btn_back_page.Visible = true;
                }
                else
                {
                    btn_back_page.Visible = false;
                }
            }
            else
            {
                btn_back_page.Visible = false;
            }
            

            
        }
        public List<tbl_menu> GetMenu(int jenis,int page = 0,int size = 3)
        {
            using (var ctx = new db_dataEntities())
            {
                var getMenu = ctx.tbl_menu
                .Where(o => o.jenis == jenis && o.is_active == 1)
                .OrderBy(o => o.nama_menu)
                .Skip(page * size)
                .Take(size)
                .ToList();

                return getMenu;
            }
        }
        public List<tbl_menu> GetMenuTerlaris(int jenis, int page = 0, int size = 3)
        {
            using (var ctx = new db_dataEntities())
            {
                var listMenuWithCount = new List<MenuWithCount>();
                
                var menuIds = ctx.tbl_detail_order.Where(o => o.is_active == 1).Select(o => o.id_menu).Distinct().ToList();
                
                foreach(var menuId in menuIds)
                {
                    var count = ctx.tbl_detail_order.Where(o => o.is_active == 1 && o.id_menu == menuId).Count();
                    var menuWCount = new MenuWithCount
                    {
                        IdMenu = menuId.Value,
                        Count = count
                    };

                    listMenuWithCount.Add(menuWCount);
                }
                var idslistMenuWithCount = listMenuWithCount
                     .OrderByDescending(c => c.Count)
                     .Skip(page * size)
                     .Take(size)
                     .Select(c => c.IdMenu);

                var getMenu = ctx.tbl_menu
               .Where(o => o.jenis == jenis && idslistMenuWithCount.Contains(o.id))       
               .ToList();

                return getMenu;

            }
        }
        public int GetCountMenu(int jenis, int page = 0, int size = 3)
        {
            using (var ctx = new db_dataEntities())
            {
                var getMenu = ctx.tbl_menu
                .Where(o => o.jenis == jenis)
                .OrderBy(o => o.nama_menu)
                .Skip(page * size)
                .Take(size)
                .Count();

                return getMenu;
            }
        }

        private void MenuUtama_Load(object sender, EventArgs e)
        {
            Initial();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_makanan_Click(object sender, EventArgs e)
        {
            MenuMapping(1, 0, 3);
            jenis = 1;
            pageNow = 1;
        }

        private void btn_minuman_Click(object sender, EventArgs e)
        {
            MenuMapping(2, 0, 3);
            jenis = 2;
            pageNow = 1;
        }

        private void btn_next_page_Click(object sender, EventArgs e)
        {
            pageNow = pageNow + 1;
            MenuMapping(jenis, pageNow, 3);
        }

        private void btn_back_page_Click(object sender, EventArgs e)
        {
            pageNow = pageNow - 1;
            MenuMapping(jenis, pageNow, 3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var order = new tbl_order
            //{
            //    created_by = "user",
            //    created_date = DateTime.Now,
            //    no_meja = no_meja.Text,
            //};

            //var detailOrder = new tbl_detail_order
            //{

            //};
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var jenis = 0;
            
            if (this.comboBox1.SelectedItem == "Minggu Ini")
            {
                jenis = 1;
            }
            else if (this.comboBox1.SelectedItem == "Bulan Ini")
            {
                jenis = 2;
            }
        }
    }
}
