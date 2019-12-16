using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CoreApp;
using MediatR;
using MyMediatr.Commands.CommentsCommand;

namespace MyMediatr.Handlers.CommentsHandler
{
    public class DeleteCommentHandler : IRequestHandler<RemoveCommentsCommand, string>
   {
       private DbContent _content;

        public DeleteCommentHandler(DbContent _content)
        {
            this._content = _content;
        }

        public async Task<string> Handle(RemoveCommentsCommand request, CancellationToken cancellationToken)
        {
            var result = _content.Comment.Where(c => c.id == request.Id).FirstOrDefault(); //get comment by id 
            _content.Remove(result);                                                      // remove this news
            _content.SaveChanges();
            return await Task.FromResult(request.Id +"delete");
        }
    }
}
