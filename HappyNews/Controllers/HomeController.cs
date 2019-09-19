using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HappyNews.Models;
using Microsoft.EntityFrameworkCore;

namespace HappyNews.Controllers
{
    public class HomeController : Controller
    {
        private DbContent _content;

        public HomeController(DbContent content)
        {
            _content = content;
        }
        public IActionResult Index()
        {
           List<News> HapNews =_content.Newses.ToList();
           

            return View(HapNews);
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
