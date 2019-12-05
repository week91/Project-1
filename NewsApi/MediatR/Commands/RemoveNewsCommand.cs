using System;
using MediatR;

namespace NewsApi.MediatR.Commands
{
    public class RemoveNewsCommand:IRequest<bool>
    {
        public RemoveNewsCommand(Guid id)
        { 
            Id=id;
        }
        public Guid Id { get; }
    }
}
