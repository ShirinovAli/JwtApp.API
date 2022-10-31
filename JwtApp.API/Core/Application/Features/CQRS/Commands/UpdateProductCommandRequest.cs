using MediatR;

namespace JwtApp.API.Core.Application.Features.CQRS.Commands
{
    public class UpdateProductCommandRequest : IRequest
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CayegoryId { get; set; }
    }
}
