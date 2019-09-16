using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappyNews.Models;

namespace HappyNews
{
    public class DbObj
    {
        public static void Initial(DbContent content)
        {

            content.AddRange(
                new News
                {
                    Source = "Onliner1",
                    DateCreate = DateTime.Now,
                    IndexOfPosition = "1",
                    NewText = "news-1 news-1 news-1"

                },

                new News
                {

                    Source = "Onliner2",
                    DateCreate = DateTime.Now,
                    IndexOfPosition = "2",
                    NewText = "news-2 news-2 news-2"
                },

                new News
                {

                    Source = "Onliner3",
                    DateCreate = DateTime.Now,
                    IndexOfPosition = "3",
                    NewText = "news-3 news-3 news-3"
                });
                
            content.SaveChanges();

        }
    }
}
