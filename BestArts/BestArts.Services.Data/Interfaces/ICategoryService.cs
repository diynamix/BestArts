namespace BestArts.Services.Data.Interfaces
{
    using BestArts.Web.ViewModels.Product;
    using Web.ViewModels.Category;

    public interface ICategoryService
    {
        Task<IEnumerable<AllCategoriesViewModel>> AllCategoriesAsync();

        Task<IEnumerable<ProductSelectCategoryFormModel>> AllCategoriesForProductSelectFormModelAsync();

        Task CreateAsync(CategoryFormModel formModel);

        Task<bool> ExistsByIdAsync(int id);

        Task<bool> ExistsByNameAsync(string name);

        Task<IEnumerable<string>> AllCategoryNamesAsync();

        Task<CategoryFormModel> GetCategoryForEditByIdAsync(string categoryId);

        Task EditCategoryByIdAsync(string categoryId, CategoryFormModel formModel);
    }
}
