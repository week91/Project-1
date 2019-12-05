using System;
using Core.Repo;
using HappyNews.Entities;

namespace Services.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<News> News { get; }
        IGenericRepository<Comments> Comments { get; }
        void Save();
    }
}
