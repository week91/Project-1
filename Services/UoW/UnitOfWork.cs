using System;
using Core;
using Core.Repo;
using HappyNews.Entities;

namespace Services.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContent _context;

        private readonly IGenericRepository<News> _newsRepository;

        private readonly IGenericRepository<Comments> _commentsRepository;


        public UnitOfWork(DbContent context, IGenericRepository<News> news, IGenericRepository<Comments> comments)
        {
            _context = context;
            _newsRepository = news;
            _commentsRepository = comments;

        }


        public IGenericRepository<News> News => _newsRepository;

        public IGenericRepository<Comments> Comments => _commentsRepository;


        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            _context.SaveChanges();

        }
    }
}