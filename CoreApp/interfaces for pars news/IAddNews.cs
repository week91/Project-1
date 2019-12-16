using System.Collections.Generic;
using Model1;

namespace CoreApp
{
   public interface IAddNews
    {
        List<News> AddNewsList(List<string> rss);

    }
}
