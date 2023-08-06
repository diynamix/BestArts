namespace BestArts.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    
    using BestArts.Data;
    using Interfaces;
    using Web.ViewModels.Category;
    using BestArts.Data.Models;

    public class CategoryService : ICategoryService
    {
        private readonly BestArtsDbContext dbContext;

        public CategoryService(BestArtsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<AllCategoriesViewModel>> AllCategoriesAsync()
        {
            IEnumerable<AllCategoriesViewModel> allCategories = await dbContext.Categories
                .AsNoTracking()
                .Select(c => new AllCategoriesViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                })
                .ToArrayAsync();

            return allCategories;
        }

        public async Task<IEnumerable<ProductSelectCategoryFormModel>> AllCategoriesForProductSelectFormModelAsync()
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

        public async Task<IEnumerable<string>> AllCategoryNamesAsync()
        {
            IEnumerable<string> allNames = await dbContext.Categories
                .Select(c => c.Name)
                .ToArrayAsync();

            return allNames;
        }

        public async Task CreateAsync(CategoryFormModel formModel)
        {
            Category category = new Category()
            {
                Name = formModel.Name,
            };

            await dbContext.Categories.AddAsync(category);
            await dbContext.SaveChangesAsync();
        }

        public async Task EditCategoryByIdAsync(string categoryId, CategoryFormModel formModel)
        {
            Category category = await dbContext.Categories
                .FirstAsync(p => p.Id == int.Parse(categoryId));

            category.Name = formModel.Name;

            await dbContext.SaveChangesAsync();
        }

        public async Task<bool> ExistsByIdAsync(int id)
        {
            bool exists = await dbContext.Categories
                .AnyAsync(c => c.Id == id);

            return exists;
        }

        public async Task<bool> ExistsByNameAsync(string name)
        {
            bool exists = await dbContext.Categories
                .AnyAsync(c => c.Name == name);

            return exists;
        }

        public async Task<CategoryFormModel> GetCategoryForEditByIdAsync(string categoryId)
        {
            Category product = await dbContext.Categories
                .FirstAsync(c => c.Id.ToString() == categoryId);

            return new CategoryFormModel()
            {
                Name = product.Name,
            };
        }
    }
}
