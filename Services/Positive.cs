using CoreApp;

namespace IndexOfPositiveAdd
{
    public class Positiv : IRaitOfPositiv

    {
        private readonly DbContent _dbContent;
        private readonly ILemmatization _lemmatization; 
        private readonly IAfinn165 _afinn165; 
        

        public Positiv(DbContent dbContent, ILemmatization lemmatization,IAfinn165 afinn165)
        {
            _dbContent = dbContent;
            _lemmatization = lemmatization;
            _afinn165 = afinn165;
        }

        public void PositiveAdd()
        {
            var dictAfinn = _afinn165.Afinn();
             var news= _dbContent.Newses;
            foreach (var newse in news)
            {
                if (newse.IndexOfPositive == 0)
                {
                    double rait = 0.0;
                    var wordUnraitNews = _lemmatization.Lemma(newse.BodyNews);

                   
                    foreach (var word in wordUnraitNews)
                    {
                        if (dictAfinn.ContainsKey(word))
                        {
                           rait += dictAfinn[word];
                        }


                    }

                  newse.IndexOfPositive=  rait / wordUnraitNews.Count;
                 // _unitOfWork.News.Update(newse);
                  _dbContent.Newses.Add(newse);
                  _dbContent.SaveChanges();

                }
              
            }


            
        }
      
        
    }
}
