using System;
using System.Collections.Generic;

namespace CoreApp
{
    public interface IGenericApiRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        Guid Create(T obj);
        bool Delete(Guid id);
        void Update(T obj);
    }
}
