using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_example
{
    public class YemekRepository
    {
        //Yemek bilgilerinin kullanıcıdan alınması
        public static Yemek YemekEkle()
        {
            
            Yemek yemek = new Yemek();
            //yemek adı bilgisi
            Console.WriteLine("Lütfen yemek adı giriniz");
            yemek.YemekAdi = Console.ReadLine();
            //malzeme bilgisi
            Console.WriteLine("Lütfen " + yemek.YemekAdi + " adlı yemegin malzemelerini giriniz");
            yemek.Malzeme = Console.ReadLine();

            //fiyat bilgisi

            Console.WriteLine("Lütfen " +yemek.YemekAdi + " adlı yemegin fiyatını giriniz");
            yemek.Fiyat = Console.ReadLine();

            return yemek;


        }
    }
}
