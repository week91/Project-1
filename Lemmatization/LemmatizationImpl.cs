using CoreApp;
using Model1.LemmaModels;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Lemmatization
{

    public class LemmatizationImpl : ILemmatization
    {
        public List<string> Lemma(string lem)
        {
            string shortlem=lem.Remove(250, lem.Length-250);

            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")); //ACCEPT header

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post,
                "http://api.ispras.ru/texterra/v1/nlp?targetType=lemma&apikey=9ea81b36fd8c541c87a0df7b8766279b50268ff8");
            request.Content = new StringContent(
                "[{ \"text\" : \"" + shortlem + " попа класс\" }]",
                Encoding.UTF8,
                "application/json"); //CONTENT-TYPE header

            var x = client.SendAsync(request).Result;

            var jsonobj = x.Content.ReadAsStringAsync().Result;
            ;
            var lemmaobj = JsonConvert.DeserializeObject<List<ResponseLemmaObject>>(jsonobj);
            var words = new List<string>();
            foreach (var obj in lemmaobj)
            {
                var lemmaList = obj.annotations.lemma;

                foreach (var lemma in lemmaList)
                {
                    if (lemma.value != "")
                    {
                        words.Add(lemma.value);
                    }

                }

            }

            return words;
            
        }
       
    }
}

