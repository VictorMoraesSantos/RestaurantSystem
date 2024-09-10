using Catalog.Domain.Entities;

namespace Catalog.Application.Interfaces
{
    public interface IGenericService<T> where T : class
    {
        Task<T> GetById(Guid id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task<bool> Delete(T entity);
    }
}
