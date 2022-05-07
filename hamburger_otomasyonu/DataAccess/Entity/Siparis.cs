using DataAccess.Context;
using DataAccess.Entity.Yetenek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Siparis:BaseEntity, ITutarHesapla
    {
        
        public int SiparisID { get; set; }

        public Boyut Boyut { get; set; }

        public List<Ekstra> Ekstra { get; set; }

        public HamburgerMenu HamburgerMenu { get; set; }

        public decimal ToplamTutar { get; set; }

        public int Adet { get; set; }

        

        public void Hesapla()
        {
            ToplamTutar = 0;
           
            
            //Menu Fiyatı
            ToplamTutar += HamburgerMenu.Fiyat;
            
            //Boyut fiyatı
            switch (Boyut)
            {
                case Boyut.küçük:
                    ToplamTutar += 0;
                    break;
                case Boyut.orta:
                    ToplamTutar += 3;
                    break;
                case Boyut.büyük:
                    ToplamTutar += 5;
                    break;
            }
            
            //Ekstra fiyatı
            foreach (Ekstra ekstra in Ekstra)
            {
                ToplamTutar += ekstra.Fiyat;
            }

            ToplamTutar *= Adet;




        }

        

        public override string ToString()
        {

            if (Ekstra.Count < 1)
            {
                return $"{HamburgerMenu} Menu,{Adet} Adet, {Boyut.ToString()} boy, Toplam: {ToplamTutar.ToString("C2")}";
            }
            else
            {
                string ekstraBilgi = "";
                foreach (Ekstra ekstra in Ekstra)
                {
                    ekstraBilgi += ekstra.EkstraName + "";

                }
                return $"{HamburgerMenu} Menu, Ekstra : ({ekstraBilgi}), {Adet} Adet, Toplam Tutar: {ToplamTutar.ToString("C2")}";

            }
        }
    }
}
