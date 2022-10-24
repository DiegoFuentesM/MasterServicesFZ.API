using MasterServicesFZ.Application.Features.Querys.Occupations.GetAllOccupationsQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MasterServicesFZ.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class OccupationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OccupationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOccupations()
        {
            var occupations = await _mediator.Send(new GetAllOccupationsQuery());
            return Ok(occupations);
        }
    }
}
