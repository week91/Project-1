using System.Threading.Tasks;
using Data;
using Services;
using Services.AddUrlRss;
using Services.UoW;

namespace NewsCreated.Hangfire
{
    public class HangfireNews: IHangfireNews
    {
        private IUnitOfWork _unitOfWork;
      public  HangfireNews(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<bool> TaskNewsAddStart()
        {
            var rss = new ParsUrlForRss().AddUrls();
           var yy= _unitOfWork.News.GetAll();
           foreach (var q in yy)
           {
               foreach (var r in rss)
               {
                   if (q.Source == r)
                   {
                       rss.Remove(r);
                   }
               }
               
           }
            var news = new AddNews().AddNewsList(rss);
            foreach (var n in news)
            {
                _unitOfWork.News.Create(n);
            }
            _unitOfWork.Save();
            return (true);
        }
    }
    }
    

