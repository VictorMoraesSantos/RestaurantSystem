using Catalog.Domain.Entities;
using Catalog.Domain.Repositories;
using Catalog.Infra.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Infra.Data.Repositories
{
    class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Category> GetByIdAsync(Guid id)
        {
            return await _context.Categories.AsNoTracking()
                                            .FirstAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _context.Categories.AsNoTracking()
                                            .ToListAsync();
        }

        public async Task<Category> CreateAsync(Category entity)
        {
            await _context.Categories.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Category> UpdateAsync(Category entity)
        {
            _context.Categories.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteAsync(Category entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
