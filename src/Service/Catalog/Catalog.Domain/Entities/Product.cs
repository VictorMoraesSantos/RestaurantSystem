using Catalog.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Catalog.Domain.Entities
{
    public sealed class Product : Entity
    {
        public Product(string? name, string? description, string? imageUrl, decimal price, Category? category, ProductStatus status)
        {
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
            Price = price;
            Category = category;
            Status = status;
        }

        [Required]
        [StringLength(100)]
        public string? Name { get; private set; }
        [StringLength(500)]
        public string? Description { get; private set; }
        [StringLength(500)]
        public string? ImageUrl { get; private set; }
        [Range(0.01, 20000)]
        public decimal Price { get; private set; }
        public Guid CategoryId { get; private set; }
        public Category? Category { get; private set; }
        public ProductStatus Status { get; private set; }

        public void UpdateDetails(string name, string description, string imageUrl, decimal price)
        {
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
            Price = price;
        }

        public void UpdateStatus(ProductStatus status)
        {
            Status = status;
        }
    }
}
