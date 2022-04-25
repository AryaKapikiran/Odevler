using CA_ArabaBuilder.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ArabaBuilder
{
    public class ArabaKullan
    {
        public void CarKullan(ArabaBuilder Araba)
        {
            Araba.CreateBrandName();
            Araba.CreateModelName();
            Araba.CreateColor();
        }
    }
}
