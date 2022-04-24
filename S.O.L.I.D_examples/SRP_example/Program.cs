using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //karşılama, Yemegin bilgilerinin girilmesi,onaylanması ,girilen bilgilerin bir arada gösterilmesi---- butun bu eylemlerin ayrı ayrı tanımlanması bir SRP örnegi 

            //karsılama 
            Information.Karsilama();

            //  Bilgilerin kullanıcıdan alınması

           Yemek yemek = YemekRepository.YemekEkle();

            //Bilgilerin bos gecilmemesi için onaylama

            bool isValid =YemekOnaylama.Onaylama(yemek);
            if (isValid== false)
            {
                Console.ReadLine();
                return;
            }

            //Bilgilerin kullanıcıya bir arada gösterilmesi

            YemekGoster.BilgiGoster(yemek);
            Console.Read();


        }
    }
}
