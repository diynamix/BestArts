namespace BestArts.Services.Data
{
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;

    using BestArts.Data;
    using Interfaces;

    public class WishlistService : IWishlistService
    {
        private readonly BestArtsDbContext dbContext;

        public WishlistService(BestArtsDbContext dbContext)
        {
            this.dbContext = dbContext;
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
