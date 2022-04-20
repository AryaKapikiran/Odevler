using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface ICRUD<T> where T :BaseEntity
    {
        //Create

        string Create(T entity);

        string Update(T entity);

        string Delete(int id);

        T FindByID(int id);

       

    }
}
