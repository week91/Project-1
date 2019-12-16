using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using Model1;

namespace MyMediatr.Commands.CommentsCommand
{
    public class RemoveCommentsCommand :IRequest<string>
    {
        public RemoveCommentsCommand(Guid id)
        {
            Id = Id;
        }
        public Guid Id { get; }
    }
}
