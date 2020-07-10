using EntitiesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesslayer.Abstract
{
   public interface IGenericDal<T> where T:class,IContact,new()
    {
        void NewAdd(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetById(int id);
        List<T> GetList();
    }
}
