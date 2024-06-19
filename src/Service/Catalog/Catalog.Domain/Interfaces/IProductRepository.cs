using Catalog.Domain.Entities;

namespace Catalog.Domain.Interfaces
{
    public interface IProductRepository
    {

        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductAsync(Guid id);
        Task<Product> CreateProductAsync(Product product);
        Task<Product> UpdateProductAsync(Product product);
        Task<bool> DeleteProductAsync(Guid id);

    }
}
