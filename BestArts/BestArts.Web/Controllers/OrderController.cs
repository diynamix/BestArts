namespace BestArts.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using Infrastructure.Extensions;
    using Services.Data.Interfaces;
    using Services.Data.Models.Order;
    using ViewModels.Order;
    
    using static Common.GeneralApplicationConstants;
    using static Common.NotificationMessagesConstants;
    using BestArts.Services.Data;

    public class OrderController : Controller
    {
        private readonly IOrderService orderService;
        private readonly ICartService cartService;

        public OrderController(IOrderService orderService,
            ICartService cartService)
        {
            this.orderService = orderService;
            this.cartService = cartService;
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery] AllOrdersQueryModel queryModel)
        {
            if (!User.IsAdmin())
            {
                TempData[ErrorMessage] = "You cannot access this page!";

                return RedirectToAction("Index", "Home");
            }

            AllOrdersFilteredServiceModel serviceModel = await orderService.AllAsync(queryModel);

            queryModel.Orders = serviceModel.Orders;
            queryModel.TotalOrders = serviceModel.TotalOrdersCount;

            return View(queryModel);
        }

        [HttpGet]
        public async Task<IActionResult> Checkout()
        {
            try
            {
                decimal subtotalPrice = await orderService.GetSubtotalPriceOfAllItemsForOrderAsync(User.GetId()!);

                decimal vatPrice = subtotalPrice * (vatPercentage / 100);

                decimal shippingPrice = standartShipping;

                decimal grandTotalPrice = subtotalPrice + vatPrice + shippingPrice;

                OrderFormModel formModel = new OrderFormModel()
                {
                    SubTotalPrice = subtotalPrice,
                    VAT = vatPrice,
                    ShippingPrice = shippingPrice,
                    GrandTotalPrice = grandTotalPrice,
                };

                return View(formModel);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Checkout(OrderFormModel formModel)
        {
            if (!ModelState.IsValid)
            {
                return View(formModel);
            }

            try
            {
                IEnumerable<CartToOrderItemServiceModel> orderItems = await orderService.GetAllItemsForOrderAsync(User.GetId()!);

                await orderService.CreateOrderAsync(formModel, orderItems, User.GetId()!);

                foreach (var orderItem in orderItems)
                {
                    await cartService.RemoveProductFromCartAsync(User.GetId()!, orderItem.ProductId);
                }

                TempData[SuccessMessage] = "Order placed successfully!";
            }
            catch (Exception)
            {
                return GeneralError();
            }

            return RedirectToAction("All", "Product");
        }

        [HttpGet]
        public async Task<IActionResult> Details(string orderId)
        {
            bool isUserOwner = await orderService.IsUserOwnerAsync(User.GetId()!, orderId);

            if (!isUserOwner && !User.IsAdmin())
            {
                TempData[ErrorMessage] = "You cannot access this page!";

                return RedirectToAction("Index", "Home");
            }

            try
            {
                var orderItems = await orderService.GetOrderItemsByOrderIdAsync(orderId);

                var viewModel = await orderService.GetOrderDetailsByIdAsync(orderId);

                viewModel.OrderItems = orderItems;

                return View(viewModel);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        //[HttpGet]
        //public async Task<IActionResult> Update()
        //{
        //    try
        //    {
        //        decimal subtotalPrice = await orderService.GetSubtotalPriceOfAllItemsForOrderAsync(User.GetId()!);

        //        decimal vatPrice = subtotalPrice * (vatPercentage / 100);

        //        decimal shippingPrice = standartShipping;

        //        decimal grandTotalPrice = subtotalPrice + vatPrice + shippingPrice;

        //        OrderFormModel formModel = new OrderFormModel()
        //        {
        //            SubTotalPrice = subtotalPrice,
        //            VAT = vatPrice,
        //            ShippingPrice = shippingPrice,
        //            GrandTotalPrice = grandTotalPrice,
        //        };

        //        return View(formModel);
        //    }
        //    catch (Exception)
        //    {
        //        return GeneralError();
        //    }
        //}

        //[HttpPost]
        //public async Task<IActionResult> Update(OrderStatusFormModel formModel)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(formModel);
        //    }

        //    try
        //    {
        //        IEnumerable<CartToOrderItemServiceModel> orderItems = await orderService.GetAllItemsForOrderAsync(User.GetId()!);

        //        await orderService.CreateOrderAsync(formModel, orderItems, User.GetId()!);

        //        foreach (var orderItem in orderItems)
        //        {
        //            await cartService.RemoveProductFromCartAsync(User.GetId()!, orderItem.ProductId);
        //        }

        //        TempData[SuccessMessage] = "Order placed successfully!";
        //    }
        //    catch (Exception)
        //    {
        //        return GeneralError();
        //    }

        //    return RedirectToAction("All", "Product");
        //}

        private IActionResult GeneralError()
        {
            TempData[ErrorMessage] = "Unexpected error occurred!";

            return RedirectToAction("All", "Product");
        }
    }
}
