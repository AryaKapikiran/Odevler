using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Example.Interface
{
    public interface IProtected:IHero
    {

        //Her kral atandıgı sovalye tarafından korunur

        IHero Protection { get; set; }

        void AssignSovalye(IHero hero);


    }
}
