using Catalog.Domain.Enums;

namespace Catalog.Application.DTOs
{
    public record ProductDTO(Guid Id, string Name, string Description, decimal Price, Guid CategoryId, int Quantity, ProductStatus Status, string ImageFile);
}
