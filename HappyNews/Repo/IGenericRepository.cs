﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HappyNews.Repo
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);

        IQueryable<T> AsQueryable();
    }
}