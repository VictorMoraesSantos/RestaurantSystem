using Catalog.Domain.Entities;
using MediatR;

namespace Catalog.Application.Commands.Categories
{
    public class CategoryCommand : IRequest<Category>
    {
        public string? Name { get; private set; }
        public List<Product>? Products { get; private set; }
    }
}
