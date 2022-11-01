using AutoMapper;
using JwtApp.API.Core.Application.Dtos;
using JwtApp.API.Core.Application.Features.CQRS.Queries;
using JwtApp.API.Core.Application.Interfaces;
using JwtApp.API.Core.Domain;
using MediatR;

namespace JwtApp.API.Core.Application.Features.CQRS.Handlers
{
    public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQueryRequest, List<CategoryListDto>>
    {
        private readonly IRepository<Category> _repository;
        private readonly IMapper _mapper;

        public GetAllCategoriesQueryHandler(IRepository<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<CategoryListDto>> Handle(GetAllCategoriesQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetAllAsync();
            var dto = _mapper.Map<List<CategoryListDto>>(data);
            return dto;
        }
    }
}
