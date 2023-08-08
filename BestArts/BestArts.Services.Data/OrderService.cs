namespace BestArts.Services.Data
{
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    
    using BestArts.Data;
    using BestArts.Data.Models;
    using BestArts.Data.Models.Enums;
    using Interfaces;
    using Models.Order;
    using System.Collections.Generic;
    using Web.ViewModels.Order;

    using static Common.GeneralApplicationConstants;

    public class OrderService : IOrderService
    {
        private readonly BestArtsDbContext dbContext;

        public OrderService(BestArtsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task CreateOrderAsync(OrderFormModel formModel, IEnumerable<CartToOrderItemServiceModel> orderItems, string userId)
        {
            Order order = new Order();

            foreach (var item in orderItems)
            {
                OrderItem orderItem = new OrderItem()
                {
                    OrderId = order.Id,
                    ProductId = Guid.Parse(item.ProductId),
                    Quantity = item.Quantity,
                    SinglePrice = item.Price,
                    TotalPrice = item.Price * item.Quantity,
                };

                //await dbContext.OrderItems.AddAsync(orderItem);
                order.OrderItems.Add(orderItem);
            }

            decimal subtotalPrice = order.OrderItems.Select(oi => oi.TotalPrice).Sum();

            order.UserId = Guid.Parse(userId);
            order.OrderStatus = OrderStatusType.InProgress;
            order.CreatedOn = DateTime.Now;
            order.ShippingAddress = formModel.CustomerName + Environment.NewLine + formModel.ShippingAddress;
            order.ShippingPrice = formModel.ShippingPrice;
            order.SubTotalPrice = subtotalPrice;
            order.VAT = subtotalPrice * (vatPercentage / 100);
            order.GrandTotalPrice = order.ShippingPrice + order.SubTotalPrice + order.VAT;

            await dbContext.Orders.AddAsync(order);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<CartToOrderItemServiceModel>> GetAllItemsForOrderAsync(string userId)
        {
            IEnumerable<CartToOrderItemServiceModel> orderItems = await dbContext.Carts
                .Include(c => c.Product)
                .Where(c => c.Product.IsDeleted == false &&
                            c.UserId.ToString() == userId)
                .AsNoTracking()
                .Select(c => new CartToOrderItemServiceModel
                {
                    ProductId = c.ProductId.ToString(),
                    Price = c.Product.Price,
                    Quantity = c.Quantity,
                })
                .ToListAsync();

            return orderItems;
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
