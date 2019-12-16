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
        private readonly IUnitOfWork _unitOfWork;

        public GetNewsHandler(IUnitOfWork _unitOfWork)
        {
            this._unitOfWork = _unitOfWork;
        }
        public Task<News> Handle(GetNewsQuery request, CancellationToken cancellationToken)
        {
            var result = _unitOfWork.News.GetById(request.Id);
            return Task.FromResult(result);
        }
    }
}
