using System;
using MediatR;
using Model1;

namespace MyMediatr.Queries.NewsQueries
{
    public class GetNewsQuery : IRequest<News>
    {
        public GetNewsQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}
