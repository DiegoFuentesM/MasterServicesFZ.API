using MasterServicesFZ.Application.Features.Querys.ResidenceTypes.GetAllResidenceTypes;
using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MasterServicesFZ.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ResidenceTypeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ResidenceTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet]
        [ProducesResponseType(typeof(GenericResponseVM), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.Forbidden)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAll(){
            var residenceTypes = await _mediator.Send(new GetAllResidenceTypesQuery());
            return Ok(residenceTypes);
        }
    }
}
