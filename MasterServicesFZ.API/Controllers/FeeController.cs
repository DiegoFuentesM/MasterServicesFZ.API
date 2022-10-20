using MasterServicesFZ.Application.Features.Querys.Fees.GetAllFees;
using MasterServicesFZ.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MasterServicesFZ.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class FeeController : Controller
    {
        private readonly IMediator _mediator;

        public FeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(Fee), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.Forbidden)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAllFees()
        {
            var fees = await _mediator.Send(new GetAllFeesQuery());
            return Ok(fees);
        }
    }
}
