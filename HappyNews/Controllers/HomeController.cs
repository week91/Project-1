using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using HappyNews.Addnews;
using Microsoft.AspNetCore.Mvc;
using HappyNews.Models;
using HappyNews.Repo;
using HappyNews.UoW;

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
            add news=new add();
            var listnews = news.AddNews("http://s13.ru/rss/.rss");

            foreach (var newss in listnews)

            {
                _unitOfWork.News.Insert(newss);
                _unitOfWork.Save();
                
            }
            _unitOfWork.Save();
            var news1 =_unitOfWork.News.GetAll();
            
            return View(model: news1);
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
