using Catalog.Application.DTOs;
using Catalog.Domain.Entities;

namespace Catalog.Application.Mappings
{
    public static class CategoryMapper
    {
        public static CategoryDTO DomainToDto(Category category)
        {
            return new CategoryDTO(category.Id, category.Name, category.Description);
        }

        public static Category DtoToDomain(CategoryDTO categoryDTO)
        {
            return new Category(categoryDTO.Id, categoryDTO.Name, categoryDTO.Description);
        }

        public static IEnumerable<CategoryDTO> DomainToDto(IEnumerable<Category> categories)
        {
            return categories.Select(category => DomainToDto(category)).ToList();
        }

        public static IEnumerable<Category> DtoToDomain(IEnumerable<CategoryDTO> categoryDTOs)
        {
            return categoryDTOs.Select(categoryDTO => DtoToDomain(categoryDTO)).ToList();
        }
    }
}
