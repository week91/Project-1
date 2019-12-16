using System;
using System.Threading;
using System.Threading.Tasks;
using CoreApp;
using MediatR;
using MyMediatr.Commands.NewsCommand;

namespace MyMediatr.Handlers.NewsHandlers
{
    public class CreateNewsHandler : IRequestHandler<CreateNewsCommand, Guid>
    {
        private readonly IUnitOfWork _newsRepository;

        public CreateNewsHandler(IUnitOfWork newsdata)
        {
            _newsRepository = newsdata;
        }
        public Task<Guid> Handle(CreateNewsCommand request, CancellationToken cancellationToken)
        {
            var id = _newsRepository.News.Create(request.News);

            _newsRepository.Save();

            return Task.FromResult(id);
        }
    }
}
