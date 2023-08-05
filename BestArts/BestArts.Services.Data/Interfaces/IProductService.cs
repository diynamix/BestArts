namespace BestArts.Services.Data.Interfaces
{
    using Models.Product;
    using Web.ViewModels.Product;

    public interface IProductService
    {
        Task<AllProductsFilteredAndPagedServiceModel> AllAsync(AllProductsQueryModel queryModel);

        Task<string> CreateAsync(ProductFormModel formModel);

        Task<ProductDetailsViewModel> GetDetailsByIdAsync(string productId);

        Task<bool> ExistsByIdAsync(string productId);

        Task<ProductFormModel> GetProductForEditByIdAsync(string productId);

        Task EditProductByIdAsync(string productId, ProductFormModel formModel);

        Task<ProductSoftDeleteViewModel> GetProductForSoftDeleteByIdAsync(string productId);

        Task DeleteProductByIdAsync(string productId);

        Task AddProductToWishlistAsync(string userId, string productId);
    }
}
