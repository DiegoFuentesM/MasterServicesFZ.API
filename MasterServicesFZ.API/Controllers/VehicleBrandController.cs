using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Net;
using MasterServicesFZ.Application.Features.Querys.Brands.GetAllBrandsQuery;
using MasterServicesFZ.Application.Features.Shared.VMs;

namespace MasterServicesFZ.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class VehicleBrandController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VehicleBrandController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(GenericResponseVM), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> GetVehicleBrands()
        {
            var brands = await _mediator.Send(new GetAllBrandsQuery());
            return Ok(brands);
        }

        

    }
}
