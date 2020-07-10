using EntitiesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T:class,IContact,new()
    {
        void NewAdd(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetId(int id);
        List<T> GetList();

    }
}
