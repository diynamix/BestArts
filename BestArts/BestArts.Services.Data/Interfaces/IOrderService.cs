namespace BestArts.Services.Data.Interfaces
{
    using Models.Order;
    using Web.ViewModels.Order;

    public interface IOrderService
    {
        Task<AllOrdersFilteredServiceModel> AllAsync(AllOrdersQueryModel queryModel);

        Task CreateOrderAsync(OrderFormModel formModel, IEnumerable<CartToOrderItemServiceModel> orderItems, string userId);

        Task<decimal> GetSubtotalPriceOfAllItemsForOrderAsync(string userId);

        Task<IEnumerable<CartToOrderItemServiceModel>> GetAllItemsForOrderAsync(string userId);

        Task<IEnumerable<OrderAllViewModel>> GetAllOrdersByUserIdAsync(string userId);

        //Task<IEnumerable<OrderSelectPaymentMethodFormModel>> GetAllPaymentMethodsAsync();

        Task<OrderDetailsViewModel> GetOrderDetailsByIdAsync(string orderId);

        Task<IEnumerable<AllOrderItemsViewModel>> GetOrderItemsByOrderIdAsync(string orderId);

        Task UpdateOrderStatusByIdAsync(string orderId, OrderStatusFormModel formModel);

        Task<bool> IsUserOwnerAsync(string userId, string orderId);

        Task<bool> OrderExistsByIdAsync(string orderId);

        Task<OrderStatusFormModel> GetOrderForUpdateByIdAsync(string orderId);
    }
}
