using BLL.Interface;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Hamburger.Formlar
{
    public partial class MenuEkle : Form
    {
        public MenuEkle()
        {
            InitializeComponent();
        }

       public static BaseRepository<HamburgerMenu> hamburgermenuRepository = new BaseRepository<HamburgerMenu>();

        public void MenuListele()
        {
            listView1.Items.Clear();

            foreach (HamburgerMenu hamburgermenu in hamburgermenuRepository.GetList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = hamburgermenu.ID.ToString();
                lvi.SubItems.Add(hamburgermenu.MenuName);
                lvi.SubItems.Add(hamburgermenu.Fiyat.ToString());

                listView1.Items.Add(lvi);

            }
        }
        private void MenuEkle_Load(object sender, EventArgs e)
        {
           MenuListele();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HamburgerMenu hamburgerMenu = new HamburgerMenu();
            hamburgerMenu.MenuName =txtMenuName.Text;
            hamburgerMenu.Fiyat = nudprice.Value;
            string result = hamburgermenuRepository.Create(hamburgerMenu);
            MessageBox.Show(result);
            MenuListele();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            HamburgerMenu updatemenu = hamburgermenuRepository.FindByID(Convert.ToInt32(txtMenuId.Text));
            updatemenu.MenuName =txtMenuName.Text;
            updatemenu.Fiyat = nudprice.Value;

            string result = hamburgermenuRepository.Update(updatemenu);

            MessageBox.Show(result);

            MenuListele();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string result = hamburgermenuRepository.Delete(Convert.ToInt32(txtMenuId.Text));
            MessageBox.Show(result);
            MenuListele();
        }
    }
}
