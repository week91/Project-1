using MediatR;
using Model1;
using System;

namespace MyMediatr.Commands.NewsCommand
{
    public class CreateNewsCommand : IRequest<Guid>
    {
        public CreateNewsCommand(News news1)
        {
            News = news1;
        }
        public News News { get; }

    }
}
