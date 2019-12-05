using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappyNews.Entities;
using MediatR;

namespace NewsApi.MediatR.Queries
{
    public class GetAllNewsQuery:IRequest<IEnumerable<News>>
    {
    }
}
