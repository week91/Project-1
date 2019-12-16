using System.Collections.Generic;
using CoreApp;

namespace Services
{
    public class HangfireNews : IHangfireNews
    {
    
        private readonly IParsUrlForRss _parsUrlForRss;
        private readonly IAddNews _addNews;
        private DbContent _dbContent;

      public  HangfireNews( IParsUrlForRss parsUrlForRss, IAddNews addNews, DbContent dbContent)
        {
           
            _parsUrlForRss =parsUrlForRss;
            _addNews = addNews;
            _dbContent = dbContent;
        }
        public bool TaskNewsAddStart()
        {
            var newsinbase = _dbContent.Newses; // get news 

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
            _dbContent.Newses.Add(newnews);
            }

            _dbContent.SaveChanges();
            return true;
        }
    }
    }


