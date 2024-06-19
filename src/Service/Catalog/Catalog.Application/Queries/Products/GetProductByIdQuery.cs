using Catalog.Domain.Entities;
using MediatR;

namespace Catalog.Application.Queries.Products
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        public Guid Id { get; set; }

        public GetProductByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
