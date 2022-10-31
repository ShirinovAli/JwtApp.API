using JwtApp.API.Core.Application.Dtos;
using MediatR;

namespace JwtApp.API.Core.Application.Features.CQRS.Queries
{
    public class GetProductQueryRequest : IRequest<ProductListDto>
    {
        public int Id { get; set; }
        public GetProductQueryRequest(int id)
        {
            Id = id;
        }
    }
}
