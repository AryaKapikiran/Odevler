using CA_ArabaBuilder.Abstract;
using CA_ArabaBuilder.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ArabaBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArabaBuilder arabaAudi = new AudiConcrete();

            ArabaKullan kullan = new ArabaKullan();

            arabaAudi = new AudiConcrete();
            kullan.CarKullan(arabaAudi);

            Console.WriteLine(arabaAudi.Araba.ToString());

            Console.ReadLine();

            

            
            

        }
    }
}
