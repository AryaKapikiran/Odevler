using CA_ArabaBuilder.Abstract;
using CA_ArabaBuilder.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ArabaBuilder.Concrete
{
    public class BMWConcrete : ArabaBuilder
    {
        public BMWConcrete()
        {
            araba = new Araba();
        }
        public override void CreateBrandName()
        {
            araba.BrandName = "BMW";
        }

        public override void CreateColor()
        {
            araba.ModelName = "X3";
        }

        public override void CreateModelName()
        {
            araba.Color = "Beyaz";
        }
    }
}
