using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HappyNews.Entities;
using MediatR;
using Microsoft.AspNetCore.Routing.Template;
using NewsApi.MediatR.Commands;
using NewsApi.MediatR.Repositories;

namespace NewsApi.MediatR.Handlers
{
    public class RemoveNewsHandler : IRequestHandler<RemoveNewsCommand, bool>
    {
        private readonly IGenericApiRepository<News> _newsdata ;

        public RemoveNewsHandler(IGenericApiRepository<News> newsdata)
        {
            this._newsdata = newsdata;
        }
        public  Task<bool> Handle(RemoveNewsCommand request, CancellationToken cancellationToken)
        {
           var result = _newsdata.Delete(request.Id);
            return  Task.FromResult(result);
        }
    }
}
