using Catalog.Domain.Models;

namespace Catalog.Application.Dtos
{
    public class CategoryDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public List<Product>? Products { get; set; }
    }
}
