using MasterServicesFZ.Application.Features.Querys.Municipalities.GetMunicipalityByDepartament;
using MasterServicesFZ.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MasterServicesFZ.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class MunicipalityController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MunicipalityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(Municipality), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.Forbidden)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetMunicipalities(string departamentId)
        {
            var municipalities = await _mediator.Send(new GetAllMunicipalityByDepartamentQuery(departamentId));
            return Ok(municipalities);
        }
    }
}
