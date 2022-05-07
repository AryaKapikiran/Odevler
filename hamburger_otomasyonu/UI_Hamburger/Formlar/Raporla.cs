using DataAccess.Context;
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
    public partial class Raporla : Form
    {
        public Raporla()
        {
            InitializeComponent();
        }

        
            
        private void Raporla_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal ekstraciro = 0;
            
            int siparisAdet = 0;
          
           if (SiparisOlustur.siparisRepository.GetList().Count > 0)
            {
                foreach (Siparis siparis in SiparisOlustur.siparisRepository.GetList())
                {
                    ciro += siparis.ToplamTutar;

                    //foreach (Ekstra ekstra in siparis.Ekstra)
                    //{
                    //    ekstraciro += ekstra.Fiyat;
                    //}
                    
                    //ekstraciro *= siparis.Adet;
                    siparisAdet += siparis.Adet;


                }

                lblCiro.Text = ciro.ToString();
             // lblEkstraAdet.Text = ekstraciro.ToString();
                lblToplamSiparis.Text = siparisAdet.ToString();


            }
              

            
           

        }
    }
}
