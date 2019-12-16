using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using Model1;

namespace MyMediatr.Commands.CommentsCommand
{
    public class CreateCommentCommand:IRequest<Guid>
    {
        public CreateCommentCommand(Comments _comment)
        {
            Comment = _comment;
        }
        public Comments Comment { get; }
    
    }
}
