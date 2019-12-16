using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CoreApp;
using MediatR;
using MyMediatr.Commands.NewsCommand;

namespace MyMediatr.Handlers.NewsHandlers
{
    public class RemoveNewsHandler : IRequestHandler<RemoveNewsCommand, string>
    {
        private DbContent _content;

        public RemoveNewsHandler(DbContent _content)
        {
            this._content=_content;
        }

        public async Task<string> Handle(RemoveNewsCommand request, CancellationToken cancellationToken)
        {
            var news = _content.Newses.Where(n => n.id == request.Id).FirstOrDefault(); //get news by id 
            _content.Remove(news); // remove this news
            _content.SaveChanges();
            return await Task.FromResult(request.Id +"  delete");
    }
    }
}
