using System;
using System.Collections;
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
    public class GetAllNewsHandler : IRequestHandler<GetAllNewsQuery, IEnumerable<News>>
    {
        private readonly IGenericApiRepository<News> _newsdata;

        public GetAllNewsHandler(IGenericApiRepository<News> newsdata)
        {
            this._newsdata = newsdata;
        }
        

        public Task<IEnumerable<News>> Handle(GetAllNewsQuery request, CancellationToken cancellationToken)
        {
            var newss = _newsdata.GetAll();
            return Task.FromResult(newss);
        }
    }
}
