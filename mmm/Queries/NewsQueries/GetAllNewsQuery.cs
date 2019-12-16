using System.Collections.Generic;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Model1;

namespace MyMediatr.Queries.NewsQueries
{
    public class GetAllNewsQuery : IRequest<DbSet<News>>
    {
    }
}
