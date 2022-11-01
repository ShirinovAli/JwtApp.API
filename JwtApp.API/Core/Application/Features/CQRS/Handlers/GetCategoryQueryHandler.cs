using AutoMapper;
using JwtApp.API.Core.Application.Dtos;
using JwtApp.API.Core.Application.Features.CQRS.Queries;
using JwtApp.API.Core.Application.Interfaces;
using JwtApp.API.Core.Domain;
using MediatR;

namespace JwtApp.API.Core.Application.Features.CQRS.Handlers
{
    public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQueryRequest, CategoryListDto>
    {
        private readonly IRepository<Category> _repository;
        private readonly IMapper _mapper;

        public GetCategoryQueryHandler(IRepository<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CategoryListDto> Handle(GetCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetByFilter(x => x.Id == request.Id);
            var dto = _mapper.Map<CategoryListDto>(data);
            return dto;
        }
    }
}
