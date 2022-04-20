using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface ILIST<T> where T : BaseEntity
    {
        List<T> GetList();
    }
}
