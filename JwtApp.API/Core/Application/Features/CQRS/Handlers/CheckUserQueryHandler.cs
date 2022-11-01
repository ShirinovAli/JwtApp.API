using JwtApp.API.Core.Application.Dtos;
using JwtApp.API.Core.Application.Features.CQRS.Queries;
using JwtApp.API.Core.Application.Interfaces;
using JwtApp.API.Core.Domain;
using MediatR;

namespace JwtApp.API.Core.Application.Features.CQRS.Handlers
{
    public class CheckUserQueryHandler : IRequestHandler<CheckUserQueryRequest, CheckUserResponseDto>
    {
        private readonly IRepository<AppUser> _userRepository;
        private readonly IRepository<AppRole> _roleRepository;

        public CheckUserQueryHandler(IRepository<AppUser> userRepository, IRepository<AppRole> roleRepository)
        {
            _userRepository = userRepository;
            _roleRepository = roleRepository;
        }

        public async Task<CheckUserResponseDto> Handle(CheckUserQueryRequest request, CancellationToken cancellationToken)
        {
            var dto = new CheckUserResponseDto();

            var user = await _userRepository.GetByFilter(x => x.Username == request.Username && x.Password == request.Password);
            if (user == null)
            {
                dto.IsExists = false;
            }
            else
            {
                dto.Username = user.Username;
                dto.Id = user.Id;
                dto.IsExists = true;

                var role = await _roleRepository.GetByFilter(x => x.Id == user.AppRoleId);
                dto.Role = role?.Definition;
            }
            return dto;
        }
    }
}
