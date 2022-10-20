using MasterServicesFZ.Application.Features.Querys.VehicleClass.GetAllVehicleClassesByBrand;
using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MasterServicesFZ.API.Controllers
{
    [ApiController]
    [Route("Api/v1/[controller]")]
    public class VehicleClassController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VehicleClassController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<VehicleClassVM>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.Forbidden)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetVehicleClasses(string brandId)
        {
            var vehicleClasses = await _mediator.Send(new GetAllVehicleClassesByBrandQuery(brandId));
            return Ok(vehicleClasses);
        }
    }
}
