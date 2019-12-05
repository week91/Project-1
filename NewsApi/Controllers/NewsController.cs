using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using HappyNews.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NewsApi.MediatR.Commands;
using NewsApi.MediatR.Queries;

namespace NewsApi.Controllers
{[Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private IMediator mediator;
        public NewsController(IMediator mediator) =>
            this.mediator = mediator;

        [HttpGet]
        public async Task<IEnumerable<News>> Get() =>
            await mediator.Send(new GetAllNewsQuery());

        [HttpGet("{id}")]
        public async Task<News> Get(Guid id) =>
            await mediator.Send(new GetNewsQuery(id));

        [HttpPost]
        public async Task<Guid> Create([FromBody] News news) =>
            await mediator.Send(new CreateNewsCommand(news));

        [HttpDelete("{id}")]
        public async Task<bool> Delete(Guid id) =>
            await mediator.Send(new RemoveNewsCommand(id));

    }
}