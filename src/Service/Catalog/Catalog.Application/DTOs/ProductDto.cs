using Catalog.Domain.Entities;

namespace Catalog.Application.Dtos
{
    public class ProductDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public decimal Price { get; set; }
        public Category? Category { get; set; }
    }
}
