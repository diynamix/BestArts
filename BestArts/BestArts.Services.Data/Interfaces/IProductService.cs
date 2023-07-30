namespace BestArts.Services.Data.Interfaces
{
    using Models.Product;
    using Web.ViewModels.Product;

    public interface IProductService
    {
        Task<AllProductsFilteredAndPagedServiceModel> AllAsync(AllProductsQueryModel queryModel);

        Task CreateAsync(ProductFormModel formModel);

        Task<ProductDetailsViewModel> GetDetailsByIdAsync(string productId);

        Task<bool> ExistsByIdAsync(string productId);

        Task<ProductFormModel> GetProductForEditByIdAsync(string productId);

        Task EditProductByIdAsync(string productId, ProductFormModel formModel);
    }
}
