namespace BestArts.Services.Data
{
    using System.Collections.Generic;

    using Microsoft.EntityFrameworkCore;

    using BestArts.Data;
    using BestArts.Data.Models;
    using BestArts.Data.Models.Enums;
    using Interfaces;
    using Models.Order;
    using Web.ViewModels.Order;
    using Web.ViewModels.Order.Enums;

    using static Common.GeneralApplicationConstants;

    public class OrderService : IOrderService
    {
        private readonly BestArtsDbContext dbContext;

        public OrderService(BestArtsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<AllOrdersFilteredServiceModel> AllAsync(AllOrdersQueryModel queryModel)
        {
            IQueryable<Order> ordersQuery = dbContext.Orders
                .AsQueryable();

            if (queryModel.OrderStatus > -1)
            {
                ordersQuery = ordersQuery
                        .Where(o => o.OrderStatus == (OrderStatusType)queryModel.OrderStatus);
            }

            ordersQuery = queryModel.OrderSorting switch
            {
                OrderSorting.Newest => ordersQuery.OrderByDescending(p => p.CreatedOn),
                OrderSorting.Oldect => ordersQuery.OrderBy(p => p.CreatedOn),
                OrderSorting.PriceAscending => ordersQuery.OrderBy(p => p.GrandTotalPrice),
                OrderSorting.PriceDescending => ordersQuery.OrderByDescending(p => p.GrandTotalPrice),
                _ => ordersQuery
            };

            IEnumerable<OrderAllViewModel> allOrders = await ordersQuery
                .Select(o => new OrderAllViewModel()
                {
                    Id = o.Id.ToString(),
                    OrderStatus = o.OrderStatus.ToString(),
                    CreatedOn = o.CreatedOn,
                    GrandTotalPrice = o.GrandTotalPrice,
                    PaymentMethod = o.PaymentMethod.ToString(),
                })
                .ToArrayAsync();

            int totalOrders = ordersQuery.Count();

            return new AllOrdersFilteredServiceModel()
            {
                TotalOrdersCount = totalOrders,
                Orders = allOrders,
            };
        }

        public async Task UpdateOrderStatusByIdAsync(string orderId, OrderStatusFormModel formModel)
        {
            Order? order = await dbContext.Orders
                .FirstOrDefaultAsync(o => o.Id.ToString() == orderId);

            int newOrderStatus = formModel.OrderStatus;

            if (order != null && (int)order.OrderStatus != newOrderStatus)
            {
                order.OrderStatus = (OrderStatusType)newOrderStatus;
            }

            await dbContext.SaveChangesAsync();
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

                order.OrderItems.Add(orderItem);
            }

            decimal subtotalPrice = order.OrderItems.Select(oi => oi.TotalPrice).Sum();

            order.UserId = Guid.Parse(userId);
            order.OrderStatus = OrderStatusType.InProgress;
            order.CreatedOn = DateTime.Now;
            order.ShippingAddress = formModel.CustomerName + "," + Environment.NewLine + formModel.ShippingAddress;
            order.ShippingPrice = formModel.ShippingPrice;
            order.SubTotalPrice = subtotalPrice;
            order.VAT = subtotalPrice * (vatPercentage / 100);
            order.GrandTotalPrice = order.ShippingPrice + order.SubTotalPrice + order.VAT;
            order.PaymentMethod = PaymentMethod.CourierPayment;
            order.TermsAccepted = formModel.TermsAccepted;

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

        public async Task<IEnumerable<OrderAllViewModel>> GetAllOrdersByUserIdAsync(string userId)
        {
            IEnumerable<OrderAllViewModel> userOrders = await dbContext.Orders
                .Where(o => o.UserId.ToString() == userId)
                .OrderByDescending(o => o.CreatedOn)
                .AsNoTracking()
                .Select(o => new OrderAllViewModel()
                {
                    Id = o.Id.ToString(),
                    OrderStatus = o.OrderStatus.ToString(),
                    CreatedOn = o.CreatedOn,
                    GrandTotalPrice = o.GrandTotalPrice,
                    PaymentMethod = o.PaymentMethod.ToString(),
                })
                .ToListAsync();

            return userOrders;
        }

        public async Task<OrderDetailsViewModel> GetOrderDetailsByIdAsync(string orderId)
        {
            Order? order = await dbContext.Orders
                .FirstOrDefaultAsync(o => o.Id.ToString() == orderId);

            var orderDetails = new OrderDetailsViewModel()
            {
                Id = order.Id.ToString(),
                CreatedOn = order.CreatedOn,
                OrderStatus = order.OrderStatus.ToString(),
                SubTotalPrice = order.SubTotalPrice,
                ShippingAddress = order.ShippingAddress,
                ShippingPrice = order.ShippingPrice,
                VAT = order.VAT,
                GrandTotalPrice = order.GrandTotalPrice,
                PaymentMethod = order.PaymentMethod.ToString(),
            };

            return orderDetails;
        }

        public async Task<OrderStatusFormModel> GetOrderForUpdateByIdAsync(string orderId)
        {
            Order order = await dbContext.Orders
                .FirstAsync(o => o.Id.ToString() == orderId);

            OrderStatusFormModel formModel = new OrderStatusFormModel()
            {
                OrderId = order.Id.ToString(),
                OrderStatusName = order.OrderStatus.ToString(),
            };

            return formModel;
        }

        public async Task<IEnumerable<AllOrderItemsViewModel>> GetOrderItemsByOrderIdAsync(string orderId)
        {
            var orderItems = await dbContext.OrderItems
                .Include(oi => oi.Product)
                .Where(oi => oi.OrderId.ToString() == orderId)
                .Select(oi => new AllOrderItemsViewModel()
                {
                    ProductId = oi.ProductId.ToString(),
                    Name = oi.Product.Name,
                    ImageUrl = oi.Product.ImageUrl,
                    Width = oi.Product.Width,
                    Height = oi.Product.Height,
                    SinglePrice = oi.SinglePrice,
                    TotalPrice = oi.TotalPrice,
                    Quantity = oi.Quantity,
                })
                .ToArrayAsync();

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

        public async Task<bool> IsUserOwnerAsync(string userId, string orderId)
        {
            bool isUserOwner = await dbContext.Orders
                .AnyAsync(o => o.UserId.ToString() == userId &&
                            o.Id.ToString() == orderId);

            return isUserOwner;
        }

        public async Task<bool> OrderExistsByIdAsync(string orderId)
        {
            bool isUserOwner = await dbContext.Orders
                .AnyAsync(o => o.Id.ToString() == orderId);

            return isUserOwner;
        }
    }
}
