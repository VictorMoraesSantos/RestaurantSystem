using Catalog.Domain.Entities;

namespace Catalog.Domain.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<Category> GetByNameAsync(string name);
    }
}
