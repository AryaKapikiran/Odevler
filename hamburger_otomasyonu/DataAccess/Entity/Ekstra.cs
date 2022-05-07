using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Ekstra:BaseEntity
    {
        public int ID { get; set; }

        public string EkstraName { get; set; }

        public decimal Fiyat { get; set; }

        
    }
}
