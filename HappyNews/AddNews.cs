using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
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
           
            List<News> News1 = new List<News>();


            Regex regex = new Regex(@"&[a-z ]*\;");

            foreach (string html in urls)
            {
                string BodyText = "";
                HtmlWeb web = new HtmlWeb();
                var htmlDoc = web.Load(html);

                var htmlBody2 = htmlDoc.DocumentNode.SelectNodes("//div [@class='js-mediator-article']");
                        foreach (var nodes in htmlBody2)
                        {
                            if (nodes != null)
                            {

                                BodyText += nodes.InnerText;

                    }

                        }

                        var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//div/h1");
                if(htmlBody !=null)
                   
                News1.Add(new News
                        {
                            Source = html,
                            BodyNews = regex.Replace(BodyText, " "),
                            DateCreate = DateTime.Now,
                            NewsTitle = htmlBody.InnerText,
                        }); 

            }

            return News1;



        }
           


        }
}
