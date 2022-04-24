using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_example
{
    public class Information
    {
        //kullanıcıyı karsılama,hata mesajlarının gosterilmesi gibi eylemlerin oldugu bilgilendirme bölümü

        public static void Karsilama()
        {
            Console.WriteLine("Yemek oluşturma platformuna hosgeldiniz!");
            Console.ReadLine();
        }

        public static void ErrorMessage(string propertyAdi)
        {
            Console.WriteLine($"{propertyAdi} boş geçilemez!");
        }
    }
}
