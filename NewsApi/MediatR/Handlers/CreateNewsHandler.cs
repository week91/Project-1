using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Core;
using HappyNews.Entities;
using MediatR;
using NewsApi.MediatR.Commands;
using NewsApi.MediatR.Repositories;

namespace NewsApi.MediatR.Handlers
{
    public class CreateNewsHandler : IRequestHandler<CreateNewsCommand, Guid>
    {
        private readonly IGenericApiRepository<News> _newsdata;

        public CreateNewsHandler(IGenericApiRepository<News> newsdata)
        {
            this._newsdata = newsdata;
        }
        public Task<Guid> Handle(CreateNewsCommand request, CancellationToken cancellationToken)
        {
            var id = _newsdata.Create(request.News);
            return Task.FromResult(id);
        }
    }
}
