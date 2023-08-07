namespace BestArts.Services.Data.Interfaces
{
    public interface IOrderService
    {
        Task CreateOrderAsync();

        Task<decimal> GetSubtotalPriceOfAllItemsForOrderAsync(string userId);
    }
}
