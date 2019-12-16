using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CoreApp;
using MediatR;
using Model1;
using MyMediatr.Queries.CommentsQueries;
using MyMediatr.Queries.NewsQueries;

namespace MyMediatr.Handlers.CommentsHandler
{
    public class GetallCommentsHandler: IRequestHandler<GetCommentsQuery, IEnumerable<Comments>>
    {
    private readonly IUnitOfWork _unitOfWork;

    public GetallCommentsHandler(IUnitOfWork _unitOfWork)
    {
        this._unitOfWork = _unitOfWork;
    }


    public Task<IEnumerable<Comments>> Handle(GetCommentsQuery request, CancellationToken cancellationToken)
    {
        var comm = _unitOfWork.Comments.GetAll();
        return Task.FromResult(comm);
    }
    
    }
}
