namespace BestArts.Services.Data.Interfaces
{
    using Web.ViewModels.Product;

    public interface IProductService
    {
        Task<IEnumerable<ProductAllViewModel>> GetAllAvailableProductsAsync();

        Task CreateAsync(ProductFormModel formModel);
    }
}
