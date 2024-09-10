using Catalog.Application.DTOs;
using Catalog.Domain.Entities;

namespace Catalog.Application.Interfaces
{
    public interface IProductService : IGenericService<ProductDTO>
    {
        Task<ProductDTO> GetProductByName(string productName);
        Task<IEnumerable<ProductDTO>> GetProductsByCategory(CategoryDTO category);
    }
}
