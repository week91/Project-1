using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Data.UoW;
using HappyNews.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NewsApi.Controllers
{
    [Route("api/[controller]")]
    public class NewsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public NewsController(IUnitOfWork uow)
        {
            _unitOfWork = uow;
           
           _unitOfWork.News.Insert(new News{BodyNews = "fesffsf",DateCreate = DateTime.Now,NewsTitle = "fefs"});
           _unitOfWork.News.Insert(new News{BodyNews = "dadfesawdadadasffsf",DateCreate = DateTime.Now,NewsTitle = "fedadadsgfgrgrs"});
              
               _unitOfWork.Save();
            
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<News> Get()
        {
          var newNews= _unitOfWork.News.GetAll().ToList();
            return (newNews);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid idd)
        {
            News newss = _unitOfWork.News.GetById(idd);

            if (newss == null)
                return NotFound();

            return  new ObjectResult(newss);


        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody]News news)
        {
            if (news == null)
            {
                return BadRequest();
            }

            _unitOfWork.News.Insert(news);
            _unitOfWork.Save();
            return Ok(news);
        
    }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public IActionResult Put(Guid id,[FromBody]News news)
        {
            if (news == null)
            {
                return BadRequest();
            }
           
            _unitOfWork.News.Update(news);
            _unitOfWork.Save();
            return Ok(news);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            News news = _unitOfWork.News.GetById(id);
            if (news== null)
            {
                return NotFound();
            }
            _unitOfWork.News.Delete(news);
            _unitOfWork.Save();
            return Ok(news);
        }
    }
}
