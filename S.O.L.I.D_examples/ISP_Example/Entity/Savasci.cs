using ISP_Example.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Example.Entity
{
    public class Savasci : BaseHero, IAtesEtme
    {
        public void AtesEt()
        {
            Console.WriteLine("Bu kahraman ates edebilir");
        }
    }
}
