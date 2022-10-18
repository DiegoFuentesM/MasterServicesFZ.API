﻿using Microsoft.AspNetCore.Mvc;
using MediatR;
using MasterServicesFZ.Domain;
using System.Net;
using MasterServicesFZ.Application.Features.Querys.Brands.GetAllBrandsQuery;

namespace MasterServicesFZ.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class VehicleBrandsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VehicleBrandsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(VehicleBrand), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> GetVehicleBrands()
        {
            var brands = await _mediator.Send(new GetAllBrandsQuery());
            return Ok(brands);
        }

        

    }
}
