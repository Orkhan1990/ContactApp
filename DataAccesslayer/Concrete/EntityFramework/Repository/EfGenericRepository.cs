using DataAccesslayer.Abstract;
using DataAccesslayer.EntityFramework.Context;
using EntitiesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesslayer.EntityFramework.Repository
{
    public class EfGenericRepository<T> : IGenericDal<T> where T : class, IContact, new()
    {
       public void Delete(T entity)
        {
              using var context = new ContactContext();
              context.Set<T>().Remove(entity);
              context.SaveChanges();
        }

        public T GetById(int id)
        {
            using var context = new ContactContext();
            return context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var context = new ContactContext();
            return context.Set<T>().ToList();
        }

        public void NewAdd(T entity)
        {
            using var context = new ContactContext();
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

     
        public void Update(T entity)
        {
            using var context = new ContactContext();
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }
    }
}
