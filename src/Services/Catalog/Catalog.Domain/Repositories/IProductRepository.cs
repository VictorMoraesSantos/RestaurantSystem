using Catalog.Domain.Entities;

namespace Catalog.Domain.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> GetProductByName(string productName);
        Task<IEnumerable<Product>> GetProductsByCategory(Category category);
    }
}
