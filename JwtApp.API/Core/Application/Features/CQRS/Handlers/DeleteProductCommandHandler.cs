using JwtApp.API.Core.Application.Features.CQRS.Commands;
using JwtApp.API.Core.Application.Interfaces;
using JwtApp.API.Core.Domain;
using MediatR;

namespace JwtApp.API.Core.Application.Features.CQRS.Handlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest>
    {
        private readonly IRepository<Product> _repository;

        public DeleteProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var deletedEntity = await _repository.GetByIdAsync(request.Id);
            if (deletedEntity != null)
            {
                await _repository.RemoveAsync(deletedEntity);
            }
            return Unit.Value;
        }
    }
}
