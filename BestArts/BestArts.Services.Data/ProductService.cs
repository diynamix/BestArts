namespace BestArts.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    
    using Microsoft.EntityFrameworkCore;
    
    using BestArts.Data;
    using Interfaces;
    using Web.ViewModels.Product;
    using BestArts.Data.Models;

    public class ProductService : IProductService
    {
        private readonly BestArtsDbContext dbContext;

        public ProductService(BestArtsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task CreateAsync(ProductFormModel formModel)
        {
            Product product = new Product()
            {
                Name = formModel.Name,
                ImageUrl = formModel.ImageUrl,
                Width = formModel.Width,
                Height = formModel.Height,
                Price = formModel.Price,
                CategoryId = formModel.CategoryId,
            };

            await dbContext.Products.AddAsync(product);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProductAllViewModel>> GetAllAvailableProductsAsync()
        {
            IEnumerable<ProductAllViewModel> products = await dbContext
                .Products
                .Where(p => p.IsDeleted == false)
                .Select(p => new ProductAllViewModel
                {
                    Id = p.Id.ToString(),
                    Name = p.Name,
                    ImageUrl = p.ImageUrl,
                    CategoryName = p.Category.Name,
                    Width = p.Width,
                    Height = p.Height,
                    Price = p.Price,
                })
                .ToArrayAsync();

            return products;
        }
    }
}
