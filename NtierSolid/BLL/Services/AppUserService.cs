using BLL.Interface;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AppUserService<T> : ILIST<T> where T : BaseEntity
    {
        public List<T> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
