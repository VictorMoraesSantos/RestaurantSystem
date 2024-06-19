using Catalog.Application.Queries.Products;
using Catalog.Domain.Interfaces;
using MediatR;

namespace Catalog.Application.Handlers.Products
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Domain.Entities.Product>
    {
        private readonly IProductRepository _productRepository;

        public GetProductByIdQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Domain.Entities.Product> Handle(GetProductByIdQuery request,
                                                          CancellationToken cancellationToken)
        {
            return await _productRepository.GetProductAsync(request.Id);
        }
    }
}
