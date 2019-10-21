using System;
using HappyNews.Models;
using HappyNews.Repo;

namespace HappyNews.UoW
{
    public interface IUnitOfWork:IDisposable
    {
        IGenericRepository<News> News { get; }
        IGenericRepository<Comments> Comments { get; }
    void Save();
    }
}
