using BLL.Interface;
using DataAccess.Context;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AdminService<T> : ILIST<T>,ICRUD<T> where T : BaseEntity
    {
        ProjectContext db = new ProjectContext();
        public string Create(T entity)
        {
            string result = "";
            try
            {
                db.Set(typeof(T)).Add(entity);
                db.SaveChanges();
                result = $"veri kaydedildi!";
                return result;
            }
            catch (Exception ex)
            {
                result = ex.Message;
                return result;
            }
        }

        public string Delete(int id)
        {
            try
            {
                var deleted = db.Set(typeof(T)).Find(id);
                db.Set(typeof(T)).Remove(deleted);
                db.SaveChanges();
                return "veri silindi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public List<T> GetList()
        {
            return db.Set(typeof(T)).Cast<T>().ToList();
        }

        public string Update(T entity)
        {
            try
            {
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "veri güncellendi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public T FindByID(int id)
        {
            return db.Set(typeof(T)).Cast<T>().Find(id);
        }
    }
}
