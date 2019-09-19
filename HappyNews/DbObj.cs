using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappyNews.Models;

namespace HappyNews
{
    public class DbObj
    {
        public static void InitialData(DbContent content)
        {
            if (!content.Newses.Any())
            {


                content.Newses.AddRange(
                    new News
                    {
                        NewsTitle = "News-1_Title",
                        Source = "Onliner1",
                        DateCreate = DateTime.Now,
                        IndexOfPosition = "1",
                        BodyNews = "news-1 news-1 news-1 news-1 news-1 news-1 news-1 news-1 news-1news-1 news-1 news-1 news-1 news-1 news-1 news-1 news-1 news-1"

                    },

                    new News
                    {
                        NewsTitle = "News-2_Title",
                        Source = "Onliner2",
                        DateCreate = DateTime.Now,
                        IndexOfPosition = "2",
                        BodyNews = "news-2 news-2 news-2 news-2 news-2 news-2 news-2 news-2 news-2news-2 news-2 news-2 news-2 news-2 news-2 news-2 news-2 news-2"
                    },

                    new News
                    {
                        NewsTitle = "News-3_Title",
                        Source = "Onliner3",
                        DateCreate = DateTime.Now,
                        IndexOfPosition = "3",
                        BodyNews =
                            "news-3 news-3 news-3 news-3 news-3 news-3 news-3 news-3 news-3 news-3news-3 news-3 news-3 news-3 news-3 news-3 news-3 news-3 news-3 news-3"

                    }, new News
                    {
                        NewsTitle = "News-4_Title",
                        Source = "Onliner4",
                        DateCreate = DateTime.Now,
                        IndexOfPosition = "4",
                        BodyNews =
                            "news-4 news-4 news-4 news-4 news-4 news-4 news-4 news-4 news-4 news-news-4 news-4 news-4 news-4 news-4 news-4 news-4 news-4 news-4 news-4"

                    });

                content.SaveChanges();

            }
        }
    }
}
