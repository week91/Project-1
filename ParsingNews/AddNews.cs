using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using CoreApp;
using HtmlAgilityPack;
using Model1;

namespace ParsingNews
{
    public class AddNews : IAddNews
    {


        public List<News> AddNewsList(List<string> urls)// pars and create news 
        {

            List<News> News1 = new List<News>();


            Regex regex = new Regex(@"&[a-z ]*\;");

            foreach (string html in urls)
            {
                if (html.Substring(0, 11) != "http://help")
                {


                    string bodyText = "";
                    HtmlWeb web = new HtmlWeb();
                    var htmlDoc = web.Load(html);

                    var htmlBody2 = htmlDoc.DocumentNode.SelectNodes("//div [@class='js-mediator-article']");
                    if (htmlBody2 != null)
                    {

                        foreach (var nodes in htmlBody2)
                        {
                            if (nodes != null)
                            {

                                bodyText += nodes.InnerText;
                            }

                        }
                    }

                    var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//div/h1");
                    if (htmlBody != null)

                        News1.Add(new News
                        {
                            Source = html,
                            BodyNews = regex.Replace(bodyText, " "),
                            DateCreate = DateTime.Now,
                            NewsTitle = htmlBody.InnerText,
                            id = Guid.NewGuid()
                        });

                }



            }
            return News1;
        }


    }
}
