using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class HamburgerMenu:BaseEntity
    {
        public int ID { get; set; }

        public string MenuName { get; set; }

        public decimal Fiyat { get; set; }

        public override string ToString()
        {
            return $"{MenuName} Menü | {Fiyat.ToString("C2")}"; 
        }

       

    }
}
