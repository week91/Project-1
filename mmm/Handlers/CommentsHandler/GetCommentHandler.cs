using System.Threading;
using System.Threading.Tasks;
using CoreApp;
using MediatR;
using Model1;
using MyMediatr.Queries.CommentsQueries;

namespace MyMediatr.Handlers.CommentsHandler
{
   public class GetCommentHandler : IRequestHandler<GetCommentQuery, Comments>
    {
       DbContent _content;

        public GetCommentHandler(DbContent _contentk)
        {
            this._content=_contentk;
        }
        public async Task<Comments> Handle(GetCommentQuery request, CancellationToken cancellationToken)
        {
            var result = _content.Comment.Find(request.Id);
            return await Task.FromResult(result);
        }
    
    }
}
