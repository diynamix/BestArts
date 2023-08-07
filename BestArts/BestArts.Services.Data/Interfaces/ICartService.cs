namespace BestArts.Services.Data.Interfaces
{
    using BestArts.Web.ViewModels.Product;
    using Web.ViewModels.Cart;

    public interface ICartService
    {
        Task<IEnumerable<AllCartsViewModel>> AllCartsAsync(string userid);

        Task<bool> IsAlreadyAddedAsync(string userId, string productId);

        Task AddProductToCartAsync(string userId, string productId);

        Task UpdateProductQuantityAsync(string userId, string productId, AllCartsViewModel model);

        Task RemoveProductFromCartAsync(string userId, string productId);

        Task<DeleteCartProductViewModel> GetProductForDeletingFromCartAsync(string userId, string productId);
    }
}
