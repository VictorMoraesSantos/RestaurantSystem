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

        public async Task<IEnumerable<ProductDTO>> GetProductsByCategory(Guid categoryId)
        {
            var products = await _productRepository.GetProductsByCategory(categoryId);
            var productsDTO = ProductMapper.DomainToDto(products);
            return productsDTO;
        }

        public async Task<IEnumerable<ProductDTO>> GetAll()
        {
            var products = await _productRepository.GetAllAsync();
            var productsDTO = ProductMapper.DomainToDto(products);
            return productsDTO;
        }

        public async Task<ProductDTO> Create(ProductDTO entity)
        {
            var product = ProductMapper.DtoToDomain(entity);
            await _productRepository.CreateAsync(product);
            return entity;
        }

        public async Task<ProductDTO> Update(ProductDTO entity)
        {
            var product = ProductMapper.DtoToDomain(entity);
            await _productRepository.UpdateAsync(product);
            return entity;
        }

        public Task<bool> Delete(ProductDTO entity)
        {
            var product = ProductMapper.DtoToDomain(entity);
            return _productRepository.DeleteAsync(product);
        }
    }
}
