using JwtApp.API.Core.Application.Features.CQRS.Commands;
using JwtApp.API.Core.Application.Features.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Register(RegisterUserCommandRequest request)
        {
            await _mediator.Send(request);
            return Created("", request);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> SignIn(CheckUserQueryRequest request)
        {
            var userDto = await _mediator.Send(request);
            if (userDto.IsExists)
            {
                return Created("", 123);
            }
            return BadRequest("Username or Password is not valid");
        }
    }
}
