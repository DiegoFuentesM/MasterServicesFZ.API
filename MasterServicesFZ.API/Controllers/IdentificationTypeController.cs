using MasterServicesFZ.Application.Features.Querys.GetAllIdentificationTypesQuery;
using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MasterServicesFZ.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class IdentificationTypeController : Controller
    {
        private readonly IMediator _mediator;

        public IdentificationTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(GenericResponseVM), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> GetIdentificationTypes()
        {
            var identificationTypes = await _mediator.Send(new GetAllIdentificationTypesQuery());
            return Ok(identificationTypes);
        }
    }
}
