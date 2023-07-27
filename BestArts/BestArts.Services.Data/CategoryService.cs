namespace BestArts.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    
    using BestArts.Data;
    using Interfaces;
    using Web.ViewModels.Category;

    public class CategoryService : ICategoryService
    {
        private readonly BestArtsDbContext dbContext;

        public CategoryService(BestArtsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<ProductSelectCategoryFormModel>> AllCategoriesAsync()
        {
            IEnumerable<ProductSelectCategoryFormModel> allCategories = await dbContext.Categories
                .AsNoTracking()
                .Select(c => new ProductSelectCategoryFormModel
                {
                    Id = c.Id,
                    Name = c.Name,
                })
                .ToArrayAsync();

            return allCategories;
        }

        public async Task<bool> ExistsByIdAsync(int id)
        {
            bool exists = await dbContext.Categories
                .AnyAsync(c => c.Id == id);

            return exists;
        }
    }
}
