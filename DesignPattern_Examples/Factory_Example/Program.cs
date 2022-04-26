using Factory_Example.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            Araba bmw = factory.FactoryMethod(ArabaMarka.BMW);
            Araba kia = factory.FactoryMethod(ArabaMarka.Kia);
            Araba peugeot = factory.FactoryMethod(ArabaMarka.Peugeot);
            bmw.Marka();
            kia.Marka();
            peugeot.Marka();

            Console.Read();
        }
    }
}
