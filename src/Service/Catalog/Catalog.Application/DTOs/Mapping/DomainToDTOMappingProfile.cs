using AutoMapper;
using Catalog.Application.Dtos;
using Catalog.Domain.Entities;

namespace Catalog.Application.DTOs.Mapping
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}
