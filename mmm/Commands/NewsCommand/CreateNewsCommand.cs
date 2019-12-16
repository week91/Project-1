using MediatR;
using Model1;
using System;

namespace MyMediatr.Commands.NewsCommand
{
    public class CreateNewsCommand : IRequest<Guid>
    {
        public CreateNewsCommand(News _news)
        {
            News = _news;
        }
        public News News { get; }

    }
}
