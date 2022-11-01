using JwtApp.API.Core.Application.Dtos;
using MediatR;

namespace JwtApp.API.Core.Application.Features.CQRS.Queries
{
    public class CheckUserQueryRequest : IRequest<CheckUserResponseDto>
    {
        public string Username { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
    }
}
