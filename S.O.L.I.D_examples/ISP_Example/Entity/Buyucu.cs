using ISP_Example.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Example.Entity
{
    public class Buyucu : BaseHero, IMagic,IHeal
    {
        public void BuyuYap()
        {
            Console.WriteLine("Bu kahraman büyü yapabilir");
        }

        public void HealSelf()
        {
            Console.WriteLine("Bu kahraman kendine can basabilir");
        }
    }
}
