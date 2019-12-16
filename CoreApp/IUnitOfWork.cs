using System;
using Model1;

namespace CoreApp
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<News> News { get; }
        IGenericRepository<Comments> Comments { get; }
        void Save();
    }
}
