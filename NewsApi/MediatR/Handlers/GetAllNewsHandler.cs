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
using Services.UoW;

namespace NewsApi.MediatR.Handlers
{
    public class GetAllNewsHandler : IRequestHandler<GetAllNewsQuery, IEnumerable<News>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllNewsHandler(IUnitOfWork _unitOfWork)
        {
            this._unitOfWork = _unitOfWork;
        }
        

        public Task<IEnumerable<News>> Handle(GetAllNewsQuery request, CancellationToken cancellationToken)
        {
            var newss = _unitOfWork.News.GetAll();
            return Task.FromResult(newss);
        }
    }
}
