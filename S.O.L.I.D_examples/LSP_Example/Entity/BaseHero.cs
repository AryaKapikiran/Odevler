using LSP_Example.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Example
{
    public class BaseHero :IHero
    {
        //Base heromuz IHero adlı classtan miras alıyor cunku her hero IHeroda olan ozelliklere sahip
        public string Name { get; set; }

        public int Puan { get; set; }

        public void PuanHesapla(int yapilangorev)
        {
            int basepuan = 20;
            Puan = basepuan * yapilangorev;
           
        }
    }
}
