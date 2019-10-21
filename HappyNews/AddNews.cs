using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappyNews.Addnews;
using HappyNews.Models;
using HtmlAgilityPack;

namespace HappyNews.ViewsModel
{
    public class AddNews
    {
        public List<News> AddNewsList(string RssChanelUrlS)
        {
            ParsUrlForRss Rsss = new ParsUrlForRss();
            List<string> urls = Rsss.AddUrls(RssChanelUrlS);

            string BodyText = "";
            List<News> News = new List<News>();
            foreach (string html in urls)
            {

                HtmlWeb web = new HtmlWeb();
                var htmlDoc = web.Load(html);

                switch (RssChanelUrlS)
                {
                    case "http://s13.ru/rss/.rss":
                        ;

                        var htmlBody2 = htmlDoc.DocumentNode.SelectNodes("//div [@class='js-mediator-article']");
                        foreach (var nodes in htmlBody2)
                        {
                            if (nodes.InnerText != null)
                            {
                                BodyText += nodes.InnerText;

                            }

                        }

                        var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='Content']/h1");

                        News.Add(new News
                        {
                            Source = html, BodyNews = BodyText, DateCreate = DateTime.Now,
                            NewsTitle = htmlBody.InnerText,
                        });
                        break;
                }


            }
            return News;


        }
    }
}
