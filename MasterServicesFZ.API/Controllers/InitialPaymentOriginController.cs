using MasterServicesFZ.Application.Features.Querys.InitialPaymentOrigin.GetAllInitialPaymentOrigin;
using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MasterServicesFZ.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Authorize]
    public class InitialPaymentOriginController : Controller
    {
        private readonly IMediator _mediator;

        public InitialPaymentOriginController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllInitialPaymentOrigins()
        {
            var query = await _mediator.Send(new GetAllInitialPaymentOriginQuery());
            return Ok(query);
        }
    }
}
