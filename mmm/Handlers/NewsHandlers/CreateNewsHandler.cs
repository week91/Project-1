using System;
using System.Threading;
using System.Threading.Tasks;
using CoreApp;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Model1;
using MyMediatr.Commands.NewsCommand;

namespace MyMediatr.Handlers.NewsHandlers
{
    public class CreateNewsHandler : IRequestHandler<CreateNewsCommand, Guid>
    {
       DbContent _content;

        public CreateNewsHandler(DbContent _content)
        {
            this._content=_content;
        }
        public async Task<Guid> Handle(CreateNewsCommand request, CancellationToken cancellationToken)
        {
            _content.Newses.Add(request.News);
            var id = request.News.id;
            _content.SaveChanges();

            return await Task.FromResult(id);
        }
    }
}
