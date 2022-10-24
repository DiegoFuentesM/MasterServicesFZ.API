using MasterServicesFZ.Application.Features.Querys.VehicleModels.GetAllModelsByVehicleType;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MasterServicesFZ.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class VehicleModelController : ControllerBase
    {
        private readonly IMediator _mediator;
        public VehicleModelController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [HttpGet("{vehicleTypeId}")]
        public async Task<IActionResult> GetAllVehicleModels(int vehicleTypeId)
        {
            var models = await _mediator.Send(new GetAllModelsByVehicleTypeQuery(vehicleTypeId));
            return Ok(models);
        }
    }
}
