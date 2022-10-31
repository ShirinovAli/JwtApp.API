using JwtApp.API.Core.Application.Features.CQRS.Commands;
using JwtApp.API.Core.Application.Interfaces;
using JwtApp.API.Core.Domain;
using MediatR;

namespace JwtApp.API.Core.Application.Features.CQRS.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest>
    {
        private readonly IRepository<Product> _repository;

        public CreateProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Product
            {
                CayegoryId = request.CayegoryId,
                Name = request.Name,
                Price = request.Price,
                Stock = request.Stock,
            });

            return Unit.Value;
        }
    }
}
