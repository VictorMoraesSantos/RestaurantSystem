using Catalog.Domain.Entities;

namespace Catalog.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategories(Category category);
        Task<Category> GetCategory(Guid id);
        Task<Category> CreateCategory(Category category);
        Task<Category> UpdateCategory(Category category);
        Task<bool> DeleteCategory(Guid id);
    }
}
