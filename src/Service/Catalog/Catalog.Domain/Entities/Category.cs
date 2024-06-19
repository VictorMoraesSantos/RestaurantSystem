using System.ComponentModel.DataAnnotations;

namespace Catalog.Domain.Entities
{
    public class Category : Entity
    {
        public Category(string? name, List<Product>? products)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Category name cannot be empty.", nameof(name));

            Name = name;
            Products = products;
        }

        [Required]
        [StringLength(100)]
        public string? Name { get; private set; }
        public List<Product>? Products { get; private set; }

        public void AddProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            Products!.Add(product);
        }

        public void UpdateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Category name cannot be empty.", nameof(name));

            Name = name;
        }

        public bool RemoveProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            return Products!.Remove(product);
        }

    }
}
