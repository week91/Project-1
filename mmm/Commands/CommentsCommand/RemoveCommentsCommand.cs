using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace MyMediatr.Commands.CommentsCommand
{
    public class RemoveCommentsCommand :IRequest<bool>
    {
        public RemoveCommentsCommand(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; }
    }
}
