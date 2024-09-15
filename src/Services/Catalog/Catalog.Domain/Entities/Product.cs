using Catalog.Domain.Enums;
using Catalog.Domain.Exceptions;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Catalog.Domain.Entities
{
    public class Product : EntityBase
    {
        [Required(ErrorMessage = "The Name is required")]
        [MaxLength(100, ErrorMessage = "The Name must not exceed 100 characters")]
        public string Name { get; private set; }

        [Required(ErrorMessage = "The Description is required")]
        [MaxLength(500, ErrorMessage = "The Description must not exceed 500 characters")]
        public string Description { get; private set; }

        [Required(ErrorMessage = "The Price is required")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; private set; }

        [Required(ErrorMessage = "The Category is required")]
        public Guid CategoryId { get; private set; }

        public Category Category { get; private set; }

        [Required(ErrorMessage = "The Quantity is required")]
        public int Quantity { get; private set; }

        [Required(ErrorMessage = "The Status is required")]
        public ProductStatus Status { get; private set; }

        [Required(ErrorMessage = "The ImageFile is required")]
        [MaxLength(250, ErrorMessage = "The ImageFile must not exceed 250 characters")]
        public string ImageFile { get; private set; }

        public Product(Guid id, string name, string description, decimal price, Guid categoryId, int quantity, ProductStatus status, string imageFile)
        {
            Validate(name, description, price, quantity, imageFile);
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            CategoryId = categoryId;
            Quantity = quantity;
            Status = status;
            ImageFile = imageFile;
        }

        public void Update(string name, string description, decimal price, int quantity, ProductStatus status, string imageFile)
        {
            Validate(name, description, price, quantity, imageFile);
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
            Status = status;
            ImageFile = imageFile;
        }

        private void Validate(string name, string description, decimal price, int quantity, string imageFile)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new DomainException("Name cannot be empty.");
            if (string.IsNullOrWhiteSpace(description))
                throw new DomainException("Description cannot be empty.");
            if (price <= 0)
                throw new DomainException("Price must be greater than zero.");
            if (quantity <= 0)
                throw new DomainException("Quantity must be greater than zero.");
            if (string.IsNullOrWhiteSpace(imageFile))
                throw new DomainException("ImageFile cannot be empty.");
        }
    }
}
