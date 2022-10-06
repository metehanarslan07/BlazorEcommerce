namespace BlazorEcommerce.Server.Services.CategoryService
{
    public interface ICatgoryService
    {
        Task<ServiceResponse<List<Category>>> GetCategories();
    }
}
