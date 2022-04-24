using LSP_Example.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Example.Model
{
    public class Serf : BaseHero,IAtanma
    {
        public IHero UstSınıf { get ; set ; }
       

        public void AssignHero(IHero hero)
        {
            UstSınıf=hero;
        }

       
    }
}
