using LSP_Example.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Example.Model
{
    public class Soylu :Şövalye, IEmirVer, IProtected
    {
        //Soylu şövalye classından miras alabilir
        public IHero Protection { get; set; }
       

        public void AssignSovalye(IHero hero)
        {
            Protection = hero;
        }

        public void EmirVer()
        {
            throw new NotImplementedException();
        }

       
    }
}
