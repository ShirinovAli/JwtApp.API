using JwtApp.API.Core.Application.Dtos;
using MediatR;

namespace JwtApp.API.Core.Application.Features.CQRS.Queries
{
    public class GetAllProductsQueryRequest : IRequest<List<ProductListDto>>
    {
    }
}
