using Catalog.Domain.Entities;
using Catalog.Domain.Repositories;
using Catalog.Infra.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Product> GetByIdAsync(Guid id)
        {
            return await _context.Products.AsNoTracking()
                                          .FirstAsync(p => p.Id == id);
        }

        public async Task<Product> GetProductByName(string productName)
        {
            return await _context.Products.AsNoTracking()
                                          .FirstAsync(p => p.Name == productName);
        }

        public async Task<IEnumerable<Product>> GetProductsByCategory(Category category)
        {
            return await _context.Products.AsNoTracking()
                                          .Where(p => p.Category == category)
                                          .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products.AsNoTracking()
                                          .ToListAsync();
        }

        public async Task<Product> CreateAsync(Product entity)
        {
            await _context.Products.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Product> UpdateAsync(Product entity)
        {
            _context.Products.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteAsync(Product product)
        {
            _context.Remove(product);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
