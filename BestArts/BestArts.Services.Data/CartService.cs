namespace BestArts.Services.Data
{
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;

    using BestArts.Data;
    using BestArts.Data.Models;
    using Interfaces;
    using Web.ViewModels.Cart;

    public class CartService : ICartService
    {
        private readonly BestArtsDbContext dbContext;

        public CartService(BestArtsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddProductToCartAsync(string userId, string productId)
        {
            Cart cart = new Cart()
            {
                UserId = Guid.Parse(userId),
                ProductId = Guid.Parse(productId),
                Quantity = 1,
            };

            await dbContext.Carts.AddAsync(cart);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<AllCartsViewModel>> AllCartsAsync(string userId)
        {
            IEnumerable<AllCartsViewModel> allCarts = await dbContext.Carts
                .Include(c => c.Product)
                .Where(c => c.Product.IsDeleted == false &&
                            c.UserId.ToString() == userId)
                .AsNoTracking()
                .Select(c => new AllCartsViewModel
                {
                    ProductId = c.ProductId.ToString(),
                    Name = c.Product.Name,
                    ImageUrl = c.Product.ImageUrl,
                    Width = c.Product.Width,
                    Height = c.Product.Height,
                    Price = c.Product.Price,
                    Quantity = c.Quantity,
                })
                .ToArrayAsync();

            return allCarts;
        }

        public async Task<DeleteCartProductViewModel> GetProductForDeletingFromCartAsync(string userId, string productId)
        {
            Cart cart = await dbContext.Carts
                .Include(c => c.Product)
                .Where(c => c.Product.IsDeleted == false)
                .FirstAsync(c => c.UserId.ToString() == userId &&
                                c.ProductId.ToString() == productId);

            return new DeleteCartProductViewModel()
            {
                Id = cart.Product.Id.ToString(),
                Name = cart.Product.Name,
                ImageUrl = cart.Product.ImageUrl,
                Width = cart.Product.Width,
                Height = cart.Product.Height,
            };
        }

        public async Task<bool> IsAlreadyAddedAsync(string userId, string productId)
        {
            bool alreadyAdded = await dbContext.Carts
                .AnyAsync(w => w.UserId.ToString() == userId &&
                            w.ProductId.ToString() == productId);

            return alreadyAdded;
        }

        public async Task RemoveProductFromCartAsync(string userId, string productId)
        {
            Cart? cart = await dbContext.Carts
                .FirstOrDefaultAsync(w => w.UserId.ToString() == userId &&
                            w.ProductId.ToString() == productId);

            if (cart != null)
            {
                dbContext.Carts.Remove(cart);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task UpdateProductQuantityAsync(string userId, string productId, AllCartsViewModel model)
        {
            Cart? cart = await dbContext.Carts
                .FirstOrDefaultAsync(c => c.ProductId.ToString() == productId &&
                            c.UserId.ToString() == userId);

            if (cart != null)
            {
                cart.Quantity = model.Quantity;
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
