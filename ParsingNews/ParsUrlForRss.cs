using System.Collections.Generic;
using System.Xml;
using CoreApp;

namespace ParsingNews
{
    public class ParsUrlForRss : IParsUrlForRss
    {

        public List<string> AddUrls() //parse rrs chanel
        {
            string RssChanelUrl = "http://s13.ru/rss/.rss";


            List<string> rssUrls = new List<string>();

            XmlTextReader xmlTextReader = new XmlTextReader(RssChanelUrl);

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
                            foreach (XmlNode node in childnode.ChildNodes)
                            {
                                if (node.Name == "link")
                                {
                                    rssUrls.Add(node.InnerText);


                                }

                            }


                        }

                    }


                }

            }
            return rssUrls;
        }
    }
}

