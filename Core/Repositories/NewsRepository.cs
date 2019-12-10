using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using HappyNews.Entities;

namespace NewsApi.MediatR.Repositories
{
    public class NewsRepository : NewsRepositoryMem<News>
    {
        public NewsRepository(DbContent _context) : base(_context)
        {
        }

    }
}
