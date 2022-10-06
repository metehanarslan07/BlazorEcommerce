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

        [HttpGet("search/{searchText}/{page}")]
        public async Task<ServiceResponse<ProductSarchResult>> SarchProducts(string searchText, int page = 1)
        {
            var result = await _productService.SearchProducts(searchText, page);
            return result;
        }

        [HttpGet("searchSuggestions/{searchText}")]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProductSearchSuggestions(string searchText)
        {
            var result = await _productService.GetProductSaerchSuggestions(searchText);
            return Ok(result);
        }

        [HttpGet("featured")]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetFeaturedProduct()
        {
            var result = await _productService.GetFeaturedProducts();
            return Ok(result);
        }

    }
}
