using MasterServicesFZ.Application.Features.Querys.InternationalBusiness.GetAllInternationalBusiness;
using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MasterServicesFZ.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Authorize]
    public class InternationalBusinessController : ControllerBase
    {
        private readonly IMediator _mediator;
        public InternationalBusinessController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(GenericResponseVM), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.Forbidden)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAll()
        {
            var internationalBusiness = await _mediator.Send(new GetAllInternationalBusinessQuery());
            return Ok(internationalBusiness);
        }
    }
}
