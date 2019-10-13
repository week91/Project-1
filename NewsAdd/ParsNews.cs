using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
namespace NewsAdd
{
    class ParsNews
    {
        static void Main(string[] args)
        {

            public ParsNews(IUninofWork unit )
        {

        }
            string html = "http://auto.onliner.by/";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);
            var htmlBody1 = htmlDoc.DocumentNode.SelectNodes("//div[@class='news-tidings__list']/div/div/div/a");

            List<string> newsurl = new List<string>();


            foreach (var node in htmlBody1)
            {
                newsurl.Add(html + node.Attributes["href"].Value);


            }

            foreach (var VARIABLE in newsurl)
            {
                Console.WriteLine(VARIABLE);
            }
        }

    }
}