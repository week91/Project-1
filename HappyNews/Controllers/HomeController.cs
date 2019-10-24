using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using HappyNews.Addnews;
using Microsoft.AspNetCore.Mvc;
using HappyNews.Models;
using HappyNews.Repo;
using HappyNews.UoW;
using HappyNews.ViewsModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Authentication;
using Microsoft.IdentityModel.Tokens.Saml2;

namespace HappyNews.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public HomeController(IUnitOfWork uow)
        {
           _unitOfWork =uow;
        
        }

        public IActionResult index()
        {
           //AddNews news =new AddNews();
           //var listNewses= news.AddNewsList("http://s13.ru/rss/.rss");
           
            
           var NewsInBase = _unitOfWork.News.GetAll();
           // foreach (News newnews in listNewses)
           // {
           //     if (NewsInBase.Count() == 0)
           //     {

           //         _unitOfWork.News.Insert(newnews);
           //     }
           //     foreach (var t in NewsInBase)
           //     {
           //        if (t.Source != newnews.Source)
           //        {

           //             _unitOfWork.News.Insert(newnews);
           //        }
           //   }

                    

                
           // }

          //_unitOfWork.Save();
           
            
            return View(model: NewsInBase);
        }
    
        public IActionResult Privacy()
        {
           
           
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
