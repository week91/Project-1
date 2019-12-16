using System.Collections.Generic;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Model1;

namespace MyMediatr.Queries.CommentsQueries
{
    public class GetCommentsQuery :IRequest<DbSet<Comments>>
    {
    }
}
