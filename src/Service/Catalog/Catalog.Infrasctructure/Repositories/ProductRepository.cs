using Catalog.Domain.Models;
using Catalog.Infrasctructure.Data;
using Catalog.Infrasctructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Infrasctructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext? _context;

        public ProductRepository(ApplicationDbContext? context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetProductsByCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            var products = await _context!.Products.AsNoTracking().ToListAsync();
            return products;
        }

        public Task<Product> GetProductAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> PostProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProductAsync(Guid Id)
        {
            throw new NotImplementedException();
        }


    }
}
