using BlazorEcommerce.Server.Services.ProductService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Server.Controllers
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

        [HttpGet]
        public async Task<ServiceResponse<List<Product>>> GetProduct()
        {
            var result = await _productService.GetProductsAsync();
            return result;
        }

        [HttpGet("{productId}")]
        public async Task<ServiceResponse<Product>> GetProduc(int productId)
        {
            var result = await _productService.GetProductAsync(productId);
            return result;
        }

        [HttpGet("category/{categoryUrl}")]
        public async Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl)
        {
            var result = await _productService.GetProductsByCategory(categoryUrl);
            return result;
        }

    }
}
