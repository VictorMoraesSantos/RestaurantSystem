using AutoMapper;
using Catalog.Application.Dtos;
using Catalog.Domain.Models;

namespace Catalog.Application.DTOs.Mapping
{
    public class CategoryDTOMappingProfile : Profile
    {
        public CategoryDTOMappingProfile()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}
