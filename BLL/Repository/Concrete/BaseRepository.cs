using BLL.Repository.Abstract;
using Core;
using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository.Concrete
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        ProjectDbContext db = new ProjectDbContext();
        public string Add(T model)
        {
            model.ID = Guid.NewGuid();
            db.Set<T>().Add(model);
            db.SaveChanges();
            return "Veri Eklendi";
        }

        public string Delete(T model)
        {
            model.Status = Core.Enums.Status.Deleted;
            Update(model);
            return "Ürün kaldırıldı";
        }

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public T GetById(Guid id)
        {
            return db.Set<T>().Find(id);
        }
        
        public string Update(T model)
        {
            
            db.Entry(model).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return "Güncellendi";
           
        }
    }
}
