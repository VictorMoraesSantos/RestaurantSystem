using Catalog.Application.DTOs;
using Catalog.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("{id:guid}", Name = "GetCategoryById")]
        public async Task<ActionResult<CategoryDTO>> GetCategoryById(Guid id)
        {
            var category = await _categoryService.GetById(id);
            if (category == null)
                return NotFound();

            return Ok(category);
        }

        [HttpGet("byname/{name}", Name = "GetCategoryByName")]
        public async Task<ActionResult<CategoryDTO>> GetCategoryByName(string name)
        {
            var category = await _categoryService.GetByName(name);
            if (category == null)
                return NotFound();

            return Ok(category);
        }

        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<CategoryDTO>>> GetCategories()
        {
            var categories = await _categoryService.GetAll();
            return Ok(categories);
        }

        [HttpPost(Name = "CreateCategory")]
        public async Task<ActionResult<CategoryDTO>> CreateCategory(CategoryDTO category)
        {
            var createdCategory = await _categoryService.Create(category);
            return CreatedAtRoute("GetCategoryById", new { id = createdCategory.Id }, createdCategory);
        }

        [HttpPut("{id:guid}", Name = "UpdateCategory")]
        public async Task<ActionResult> UpdateCategory(Guid id, CategoryDTO category)
        {
            if (id != category.Id)
                return BadRequest("Category ID mismatch");

            var existingCategory = await _categoryService.GetById(id);
            if (existingCategory == null)
                return NotFound();

            await _categoryService.Update(category);
            return NoContent();
        }

        [HttpDelete("{id:guid}", Name = "DeleteCategory")]
        public async Task<IActionResult> DeleteCategory(Guid id)
        {
            var category = await _categoryService.GetById(id);
            if (category == null)
                return NotFound();

            var result = await _categoryService.Delete(category);
            if (!result)
                return StatusCode(500, "Error deleting the category");

            return NoContent();
        }
    }
}
