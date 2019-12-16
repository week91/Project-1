using System.Collections.Generic;
using CoreApp;

namespace Services
{
    public class HangfireNews : IHangfireNews
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IParsUrlForRss _parsUrlForRss;
        private readonly IAddNews _addNews;

      public  HangfireNews(IUnitOfWork unitOfWork, IParsUrlForRss parsUrlForRss, IAddNews addNews)
        {
            _unitOfWork = unitOfWork;
            _parsUrlForRss =parsUrlForRss;
            _addNews = addNews;
        }
        public bool TaskNewsAddStart()
        {
            var newsinbase = _unitOfWork.News.GetAll(); // get news 

            var urlForNewsList =_parsUrlForRss.AddUrls(); //pars url newses

            List<string> newsInBaseList=new List<string>();
               foreach (var newse in newsinbase)
               {
                newsInBaseList.Add(newse.Source);
               }
               List<string> parsUrlList=new List<string>();
              
               foreach (var url in urlForNewsList)
               {
                   if (!newsInBaseList.Contains(url))  //repeat check
                {
                       parsUrlList.Add(url);          
                   }
               }
           
           var news =_addNews.AddNewsList(parsUrlList); //pars news and add to base
            foreach (var newnews in news)
            {
            _unitOfWork.News.Create(newnews);
            }
            _unitOfWork.Save();
            return true;
        }
    }
    }


