﻿using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using HappyNews.Models;
using HappyNews.UoW;
using HappyNews.ViewsModel;
using HtmlAgilityPack;


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
            var NewsInBase = _unitOfWork.News.GetAll();
           return View(model: NewsInBase);
        }

        public IActionResult News(Guid N)
        {
            News News1=null;
            var NewsInBase = _unitOfWork.News.GetAll();
            foreach (var news in NewsInBase)
            {
                if (news.id == N)
                {
                    News1 = news;
                }
            }

            return View(News1);
        }

        public IActionResult Privacy()
        {
           
            return View();
        }
        public IActionResult AddNews()
        {

            return View();
            
        }
        
        public IActionResult AddNewsInBase(string Rss)
        {
            AddNews news =new AddNews();

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

            return RedirectToAction("AddNews","Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
