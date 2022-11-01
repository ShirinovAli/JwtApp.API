using JwtApp.API.Core.Application.Dtos;
using MediatR;

namespace JwtApp.API.Core.Application.Features.CQRS.Queries
{
    public class GetAllCategoriesQueryRequest :IRequest<List<CategoryListDto>>
    {
        
    }
}