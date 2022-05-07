using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface ICrud<T> where T :BaseEntity
    {
        T FindByID(int id);
        string Create(T entity);

        string Update(T entity);

        string Delete(int id);

       

        List<T> GetList();

    }
}
