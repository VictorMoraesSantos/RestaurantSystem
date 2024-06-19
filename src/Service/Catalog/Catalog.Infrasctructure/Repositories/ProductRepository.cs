using Catalog.Domain.Interfaces;
using Catalog.Domain.Entities;
using Catalog.Infrasctructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Infrasctructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

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

        public async Task<Product> GetProductAsync(Guid Id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == Id);
            return product!;
        }

        public async Task<Product> CreateProductAsync(Product product)
        {
            _context.AddAsync(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
            _context.Update(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<bool> DeleteProductAsync(Guid Id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == Id);
            if (product is not null)
            {
                _context.Remove(product);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
