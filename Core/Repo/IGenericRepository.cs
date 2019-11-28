using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Repo
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);

        IQueryable<T> AsQueryable();
    }
}