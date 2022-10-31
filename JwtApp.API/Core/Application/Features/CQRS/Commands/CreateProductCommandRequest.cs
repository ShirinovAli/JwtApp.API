using MediatR;

namespace JwtApp.API.Core.Application.Features.CQRS.Commands
{
    public class CreateProductCommandRequest :IRequest
    {
        public string? Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CayegoryId { get; set; }
    }
}
