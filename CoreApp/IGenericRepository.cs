using System;
using System.Collections.Generic;

namespace CoreApp
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        
    }
}