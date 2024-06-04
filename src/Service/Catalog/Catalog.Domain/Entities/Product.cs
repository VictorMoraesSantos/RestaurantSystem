using Catalog.Domain.Enums;

namespace Catalog.Domain.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public decimal Price { get; set; }
        public Category? Category { get; set; }
        public ProductStatus Status { get; set; }
    }
}
