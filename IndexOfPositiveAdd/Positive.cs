using CoreApp;

namespace IndexOfPositiveAdd
{
    public class Positiv : IRaitOfPositiv

    {
        private IUnitOfWork _unitOfWork;
        private ILemmatization _lemmatization; 
        private IAfinn165 _afinn165; 
        

        public Positiv(IUnitOfWork unitOfWork, ILemmatization lemmatization,IAfinn165 afinn165) 
        {
            _unitOfWork = unitOfWork;
            _lemmatization = lemmatization;
            _afinn165 = afinn165;
        }

        public void PositiveAdd()
        {
            var dictAfinn = _afinn165.Afinn();
           var news= _unitOfWork.News.GetAll();
            foreach (var newse in news)
            {
                if (newse.IndexOfPositive == null)
                {
                    var wordUnraitNews = _lemmatization.Lemma(newse.BodyNews);

                    int rait = 0;
                    foreach (var word in wordUnraitNews)
                    {
                        if (dictAfinn.ContainsKey(word))
                        {
                            rait += dictAfinn[word];
                        }


                    }
                    newse.IndexOfPositive = rait / wordUnraitNews.Count;

                }
              
            }

           }
      
        
    }
}
