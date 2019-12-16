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
    public class CreateCommentHandler : IRequestHandler<CreateCommentCommand, Guid>
    {
        private readonly IUnitOfWork _newsRepository;

        public CreateCommentHandler(IUnitOfWork comentdata)
        {
            _newsRepository = comentdata;
        }

        public Task<Guid> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            var id = _newsRepository.Comments.Create(request.Comment);

            _newsRepository.Save();

            return Task.FromResult(id);
        }
    }
}