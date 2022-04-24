using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Example.Interface
{
    public interface IHero
    {
        //Heroların sahip oldukları ozellikler
         string Name { get; set; }

         int Puan { get; set; }

        void PuanHesapla(int yapilangorev);
    }
}
