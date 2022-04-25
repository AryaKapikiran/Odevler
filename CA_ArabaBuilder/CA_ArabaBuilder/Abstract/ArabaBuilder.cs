using CA_ArabaBuilder.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ArabaBuilder.Abstract
{
    public abstract class ArabaBuilder
    {
        protected Araba araba;

        public Araba Araba
        {
            get { return araba; }
        }

        public abstract void CreateBrandName();

        public abstract void CreateModelName();

        public abstract void CreateColor();

       

    }
}
