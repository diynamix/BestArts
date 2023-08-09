namespace BestArts.Services.Data
{
    using System.Collections.Generic;

    using Microsoft.EntityFrameworkCore;

    using BestArts.Data;
    using BestArts.Data.Models;
    using Interfaces;
    using Models.Product;
    using Web.ViewModels.Product;
    using Web.ViewModels.Product.Enums;

    public class WishlistService : IWishlistService
    {
        private readonly BestArtsDbContext dbContext;

        public WishlistService(BestArtsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<AllProductsFilteredAndPagedServiceModel> AllAsync(AllProductsQueryModel queryModel, string userId)
        {
            IQueryable<Product> productsQuery = dbContext.Wishlists
                .Where(w => w.UserId.ToString() == userId)
                .Select(w => w.Product)
                .Where(p => p.IsDeleted == false)
                .AsQueryable();

            if (!string.IsNullOrEmpty(queryModel.CategorySort))
            {
                productsQuery = productsQuery
                    .Where(p => p.Category.Name == queryModel.CategorySort);
            }

            if (!string.IsNullOrEmpty(queryModel.SearchString))
            {
                string wildCard = $"%{queryModel.SearchString}%";

                productsQuery = productsQuery
                    .Where(p => EF.Functions.Like(p.Name, wildCard) ||
                                EF.Functions.Like(p.Category.Name, wildCard));
            }

            productsQuery = queryModel.ProductSorting switch
            {
                ProductSorting.Newest => productsQuery.OrderByDescending(p => p.CreatedOn),
                ProductSorting.Oldect => productsQuery.OrderBy(p => p.CreatedOn),
                ProductSorting.PriceAscending => productsQuery.OrderBy(p => p.Price),
                ProductSorting.PriceDescending => productsQuery.OrderByDescending(p => p.Price),
                _ => productsQuery.OrderBy(p => p.IsDeleted == false)
            };

            IEnumerable<ProductAllViewModel> allProducts = await productsQuery
                .Skip((queryModel.CurrentPage - 1) * queryModel.ProductsPerPage)
                .Take(queryModel.ProductsPerPage)
                .Select(p => new ProductAllViewModel()
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

            int totalProducts = productsQuery.Count();

            return new AllProductsFilteredAndPagedServiceModel()
            {
                TotalProductsCount = totalProducts,
                Products = allProducts,
            };
        }

        public async Task<bool> IsAlreadyAddedAsync(string userId, string productId)
        {
            bool alreadyAdded = await dbContext.Wishlists
                .AnyAsync(w => w.UserId.ToString() == userId &&
                            w.ProductId.ToString() == productId);

            return alreadyAdded;
        }
    }
}
