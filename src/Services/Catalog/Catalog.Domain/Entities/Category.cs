using Catalog.Domain.Exceptions;
using System.ComponentModel.DataAnnotations;

namespace Catalog.Domain.Entities
{
    public class Category : EntityBase
    {
        [Required(ErrorMessage = "The Name is required")]
        [MinLength(3, ErrorMessage = "The Name must have at least 3 characters")]
        [MaxLength(100, ErrorMessage = "The Name must not exceed 100 characters")]
        public string Name { get; private set; }

        [Required(ErrorMessage = "The Description is required")]
        [MinLength(3, ErrorMessage = "The Description must have at least 3 characters")]
        [MaxLength(100, ErrorMessage = "The Description must not exceed 100 characters")]
        public string Description { get; private set; }

        public Category(string name, string description)
        {
            Validate(name, description);
            Name = name;
            Description = description;
        }

        public Category(Guid id, string name, string description)
        {
            Validate(name, description);
            Id = id;
            Name = name;
            Description = description;
        }

        public void Update(string name, string description)
        {
            Validate(name, description);
            Name = name;
            Description = description;
        }

        private void Validate(string name, string description)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new DomainException("Name cannot be empty.");
            if (name.Length < 3)
                throw new DomainException("Name must have at least 3 characters.");
            if (name.Length > 100)
                throw new DomainException("Name must not exceed 100 characters.");

            if (string.IsNullOrWhiteSpace(description))
                throw new DomainException("Description cannot be empty.");
            if (description.Length < 3)
                throw new DomainException("Description must have at least 3 characters.");
            if (description.Length > 100)
                throw new DomainException("Description must not exceed 100 characters.");
        }
    }
}
