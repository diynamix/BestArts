namespace BestArts.Services.Data
{
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    
    using BestArts.Data;
    using Interfaces;

    public class OrderService : IOrderService
    {
        private readonly BestArtsDbContext dbContext;

        public OrderService(BestArtsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task CreateOrderAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<decimal> GetSubtotalPriceOfAllItemsForOrderAsync(string userId)
        {
            var subtotal = await dbContext.Carts
                .Include(c => c.Product)
                .Where(c => c.Product.IsDeleted == false &&
                            c.UserId.ToString() == userId)
                .AsNoTracking()
                .Select(c => c.Product.Price * c.Quantity)
                .SumAsync();

            return subtotal;
        }
    }
}
