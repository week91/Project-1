using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CoreApp;
using MediatR;
using Model1;
using MyMediatr.Queries.CommentsQueries;
using MyMediatr.Queries.NewsQueries;

namespace MyMediatr.Handlers.CommentsHandler
{
   public class GetCommentHandler : IRequestHandler<GetCommentQuery, Comments>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetCommentHandler (IUnitOfWork _unitOfWork)
        {
            this._unitOfWork = _unitOfWork;
        }
        public Task<Comments> Handle(GetCommentQuery request, CancellationToken cancellationToken)
        {
            var result = _unitOfWork.Comments.GetById(request.Id);
            return Task.FromResult(result);
        }
    
    }
}
