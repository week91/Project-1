using System;
using Core.Repo;
using HappyNews.Entities;
using NewsApi.MediatR.Repositories;

namespace Services.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericApiRepository<News> News { get; }
        IGenericRepository<Comments> Comments { get; }
        void Save();
    }
}
