using MasterServicesFZ.Application.Features.Querys.GetAllIdentificationTypesQuery;
using MasterServicesFZ.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MasterServicesFZ.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class IdentificationTypesController : Controller
    {
        private readonly IMediator _mediator;

        public IdentificationTypesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IdentificactionType), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> GetIdentificationTypes()
        {
            var identificationTypes = await _mediator.Send(new GetAllIdentificationTypesQuery());
            return Ok(identificationTypes);
        }
    }
}
