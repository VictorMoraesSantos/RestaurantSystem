using Catalog.Application.Dtos;
using Catalog.Domain.Models;

namespace Catalog.Infrasctructure.Repository.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductAsync(Guid Id);
        Task<IEnumerable<Product>> GetProductsByCategory(Category category);
        Task<Product> PostProductAsync(Product product);
        Task<Product> UpdateProductAsync(Product product);
        Task<bool> DeleteProductAsync(Guid Id);
    }
}
