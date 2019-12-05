using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Core.Models;
using HappyNews.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Services;
using Services.UoW;

namespace HappyNews.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork uow)
        {
           _unitOfWork =uow;
        
        }

      
        [HttpGet]

          public JsonResult Comment( string data)  //get data for  new comments 
        { 
            Comments NewComment = JsonConvert.DeserializeObject<Comments>(data);

            

            _unitOfWork.Comments.Insert(NewComment);
            _unitOfWork.Save();
                 
             
            return Json(data);


        }
          [HttpGet]
          public JsonResult CommentAdd(string data)
          {
              string id = JsonConvert.DeserializeObject<string>(data);
             var comm= _unitOfWork.Comments.GetAll();
             List<Comments> listt = new List<Comments>();
            foreach (var  coment in comm)
             {
                 if (coment.NewsId.ToString()==id)
                 {
                     listt.Add(coment);
                }
                
             }
            
            string comment = JsonConvert.SerializeObject(listt, Formatting.Indented);
            return Json(comment);

        }


        public IActionResult Index()
        {
            var NewsInBase = _unitOfWork.News.GetAll();
           return View(model: NewsInBase);
        }

        public IActionResult News(Guid ID)
        {
            
            var NewsInBase = _unitOfWork.News.GetById(ID);
           
            return View(NewsInBase);

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

            return RedirectToAction("Index","Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
