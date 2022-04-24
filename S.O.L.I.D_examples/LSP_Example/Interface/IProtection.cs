using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Example.Interface
{
    public interface IProtection:IHero
    {
        //Sovalye heroları kendilerinden üst sınıfı korur

        IHero Protected { get; set; }

        void AssignProtectedHero(IHero hero);
    }
}
