using OCP_Example.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //kodlar ekleme icin acık, modification icin kapalı olmalı bu da şu demek müsteri yeni istekleriyle geldiğinde kodlar modification talep etmemeli fakat verilere ekleme yapılabilmeli.

            //Bir oyun dusunelim, her yeni kahraman ve özellik eklendiğinde gucu ve bu ozellikleri kahramana göre tanımlamak icin kodu degistirmek yerine bunu ocp prensibine göre tanımlayıp kahraman eklemeye acık, kod modificationuna kapalı yapalım.

            //Console acıldıgında ekrana eklenen kahramanlar, hesaplanan gucleri ve tanımlanan ozellikleri gelsin

            Mario mario = new Mario();
            mario.KahramanAdı = "Mario";
            decimal marioGuc = mario.GucHesapla(3);

            string marioOzellik = mario.Zıplıyor();

            Console.WriteLine("Kahraman adı: " +mario.KahramanAdı);

            Console.WriteLine(marioOzellik);

            Console.WriteLine("Güç: " + marioGuc);

            Console.ReadLine();

            
            
            

        }
    }
}
