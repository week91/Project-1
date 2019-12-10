using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Core;
using Hangfire;
using HappyNews.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsApi.MediatR.Commands;
using NewsApi.MediatR.Queries;
using Newtonsoft.Json;
using Services.CreateNews;
using Services.UoW;

namespace NewsApi.Controllers
{[Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        
        private readonly IMediator mediator;
        public NewsController(IMediator mediator)
        {
          
            this.mediator = mediator;
          
        }
       
        [HttpGet]
        public async Task<IEnumerable<News>> Get() =>         //Get All News 
            await mediator.Send(new GetAllNewsQuery());

        [HttpGet("{id}")]                             //Get by id 
        public async Task<News> Get(Guid id) =>
            await mediator.Send(new GetNewsQuery(id));

        [HttpPost]
        public async Task<Guid> Create([FromBody]News news) =>
            await mediator.Send(new CreateNewsCommand(news));

        [HttpDelete("{id}")]
        public async Task<bool> Delete(Guid id) =>
            await mediator.Send(new RemoveNewsCommand(id));

    }
}