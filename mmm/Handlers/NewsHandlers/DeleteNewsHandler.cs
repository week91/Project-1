using System.Threading;
using System.Threading.Tasks;
using CoreApp;
using MediatR;
using MyMediatr.Commands.NewsCommand;

namespace MyMediatr.Handlers.NewsHandlers
{
    public class RemoveNewsHandler : IRequestHandler<RemoveNewsCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;

        public RemoveNewsHandler(IUnitOfWork _unitOfWork)
        {
            this._unitOfWork = _unitOfWork;
        }
        public Task<bool> Handle(RemoveNewsCommand request, CancellationToken cancellationToken)
        {
            var result = _unitOfWork.News.Delete(request.Id);
            _unitOfWork.Save();
            return Task.FromResult(result);
        }
    }
}
