using Catalog.Domain.Entities;
using MediatR;

namespace Catalog.Application.Commands.Products
{
    public class ProductDeleteCommand : IRequest<Product>
    {
        public Guid Id { get; set; }

        public ProductDeleteCommand(Guid id)
        {
            Id = id;
        }
    }
}
