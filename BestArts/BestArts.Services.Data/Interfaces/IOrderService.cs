namespace BestArts.Services.Data.Interfaces
{
    using BestArts.Web.ViewModels.Order;
    using Models.Order;

    public interface IOrderService
    {
        Task CreateOrderAsync(OrderFormModel formModel, IEnumerable<CartToOrderItemServiceModel> orderItems, string userId);

        Task<decimal> GetSubtotalPriceOfAllItemsForOrderAsync(string userId);

        Task<IEnumerable<CartToOrderItemServiceModel>> GetAllItemsForOrderAsync(string userId);
    }
}
