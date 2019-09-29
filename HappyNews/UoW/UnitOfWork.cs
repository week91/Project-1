using System;
using HappyNews.Models;
using HappyNews.Repo;

namespace HappyNews.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContent _context;
        private readonly IGenericRepository<Users> _usersRepository;
        private readonly IGenericRepository<Admins> _adminsRepository;
        private readonly IGenericRepository<News> _newsRepository;
        private readonly IGenericRepository<Comments> _commentsRepository;

        public UnitOfWork(DbContent context,
            IGenericRepository<Users> users,
            IGenericRepository<Admins> admins,
            IGenericRepository<News> news,
            IGenericRepository<Comments> comments)
        {
            _context = context;
            _usersRepository = users;
            _adminsRepository = admins;
            _newsRepository = news;
            _commentsRepository = comments;

        }






        public IGenericRepository<Users> User => _usersRepository;

        public IGenericRepository<Admins> Admins => _adminsRepository;

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