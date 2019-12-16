using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Model1;

namespace CoreApp
{
    public class EntityFrameworkRepo<T> : IGenericRepository<T> where T : DbEntities
    {

        private readonly DbContent _context;
        private readonly DbSet<T> _table;


        public EntityFrameworkRepo(DbContent _context)
        {
            this._context = _context;
            _table = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _table.ToList();
        }

       public void Insert(T obj)
        {
            _table.Add(obj);
        }

        public void Update(T obj)
        {
            _table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            T existing = _table.Find(id);
            _table.Remove(existing);
        }

        public IQueryable<T> AsQueryable()
        {
            return _table.AsQueryable();
        }

        public T GetById(Guid id)
        {
            return _table.Find(id);
        }
        
    }
}


