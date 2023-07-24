namespace BestArts.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    
    using Microsoft.EntityFrameworkCore;
    
    using BestArts.Data;
    using Interfaces;
    using Web.ViewModels.Product;

    public class ProductService : IProductService
    {
        private readonly BestArtsDbContext dbContext;

        public ProductService(BestArtsDbContext dbContext)
        {
            this.dbContext = dbContext;
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
