using CoreApp;

namespace IndexOfPositiveAdd
{
    public class Positiv : IRaitOfPositiv

    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILemmatization _lemmatization; 
        private readonly IAfinn165 _afinn165; 
        

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
                  _unitOfWork.News.Update(newse);
                  _unitOfWork.Save();

                }
              
            }


            
        }
      
        
    }
}
