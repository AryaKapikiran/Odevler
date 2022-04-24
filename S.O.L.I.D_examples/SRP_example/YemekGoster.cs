using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_example
{
    public class YemekGoster
    {
        //girilen bilgilerin bir arada kullancıya gösterilmesi

        public static void BilgiGoster(Yemek yemek)
        {
            Console.WriteLine("Girdiğiniz yemegin adı: " + yemek.YemekAdi + ", Girmiş oldugunuz yemegin malzemeleri: " + yemek.Malzeme + ", girmiş oldugunuz yemeğin fiyatı: " + yemek.Fiyat);
            Console.ReadLine();
        }
    }
}
