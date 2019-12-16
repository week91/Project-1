using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using Model1;

namespace MyMediatr.Commands.CommentsCommand
{
    public class CreateCommentCommand:IRequest<Guid>
    {
        public CreateCommentCommand(Comments comment)
        {
           Comment = comment;
        }
        public Comments Comment { get; }
    
    }
}
