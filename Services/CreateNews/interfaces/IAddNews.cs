using System;
using System.Collections.Generic;
using System.Text;
using HappyNews.Entities;

namespace Services.CreateNews
{
   public interface IAddNews
    {
        List<News> AddNewsList(List<string> obj);

    }
}
