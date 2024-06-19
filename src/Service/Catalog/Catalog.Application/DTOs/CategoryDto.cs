using Catalog.Domain.Entities;

namespace Catalog.Application.Dtos
{
    public class CategoryDto
    {
        public string? Name { get; set; }
        public List<Product>? Products { get; set; }
    }
}
