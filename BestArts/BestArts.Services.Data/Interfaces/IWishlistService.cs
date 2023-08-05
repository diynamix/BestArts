namespace BestArts.Services.Data.Interfaces
{
    using Models.Product;
    using Web.ViewModels.Product;

    public interface IWishlistService
    {
        Task<bool> IsAlreadyAddedAsync(string userId, string productId);

        Task<AllProductsFilteredAndPagedServiceModel> AllAsync(AllProductsQueryModel queryModel, string userId);
    }
}
