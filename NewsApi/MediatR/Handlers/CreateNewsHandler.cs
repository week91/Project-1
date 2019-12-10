using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using Core;
using HappyNews.Entities;
using MediatR;
using NewsApi.MediatR.Commands;
using NewsApi.MediatR.Repositories;
using Services.UoW;

namespace NewsApi.MediatR.Handlers
{
    public class CreateNewsHandler : IRequestHandler<CreateNewsCommand, Guid>
    {
        private readonly IUnitOfWork _newsRepository;

        public CreateNewsHandler(IUnitOfWork  newsdata)
        {
            this._newsRepository = newsdata;
        }
        public Task<Guid>Handle(CreateNewsCommand request, CancellationToken cancellationToken)
        {
            var id = _newsRepository.News.Create(request.News);

            _newsRepository.Save();

            return Task.FromResult(id);
        }
    }
}
