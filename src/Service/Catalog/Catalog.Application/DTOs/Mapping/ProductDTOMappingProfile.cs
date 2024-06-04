using AutoMapper;
using Catalog.Application.Dtos;
using Catalog.Domain.Models;

namespace Catalog.Application.DTOs.Mapping
{
    public class ProductDTOMappingProfile : Profile
    {
        public ProductDTOMappingProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}
