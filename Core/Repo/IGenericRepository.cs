using System;
using System.Collections.Generic;
using System.Linq;
using HappyNews.Entities;

namespace Core.Repo
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