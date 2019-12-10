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
using Services.UoW;

namespace NewsApi.MediatR.Handlers
{
    public class RemoveNewsHandler : IRequestHandler<RemoveNewsCommand, bool>
    {
      private readonly IUnitOfWork _unitOfWork ;
        
        public RemoveNewsHandler(IUnitOfWork _unitOfWork)
        {
            this._unitOfWork = _unitOfWork;
        }
        public  Task<bool> Handle(RemoveNewsCommand request, CancellationToken cancellationToken)
        {
           var result = _unitOfWork.News.Delete(request.Id);
           _unitOfWork.Save();
            return  Task.FromResult(result);
        }
    }
}
