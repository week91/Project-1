using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CoreApp;
using MediatR;
using MyMediatr.Commands.CommentsCommand;
using MyMediatr.Commands.NewsCommand;

namespace MyMediatr.Handlers.CommentsHandler
{
   public class DeleteCommentHandler : IRequestHandler<RemoveCommentsCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteCommentHandler(IUnitOfWork _unitOfWork)
        {
            this._unitOfWork = _unitOfWork;
        }

        public Task<bool> Handle(RemoveCommentsCommand request, CancellationToken cancellationToken)
        {
            var result = _unitOfWork.Comments.Delete(request.Id);
            _unitOfWork.Save();
            return Task.FromResult(result);
        }
    }
}
