﻿using Catalog.Application.DTOs;
using Catalog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Mappings
{
    public static class ProductMapper
    {
        public static ProductDTO DomainToDto(Product product)
        {
            return new ProductDTO(
                product.Id,
                product.Name,
                product.Description,
                product.Price,
                product.CategoryId,
                product.Quantity,
                product.Status,
                product.ImageFile
            );
        }

        public static Product DtoToDomain(ProductDTO productDTO)
        {
            return new Product(
                productDTO.Id,
                productDTO.Name,
                productDTO.Description,
                productDTO.Price,
                productDTO.CategoryId,
                productDTO.Quantity,
                productDTO.Status,
                productDTO.ImageFile
            );
        }

        public static IEnumerable<ProductDTO> DomainToDto(IEnumerable<Product> products)
        {
            return products.Select(product => DomainToDto(product)).ToList();
        }

        public static IEnumerable<Product> DtoToDomain(IEnumerable<ProductDTO> productDTOs)
        {
            return productDTOs.Select(productDTO => DtoToDomain(productDTO)).ToList();
        }
    }
}
