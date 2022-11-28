using MasterServicesFZ.Application.Features.Querys.GoodTypes.GetAllGoodTypes;
using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MasterServicesFZ.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class GoodTypeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GoodTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(GenericResponseVM), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.Forbidden)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GeAll()
        {
            var goodTypes = await _mediator.Send(new GetAllGoodTypesQuery());
            return Ok(goodTypes);
        }
    }
}
