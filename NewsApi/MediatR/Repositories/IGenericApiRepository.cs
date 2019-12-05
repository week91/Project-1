using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappyNews.Entities;

namespace NewsApi.MediatR.Repositories
{
    public interface IGenericApiRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        Guid Create(T obj);
        bool Delete(Guid id);

    }
}
