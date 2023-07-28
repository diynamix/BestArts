namespace BestArts.Services.Data.Interfaces
{
    using Models.Product;
    using Web.ViewModels.Product;

    public interface IProductService
    {
        Task<AllProductsFilteredAndPagedServiceModel> AllAsync(AllProductsQueryModel queryModel);

        Task CreateAsync(ProductFormModel formModel);
    }
}
