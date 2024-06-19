using Catalog.Domain.Interfaces;
using Catalog.Domain.Entities;
using Catalog.Infrasctructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Infrasctructure.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAllCategories(Category category)
        {
            var categories = await _context.Categories.AsNoTracking().ToListAsync();

            return categories;
        }

        public async Task<Category> GetCategory(Guid id)
        {
            var category = await _context.Categories.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
            return category!;
        }

        public async Task<Category> CreateCategory(Category category)
        {

            await _context.AddAsync(category);
            await _context.SaveChangesAsync();
            return category;

        }

        public async Task<Category> UpdateCategory(Category category)
        {
            _context.Update(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<bool> DeleteCategory(Guid id)
        {
            _context.Remove(id);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
