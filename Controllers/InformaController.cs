using MediatR;
using MediatrTest.Domain;
using MediatrTest.Features.Informa.Commands;
using MediatrTest.Features.Informa.Queries;
using Microsoft.AspNetCore.Mvc;

namespace MediatrTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InformaController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        [HttpPost, Route("", Name = "Process[controller]")]
        public virtual async Task ProcessAsync([FromBody] Newsletter request)
        {
            await _mediator.Send(new ProcessNewsletter(request));
        }

        [HttpGet, Route("", Name = "GetAll[controller]")]
        public async Task<IEnumerable<Newsletter>> GetAllAsync()
        {
            return await _mediator.Send(new GetAllNewslettersQuery());
        }

        [HttpGet, Route("{id:int}", Name = "Get[controller]ById")]
        public async Task<Newsletter?> GetByIdAsync(int id)
        {
            return await _mediator.Send(new GetNewslettersById(id));
        }
    }
}
