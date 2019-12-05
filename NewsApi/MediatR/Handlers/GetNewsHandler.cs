using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HappyNews.Entities;
using MediatR;
using NewsApi.MediatR.Queries;
using NewsApi.MediatR.Repositories;

namespace NewsApi.MediatR.Handlers
{
    public class GetNewsHandler : IRequestHandler<GetNewsQuery, News>
    {
        private readonly IGenericApiRepository<News> _newsdata;

        public GetNewsHandler(IGenericApiRepository<News> newsdata)
        {
            this._newsdata = newsdata;
        }
        public Task<News> Handle(GetNewsQuery request, CancellationToken cancellationToken)
        {
            var result = _newsdata.GetById((request.Id));
            return Task.FromResult(result);
        }
    }
}
