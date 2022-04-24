using OCP_Example.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Example.Concrete
{
    public class Mario : Kahraman,IZıplama
    {
        public override decimal GucHesapla(int rank)
        {
            decimal toplamguc = rank * 20;

           return toplamguc ;
        }

        public string Zıplıyor()
        {
            return "Bu kahraman zıplayabiliyor";
        }
    }
}
