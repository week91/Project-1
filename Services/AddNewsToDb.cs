using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HappyNews.Entities;
using Services.UoW;

namespace Services
{
    class AddNewsToDb
    {
        private readonly IUnitOfWork _unitOfWork;

        AddNewsToDb(IUnitOfWork _unitOfWork)
        {
            this._unitOfWork = _unitOfWork;
        }
       public void AddNewsInBase(string Rss)

        {

            AddNews news = new AddNews();

            var listNewses = news.AddNewsList(Rss);

            var NewsInBase = _unitOfWork.News.GetAll();

            foreach (News newnews in listNewses)
            {
                if (NewsInBase.Count() == 0)
                {
                    _unitOfWork.News.Insert(newnews);
                }
                foreach (News newNews in NewsInBase)
                {
                    if (newNews.Source != newnews.Source)
                    {
                        _unitOfWork.News.Insert(newnews);
                    }

                }

            }

            _unitOfWork.Save();

           
        }
    }
}
