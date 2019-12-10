using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HappyNews.Entities;
using MediatR;
using NewsApi.MediatR.Queries;
using NewsApi.MediatR.Repositories;
using Services.UoW;

namespace NewsApi.MediatR.Handlers
{
    public class GetNewsHandler : IRequestHandler<GetNewsQuery, News>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetNewsHandler(IUnitOfWork _unitOfWork)
        {
            this._unitOfWork = _unitOfWork;
        }
        public Task<News> Handle(GetNewsQuery request, CancellationToken cancellationToken)
        {
            var result = _unitOfWork.News.GetById((request.Id));
            return Task.FromResult(result);
        }
    }
}
