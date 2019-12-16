using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Model1;
using MyMediatr.Commands.CommentsCommand;
using MyMediatr.Queries.CommentsQueries;

namespace NewsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController: ControllerBase
    {
        private readonly IMediator mediator;
        public CommentsController(IMediator mediator)
        {

            this.mediator = mediator;

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await mediator.Send(new GetCommentsQuery());  //Get All comment 
            return Ok(result);
        }



        [HttpGet("{id}")] //Get by id 
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await mediator.Send(new GetCommentQuery(id));
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Comments comments)
        {
            var result = await mediator.Send(new CreateCommentCommand(comments));
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await mediator.Send(new RemoveCommentsCommand(id));
            return Ok(result);
        }
    }
}
