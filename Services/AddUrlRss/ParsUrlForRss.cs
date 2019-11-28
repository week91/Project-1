using System.Collections.Generic;
using System.Xml;

namespace Services.AddUrlRss
{
    public class ParsUrlForRss
    {

        public List<string> AddUrls(string RssChanelUrl) //parse rrs chanel
        {
            
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
            return (rssUrls); 
        }
    }
}

