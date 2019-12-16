using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CoreApp;
using MediatR;
using Model1;
using MyMediatr.Queries.NewsQueries;

namespace MyMediatr.Handlers.NewsHandlers
{
    public class GetAllNewsHandler : IRequestHandler<GetAllNewsQuery, IEnumerable<News>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllNewsHandler(IUnitOfWork _unitOfWork)
        {
            this._unitOfWork = _unitOfWork;
        }


        public Task<IEnumerable<News>> Handle(GetAllNewsQuery request, CancellationToken cancellationToken)
        {
            var newss = _unitOfWork.News.GetAll();
            return Task.FromResult(newss);
        }
    }
}
