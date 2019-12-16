using System.Threading;
using System.Threading.Tasks;
using CoreApp;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Model1;
using MyMediatr.Queries.CommentsQueries;

namespace MyMediatr.Handlers.CommentsHandler
{
    public class GetallCommentsHandler: IRequestHandler<GetCommentsQuery, DbSet<Comments>>
    {
 
    private readonly DbContent _context;
        public GetallCommentsHandler(DbContent _context)
        {
            this._context = _context;

        }
        
    public async Task<DbSet<Comments>> Handle(GetCommentsQuery request, CancellationToken cancellationToken)
        {
            var comm = _context.Comment;       // get all comment

            return  await Task.FromResult(comm);
        }

    }
}
