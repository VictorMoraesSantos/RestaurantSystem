using Catalog.Application.DTOs;

namespace Catalog.Application.Interfaces
{
    public interface ICategoryService : IGenericService<CategoryDTO>
    {
        Task<CategoryDTO> GetByName(string name);
    }
}
