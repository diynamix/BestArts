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

    public class ProductService : IProductService
    {
        private readonly BestArtsDbContext dbContext;

        public ProductService(BestArtsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddProductToWishlistAsync(string userId, string productId)
        {
            Wishlist wishlist = new Wishlist()
            {
                UserId = Guid.Parse(userId),
                ProductId = Guid.Parse(productId)
            };

            await dbContext.Wishlists.AddAsync(wishlist);
            await dbContext.SaveChangesAsync();
        }

        public async Task<AllProductsFilteredAndPagedServiceModel> AllAsync(AllProductsQueryModel queryModel)
        {
            IQueryable<Product> productsQuery = dbContext.Products
                .Where(p => p.IsDeleted == false)
                .AsQueryable();

            if (!string.IsNullOrEmpty(queryModel.Category))
            {
                productsQuery = productsQuery
                    .Where(p => p.Category.Name == queryModel.Category);
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
                //.Where(p => p.IsDeleted == false)
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

            if (!allProducts.Any())
            {
                queryModel.CurrentPage = queryModel.CurrentPage == 1 ? queryModel.CurrentPage : queryModel.CurrentPage - 1;

                allProducts = await productsQuery
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
            }

            int totalProducts = productsQuery.Count();

            return new AllProductsFilteredAndPagedServiceModel()
            {
                TotalProductsCount = totalProducts,
                Products = allProducts,
            };
        }

        public async Task<string> CreateAsync(ProductFormModel formModel)
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

            return product.Id.ToString();
        }

        public async Task DeleteProductByIdAsync(string productId)
        {
            Product product = await dbContext.Products
                .Where(p => p.IsDeleted == false)
                .FirstAsync(p => p.Id.ToString() == productId);

            product.IsDeleted = true;
            product.DeletedOn = DateTime.Now;

            await dbContext.SaveChangesAsync();
        }

        public async Task EditProductByIdAsync(string productId, ProductFormModel formModel)
        {
            Product product = await dbContext.Products
                .Where(p => p.IsDeleted == false)
                .FirstAsync(p => p.Id.ToString() == productId);

            product.Name = formModel.Name;
            product.ImageUrl = formModel.ImageUrl;
            product.Width = formModel.Width;
            product.Height = formModel.Height;
            product.Price = formModel.Price;
            product.CategoryId = formModel.CategoryId;

            await dbContext.SaveChangesAsync();
        }

        public async Task<bool> ExistsByIdAsync(string productId)
        {
            bool result = await dbContext.Products
                .Where(p => p.IsDeleted == false)
                .AnyAsync(p => p.Id.ToString() == productId);

            return result;
        }

        public async Task<ProductDetailsViewModel> GetDetailsByIdAsync(string productId)
        {
            Product product = await dbContext.Products
                .Include(p => p.Category)
                .Where(p => p.IsDeleted == false)
                .FirstAsync(p => p.Id.ToString() == productId);

            return new ProductDetailsViewModel()
            {
                Id = product.Id.ToString(),
                Name = product.Name,
                ImageUrl = product.ImageUrl,
                CategoryName = product.Category.Name,
                Width = product.Width,
                Height = product.Height,
                Price = product.Price,
            };
        }

        public async Task<ProductFormModel> GetProductForEditByIdAsync(string productId)
        {
            Product product = await dbContext.Products
                .Include(p => p.Category)
                .Where(p => p.IsDeleted == false)
                .FirstAsync(p => p.Id.ToString() == productId);

            return new ProductFormModel()
            {
                Name = product.Name,
                ImageUrl = product.ImageUrl,
                CategoryId = product.Category.Id,
                Width = product.Width,
                Height = product.Height,
                Price = product.Price,
            };
        }

        public async Task<ProductSoftDeleteViewModel> GetProductForSoftDeleteByIdAsync(string productId)
        {
            Product product = await dbContext.Products
               .Include(p => p.Category)
               .Where(p => p.IsDeleted == false)
               .FirstAsync(p => p.Id.ToString() == productId);

            return new ProductSoftDeleteViewModel()
            {
                Id = product.Id.ToString(),
                Name = product.Name,
                ImageUrl = product.ImageUrl,
                CategoryName = product.Category.Name,
            };
        }

        public async Task RemoveProductFromWishlistAsync(string userId, string productId)
        {
            Wishlist? wishlist = await dbContext.Wishlists
                .FirstOrDefaultAsync(w => w.UserId.ToString() == userId &&
                            w.ProductId.ToString() == productId);

            if (wishlist != null)
            {
                dbContext.Wishlists.Remove(wishlist);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
