using Catalog.Domain.Entities;
using MediatR;

namespace Catalog.Application.Queries.Products
{
    public class GetProductsQuery : IRequest<IEnumerable<Product>>
    {

    }
}
