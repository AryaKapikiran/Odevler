using Factory_Example.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Example
{
    public class Factory
    {
        public Araba FactoryMethod(ArabaMarka arabaMarka)
        {
            Araba araba = null;
            switch(arabaMarka)
            {
                case ArabaMarka.BMW:
                    araba = new BMW();
                    break;
                case ArabaMarka.Kia:
                    araba = new Kia();
                    break;
                case ArabaMarka.Peugeot:
                    araba = new Peugeot();
                    break;
            }

            return araba;

                
              



        }
    }
}
