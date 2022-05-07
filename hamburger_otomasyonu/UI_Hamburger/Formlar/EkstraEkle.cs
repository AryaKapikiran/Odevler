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
    public partial class EkstraEkle : Form
    {
        public EkstraEkle()
        {
            InitializeComponent();
        }

       public static BaseRepository<Ekstra> ekstraRepository = new BaseRepository<Ekstra>();

        public void EkstraListele()
        {
            listView1.Items.Clear();

            foreach(Ekstra ekstra in ekstraRepository.GetList()) 
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = ekstra.ID.ToString();
                lvi.SubItems.Add(ekstra.EkstraName);
                lvi.SubItems.Add(ekstra.Fiyat.ToString());
                
                listView1.Items.Add(lvi);
            }
        }
        private void EkstraEkle_Load(object sender, EventArgs e)
        {
            EkstraListele();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Ekstra ekstra = new Ekstra();
            ekstra.EkstraName = txtekstraName.Text;
            ekstra.Fiyat = nudprice.Value;
            string result = ekstraRepository.Create(ekstra);
            MessageBox.Show(result);
            EkstraListele();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Ekstra updatedEkstra = ekstraRepository.FindByID(Convert.ToInt32(txtEkstraId.Text));

            updatedEkstra.EkstraName = txtekstraName.Text;
            updatedEkstra.Fiyat = nudprice.Value;
            string result = ekstraRepository.Update(updatedEkstra);
            MessageBox.Show(result);
            EkstraListele();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string result = ekstraRepository.Delete(Convert.ToInt32(txtEkstraId.Text));
            MessageBox.Show(result);
            EkstraListele();
        }
    }
}
