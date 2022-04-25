using CA_ArabaBuilder.Abstract;
using CA_ArabaBuilder.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ArabaBuilder.Concrete
{
    public class AudiConcrete : ArabaBuilder
    {
        public AudiConcrete()
        {
            araba = new Araba();
        }
        public override void CreateBrandName()
        {
            araba.BrandName = "Audi";
        }

        public override void CreateColor()
        {
            araba.ModelName = "A4";
        }

        public override void CreateModelName()
        {
            araba.Color = "Siyah";
        }
    }
}
