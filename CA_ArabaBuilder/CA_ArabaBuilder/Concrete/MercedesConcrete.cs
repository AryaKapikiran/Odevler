using CA_ArabaBuilder.Abstract;
using CA_ArabaBuilder.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ArabaBuilder.Concrete
{
    public class MercedesConcrete : ArabaBuilder
    {
        public MercedesConcrete()
        {
            araba = new Araba();
        }
        public override void CreateBrandName()
        {
            araba.BrandName = "Mercedes";
        }

        public override void CreateColor()
        {
            araba.ModelName = "A180";
        }

        public override void CreateModelName()
        {
            araba.Color = "Yeşil";
        }
    }
}
