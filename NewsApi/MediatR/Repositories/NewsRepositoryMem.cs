using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using HappyNews.Entities;
using Microsoft.EntityFrameworkCore;

namespace NewsApi.MediatR.Repositories
{
    public class NewsRepositoryMem<T> : IGenericApiRepository<T> where T : DbEntities
    {
        private readonly DbContent _context;

        private  DbSet<T> _table;


        public NewsRepositoryMem(DbContent _context)
        {
            this._context = _context;
            _table = _context.Set<T>();
        }
        
        public IEnumerable<T> GetAll()
        {
            return _table;
        }

        public T GetById(Guid id)
        {
            return _table.FirstOrDefault(x => x.id == id);
        }

        public Guid Create(T obj)
        {
            obj.id=Guid.NewGuid();
            _table.Add(obj);

            return  obj.id;
        }

        public bool Delete(Guid id)
        {
            
            return true;
        }

       

      
    }
}

