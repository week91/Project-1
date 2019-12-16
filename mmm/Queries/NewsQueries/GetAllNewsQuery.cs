using System.Collections.Generic;
using MediatR;
using Model1;

namespace MyMediatr.Queries.NewsQueries
{
    public class GetAllNewsQuery : IRequest<IEnumerable<News>>
    {
    }
}
