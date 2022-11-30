﻿using MasterServicesFZ.Application.Features.Querys.VehicleTypes.GetAllVehicleTypesByBrandAndClassQuery;
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
    public class VehicleTypeController : Controller
    {
        private readonly IMediator _mediator;

        public VehicleTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{classId}/{brandId}")]
        [ProducesResponseType(typeof(GenericResponseVM), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> GetVeiclesTypes(string classId, string brandId)
        {
            var types = await _mediator.Send(new GetAllVehicleTypesByBrandAndClassQuery(classId, brandId));
            return Ok(types);
        }
    }
}
