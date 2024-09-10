using Catalog.Domain.Entities;
using Catalog.Domain.Enums;

namespace Catalog.Application.DTOs
{
    public record ProductDTO(string Name, string Description, decimal Price, Category Category, int Quantity, ProductStatus Status, string ImageFile);
}
