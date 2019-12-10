using System;
using System.Collections.Generic;
using HappyNews.Entities;
using MediatR;

namespace NewsApi.MediatR.Commands
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
