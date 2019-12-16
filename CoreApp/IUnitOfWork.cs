using System;
using Model1;

namespace CoreApp
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericApiRepository<News> News { get; }
        IGenericApiRepository<Comments> Comments { get; }
        void Save();
    }
}
