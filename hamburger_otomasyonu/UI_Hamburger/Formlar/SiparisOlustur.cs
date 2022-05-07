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
using BLL.Interface;
using DataAccess.Context;

namespace UI_Hamburger.Formlar
{
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur()
        {
            InitializeComponent();
        }
        


        public static BaseRepository<Siparis> siparisRepository = new BaseRepository<Siparis>();
        public decimal ToplamTutarHesapla()
        {
            decimal toplamtutar = 0;

            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                Siparis siparis = (Siparis)listBox1.Items[i];
                toplamtutar += siparis.ToplamTutar;

            }
            lbltoplam.Text = toplamtutar.ToString("C2");
            return toplamtutar;
        }

        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
           rbkucuk.Checked = true;

            foreach(HamburgerMenu hamburger in MenuEkle.hamburgermenuRepository.GetList())
            {
                cmbBurgerMenu.Items.Add(hamburger);
            }

            foreach (Ekstra ekstra in EkstraEkle.ekstraRepository.GetList())
            {
                CheckBox chk = new CheckBox();
                chk.Text = ekstra.EkstraName;
                chk.Tag = ekstra;
                flowLayoutPanel1.Controls.Add(chk);

            }
        }
        
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            
            siparis.HamburgerMenu = (HamburgerMenu)cmbBurgerMenu.SelectedItem;

            if (rbkucuk.Checked)
            {
                siparis.Boyut = Boyut.küçük;
            }

            else if (rbOrta.Checked)
            {
                siparis.Boyut = Boyut.orta;
            }
            else if (rbBüyük.Checked)
            {
                siparis.Boyut = Boyut.büyük;
            }
          
            siparis.Ekstra = new List<Ekstra>();

            foreach(CheckBox chk in flowLayoutPanel1.Controls)
            {
                if (chk.Checked)
                {
                    Ekstra ekstra =(Ekstra)chk.Tag;
                    siparis.Ekstra.Add(ekstra);
                }
            }

            siparis.Adet = Convert.ToInt32(nudAdet.Value);
            siparis.Hesapla();
            listBox1.Items.Add(siparis);
           
            ToplamTutarHesapla();
           
        }

        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Sipariş Tutarı :" + ToplamTutarHesapla().ToString("C2") + " Satın alma işlemini onaylamak istiyor musunuz?", "Ödeme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    Siparis siparis = (Siparis)listBox1.Items[i];
                    
                    siparisRepository.Create(siparis);

                }

                listBox1.Items.Clear();
                lbltoplam.Text = "0 TL";
                MessageBox.Show("Sipariş onaylandı!");
            }
        }
    }
}
