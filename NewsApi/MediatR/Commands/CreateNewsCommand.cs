using System;
using HappyNews.Entities;
using MediatR;

namespace NewsApi.MediatR.Commands
{
    public class CreateNewsCommand : IRequest<Guid>
    {
       public CreateNewsCommand(News news)
        {
            News = news;
        }
        public News News { get; }
    }
}
