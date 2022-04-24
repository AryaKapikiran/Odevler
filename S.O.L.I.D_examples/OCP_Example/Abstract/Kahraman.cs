using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Example.Abstract
{
    public abstract class Kahraman
    {
        //kahramanları enum tanımlamak yerine abstract bir base class tanımlıyoruz böyleyece her kahraman eklendiğinde bu ozellikleri miras verebilelim ve tekrar tekrar kod degisimine ihtiyac olması yerine bu ozellikleri ve gucu yeni kahramanların altında tanımlayabilelim
        public string KahramanAdı { get; set; }
        public int Rank { get; set; }

        //Guc her kahramanda olması gereken bir ozellik
        public abstract decimal GucHesapla(int rank);


    }
}
