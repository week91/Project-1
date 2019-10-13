using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappyNews.Models;

namespace HappyNews.Addnews
{
    interface IAddNews
    {
        List<News> AddNews(string url);
    }
}
