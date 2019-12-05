using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappyNews.Entities;
using MediatR;

namespace NewsApi.MediatR.Queries
{
    public class GetNewsQuery : IRequest<News>
    {
        public  GetNewsQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}
