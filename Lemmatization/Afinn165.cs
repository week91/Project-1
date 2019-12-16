using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CoreApp;
using Newtonsoft.Json;

namespace Lemmatization
{
   public class Afinn165:IAfinn165
    {
       
        public Dictionary<dynamic, int> Afinn()
        {
            var path = @"C:\Users\week\Desktop\AFINN.json";

            StreamReader sr = new StreamReader(path);//Loader json

            var json = sr.ReadToEnd();

            var affin = JsonConvert.DeserializeObject<Dictionary<dynamic, int>>(json); //convert json  to dictionary 
            return affin;
        }
    }
}
