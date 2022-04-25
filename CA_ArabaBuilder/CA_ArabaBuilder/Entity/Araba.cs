using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ArabaBuilder.Entity
{
    public class Araba
    {

        public string BrandName { get; set; }

        public string ModelName { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            return "Araba Markası: " + BrandName + " Araba Modeli: " + ModelName + " Rengi: " + Color ;
        }
    }
}
