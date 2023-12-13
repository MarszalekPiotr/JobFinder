using JobFinder.Application.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace JobFinder.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {   ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("Categories")]
        public async Task<IActionResult> GetCategories() =>  Ok(await _categoryService.GetCategoriesAsync());

        [HttpPost("AddCategory")]
        public async Task<IActionResult> AddCategory(AddCategoryDTO addCategoryDTO)
        {
            await _categoryService.AddCategory(addCategoryDTO);
            return Ok();
        } 
    }
}
