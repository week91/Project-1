using System;
using MediatR;
using Model1;

namespace MyMediatr.Commands.NewsCommand
{
    public class RemoveNewsCommand : IRequest<string>
    {
        public RemoveNewsCommand(Guid id)
        {
            
            Id= id;
        }
        public Guid Id { get; }
    }
}
