using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Example.Interface
{
    public interface IAtanma:IHero
    {
        //Her hero (king haric) kendilerinden bir üst heroya alt sınıf olarak atanır

        IHero UstSınıf { get; set; }

        void AssignHero(IHero hero);
    }
}
