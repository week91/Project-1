using System.Collections.Generic;
using MediatR;
using Model1;

namespace MyMediatr.Queries.CommentsQueries
{
    public class GetCommentsQuery :IRequest<IEnumerable<Comments>>
    {
    }
}
