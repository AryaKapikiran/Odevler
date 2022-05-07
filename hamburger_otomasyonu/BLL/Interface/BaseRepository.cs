﻿using DataAccess.Context;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public class BaseRepository<T> : ICrud<T> where T : BaseEntity
    {

        ProjectContext db = new ProjectContext();

        public T FindByID(int id)
        {
            return db.Set(typeof(T)).Cast<T>().Find(id);
        }
        public string Create(T model)
        {
            string result = "";
            try
            {
                db.Set(typeof(T)).Add(model);
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

        public string Update(T model)
        {
            try
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "veri güncellendi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }
    }
}
