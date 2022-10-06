using BlazorEcommerce.Server.Services.CategoryService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICatgoryService _catgoryService;

        public CategoryController(ICatgoryService catgoryService)
        {
            _catgoryService = catgoryService;
        }

        [HttpGet]
        public async Task<ServiceResponse<List<Category>>> GetCategories()
        {
            var result = await _catgoryService.GetCategories();
            return result;
        }
    }
}
