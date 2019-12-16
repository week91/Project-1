using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using Model1;

namespace MyMediatr.Queries.CommentsQueries
{
    public class GetCommentQuery : IRequest<Comments>
    {
        GetCommentQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    
    }
}
