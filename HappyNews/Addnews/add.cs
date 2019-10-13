using HappyNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace HappyNews.Addnews
{
    public class add : IAddNews
    {


        public List<News> AddNews(string url)
        {
            List<News> newses = new List<News>();

            XmlTextReader xmlTextReader = new XmlTextReader(url);

            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load(xmlTextReader);

            xmlTextReader.Close();

            XmlElement xRoot = xmlDoc.DocumentElement;

            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "channel")
                {

                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {

                        if (childnode.Name == "item")
                        {
                            foreach (XmlNode node1 in childnode.ChildNodes)
                            {
                                if (node1.Name == "link")
                                {
                                    string sorce = node1.InnerText;

                                    newses.Add(new News
                                    {
                                        Source = node1.InnerText,
                                        DateCreate = DateTime.Now,
                                        NewsTitle = "jjj",
                                        BodyNews = "kl;l",
                                        IndexOfPosition = "7",
                                        
                                    });

                                }

                            }


                        }

                    }

                    
                }
               
            }
            return (newses);
        }
    }
}

