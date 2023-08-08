namespace BestArts.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using Infrastructure.Extensions;
    using Services.Data.Interfaces;
    using ViewModels.Order;

    using static Common.GeneralApplicationConstants;
    using static Common.NotificationMessagesConstants;

    public class OrderController : Controller
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
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

            //TODO...
            return RedirectToAction("All", "Product");
        }

        private IActionResult GeneralError()
        {
            TempData[ErrorMessage] = "Unexpected error occurred!";

            return RedirectToAction("All", "Cart");
        }
    }
}
