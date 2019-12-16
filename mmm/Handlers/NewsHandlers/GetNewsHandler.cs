using System.Threading;
using System.Threading.Tasks;
using CoreApp;
using MediatR;
using Model1;
using MyMediatr.Queries.NewsQueries;

namespace MyMediatr.Handlers.NewsHandlers
{
    public class GetNewsHandler : IRequestHandler<GetNewsQuery, News>
    {
        private DbContent _content;

        public GetNewsHandler(DbContent _content)
        {
            this._content=_content;
        }
        public async Task<News> Handle(GetNewsQuery request, CancellationToken cancellationToken)
        {
            var result = _content.Newses.Find(request.Id);  //get news by id
            return await Task.FromResult(result);
        }
    }
}
