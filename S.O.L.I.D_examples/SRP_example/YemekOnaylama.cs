using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_example
{
    public class YemekOnaylama
    {
        //kullanıcıdan alınan bilgilerin bos gecilmesine karsın onaylandıgı bölüm

        public static bool Onaylama(Yemek yemek)
        {
            if (string.IsNullOrWhiteSpace(yemek.YemekAdi))
            {
                Information.ErrorMessage("Yemek Adı");
                return false;
            }


            if (string.IsNullOrWhiteSpace(yemek.Malzeme))
            {
                Information.ErrorMessage("Yemek malzemeleri");
                return false;
            }

            if (string.IsNullOrWhiteSpace(yemek.Fiyat))
            {
                Information.ErrorMessage("Yemek fiyatı");
                return false;
            }

            return true;


        }
    }
}
