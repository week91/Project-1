using System;
using System.Threading;
using System.Threading.Tasks;
using CoreApp;
using MediatR;
using MyMediatr.Commands.CommentsCommand;

namespace MyMediatr.Handlers.CommentsHandler
{
    public class CreateCommentHandler : IRequestHandler<CreateCommentCommand, Guid>
    {
        
        private readonly DbContent _context;
        public CreateCommentHandler( DbContent context)
        {
            this._context =context;
            
        }

        public async Task<Guid> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            _context.Comment.Add(request.Comment);         //add comment to db
            var id = request.Comment.id;
           _context.SaveChanges();

            return await Task.FromResult(id);
        }
    }
}