using System;
using MediatR;

namespace MyMediatr.Commands.NewsCommand
{
    public class RemoveNewsCommand : IRequest<bool>
    {
        public RemoveNewsCommand(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; }
    }
}
