using MasterServicesFZ.Application.Features.Querys.VehicleTypes.GetAllVehicleTypesByBrandAndClassQuery;
using MasterServicesFZ.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MasterServicesFZ.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class VehicleTypesController : Controller
    {
        private readonly IMediator _mediator;

        public VehicleTypesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{classId}/{brandId}")]
        [ProducesResponseType(typeof(VehicleType), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> GetVeiclesTypes(string classId, string brandId)
        {
            var types = await _mediator.Send(new GetAllVehicleTypesByBrandAndClassQuery(classId, brandId));
            return Ok(types);
        }
    }
}
