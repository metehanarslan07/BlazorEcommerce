using BlazorEcommerce.Server.Services.CartService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpPost("products")]
        public async Task<ServiceResponse<List<CartProductResponse>>> GetCartProducts(List<CardItem> cardItems)
        {
            var result = await _cartService.GetCartProductAsync(cardItems);
            return result;
        }
    }
}
