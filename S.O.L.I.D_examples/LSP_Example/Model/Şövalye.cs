using LSP_Example.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Example.Model
{
    public class Şövalye : Serf, IHero, IProtection
    {
        //sovalye ozunde bir serftir
       
        public IHero Protected { get ; set ; }

        public void AssignProtectedHero(IHero hero)
        {
            Protected = hero;
        }

        
    }
}
