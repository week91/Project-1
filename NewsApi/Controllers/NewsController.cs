using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Model1;
using MyMediatr.Commands.NewsCommand;
using MyMediatr.Queries.NewsQueries;

namespace NewsApi.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
   
    public class NewsController : ControllerBase
    {

        private readonly IMediator mediator;
        public NewsController(IMediator mediator)
        {

            this.mediator = mediator;

        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await mediator.Send(new GetAllNewsQuery());  //Get All News 
            return Ok(result);
        }


        [HttpGet("{id}")] //Get by id 
        public async Task<IActionResult> Get(Guid id)
        {
          var result = await mediator.Send(new GetNewsQuery(id));
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] News news)
        {
            var result = await mediator.Send(new CreateNewsCommand(news));
            return  Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await mediator.Send(new RemoveNewsCommand(id));
           return Ok(result);
        }

    }
}