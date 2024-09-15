using Catalog.Application.DTOs;
using Catalog.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ProductDTO>> GetProduct(Guid id)
        {
            var product = await _productService.GetById(id);
            if (product is null)
                return NotFound();

            return Ok(product);
        }

        [HttpGet("byname/{name}")]
        public async Task<IActionResult> GetProductByName(string name)
        {
            var product = await _productService.GetProductByName(name);
            if (product == null)
                return NotFound($"Product with name '{name}' not found.");

            return Ok(product);
        }

        [HttpGet("category/{categoryId:guid}")]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetProductByCategory(Guid categoryId)
        {
            var products = await _productService.GetProductsByCategory(categoryId);
            return Ok(products);
        }

        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetProducts()
        {
            var products = await _productService.GetAll();
            return Ok(products);
        }

        [HttpPost]
        public async Task<ActionResult<ProductDTO>> CreateProduct(ProductDTO product)
        {
            if (product is null)
                return BadRequest();

            var newProduct = await _productService.Create(product);
            return CreatedAtAction(nameof(GetProduct), new { id = newProduct.Id }, newProduct);
        }

        [HttpPut]
        public async Task<ActionResult<ProductDTO>> UpdateProduct(ProductDTO product)
        {
            if (product is null)
                return BadRequest();

            var updatedProduct = await _productService.Update(product);
            return Ok(updatedProduct);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<bool>> DeleteProduct(Guid id)
        {
            var product = await _productService.GetById(id);
            if (product is null)
                return NotFound();

            var result = await _productService.Delete(product);
            return Ok(result);
        }
    }
}
