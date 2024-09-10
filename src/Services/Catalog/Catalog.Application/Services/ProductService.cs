using Catalog.Application.DTOs;
using Catalog.Application.Interfaces;
using Catalog.Application.Mappings;
using Catalog.Domain.Entities;
using Catalog.Domain.Repositories;

namespace Catalog.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ProductDTO> GetById(Guid id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            var productDTO = ProductMapper.DomainToDto(product);
            return productDTO;
        }

        public async Task<ProductDTO> GetProductByName(string productName)
        {
            var product = await _productRepository.GetProductByName(productName);
            var productDTO = ProductMapper.DomainToDto(product);
            return productDTO;
        }

        public async Task<IEnumerable<ProductDTO>> GetProductByCategory(CategoryDTO category)
        {
            var products = await _productRepository.GetProductsByCategory(category);
            var productsDTO = ProductMapper.DomainToDto(products);
        }

        public Task<IEnumerable<ProductDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ProductDTO> Create(ProductDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDTO> Update(ProductDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
