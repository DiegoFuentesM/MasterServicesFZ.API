using MasterServicesFZ.Application.Features.Querys.Professions.GetAllProfessions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MasterServicesFZ.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Authorize]
    public class ProfessionController : Controller
    {
        private readonly IMediator _mediator;

        public ProfessionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProfessions()
        {
            var query = await _mediator.Send(new GetAllProfessionsQuery());

            return Ok(query);
        }
    }
}
