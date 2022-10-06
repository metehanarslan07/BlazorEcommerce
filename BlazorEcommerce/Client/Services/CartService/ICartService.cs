using BlazorEcommerce.Shared;

namespace BlazorEcommerce.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(CardItem cardItem);
        Task<List<CardItem>> GetCardItems();

        Task<List<CartProductResponse>> GetCartProducts();

        Task RemoveProductFromCart(int productId, int productTypeId);
        Task UpdateQuantity(CartProductResponse product);
    }
}
