using Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class EntityRepository : IEntity<Guid>
    {
        public EntityRepository()
        {
            Status = Status.Active;

        }
        public Guid ID { get; set; }

        public int MasterId { get; set; }

        public Status Status { get; set; }

        //Veri eklendigindetutulacak bilgiler

        public DateTime? CreatedDate { get; set; } //olusturulma zamanı

        public string CreatedComputerName { get; set; } //bilgisayarın adı

        public string CreatedIP { get; set; }

        public string CreatedUserName { get; set; } 

        public string CreatedBy { get; set; }

        //veri güncellendiginde tutulacak bilgiler
        public DateTime? UpdatedDate { get; set; } 

        public string UpdatedComputerName { get; set; } 

        public string UpdatedIP { get; set; }

        public string UpdatedUserName { get; set; }

        public string UpdatedBy { get; set; }

        //Todo: Created ve updated propertyleri veritabanına kayıt esnasında doldurulacak, ip yakalama nesnesi oluşturulacak
    }
}
