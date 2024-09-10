using Catalog.Application.DTOs;
using Catalog.Application.Interfaces;
using Catalog.Application.Mappings;
using Catalog.Domain.Entities;
using Catalog.Domain.Repositories;

namespace Catalog.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<CategoryDTO> GetById(Guid id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            var categoryDTO = CategoryMapper.DomainToDto(category);
            return categoryDTO;
        }

        public async Task<IEnumerable<CategoryDTO>> GetAll()
        {
            var categories = await _categoryRepository.GetAllAsync();
            var categoriesDTO = CategoryMapper.DomainToDto(categories);
            return categoriesDTO;
        }

        public async Task<CategoryDTO> Create(CategoryDTO entity)
        {
            var category = CategoryMapper.DtoToDomain(entity);
            await _categoryRepository.CreateAsync(category);
            return entity;
        }

        public async Task<CategoryDTO> Update(CategoryDTO entity)
        {
            var category = CategoryMapper.DtoToDomain(entity);
            await _categoryRepository.UpdateAsync(category);
            return entity;
        }

        public Task<bool> Delete(CategoryDTO entity)
        {
            var category = CategoryMapper.DtoToDomain(entity);
            return _categoryRepository.DeleteAsync(category);
        }
    }
}
