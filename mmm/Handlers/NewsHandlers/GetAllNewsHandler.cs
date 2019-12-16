using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CoreApp;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Model1;
using MyMediatr.Queries.NewsQueries;

namespace MyMediatr.Handlers.NewsHandlers
{
    public class GetAllNewsHandler : IRequestHandler<GetAllNewsQuery, DbSet<News>>
    {
        private DbContent _content;

        public GetAllNewsHandler(DbContent _content)
        {
           this._content = _content;
        }
        
        public async Task<DbSet<News>> Handle(GetAllNewsQuery request, CancellationToken cancellationToken)
        {
            var newss = _content.Newses;  //all news in base
            return await Task.FromResult(newss);
        }
    }
}
