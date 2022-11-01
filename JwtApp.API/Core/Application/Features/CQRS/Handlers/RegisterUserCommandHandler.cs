using JwtApp.API.Core.Application.Enums;
using JwtApp.API.Core.Application.Features.CQRS.Commands;
using JwtApp.API.Core.Application.Interfaces;
using JwtApp.API.Core.Domain;
using MediatR;

namespace JwtApp.API.Core.Application.Features.CQRS.Handlers
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommandRequest>
    {
        private readonly IRepository<AppUser> _repository;

        public RegisterUserCommandHandler(IRepository<AppUser> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(RegisterUserCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new AppUser
            {
                Username = request.Username,
                Password = request.Password,
                AppRoleId = (int)RoleType.Member
            });
            return Unit.Value;
        }
    }
}
