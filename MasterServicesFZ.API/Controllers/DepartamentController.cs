using MasterServicesFZ.Application.Features.Querys.Departaments.GetAllDepartaments;
using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MasterServicesFZ.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class DepartamentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DepartamentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(GenericResponseVM), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.Forbidden)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetDepartaments()
        {
            var departaments = await _mediator.Send(new GetAllDepartamentsQuery());
            return Ok(departaments);
        }
    }
}
