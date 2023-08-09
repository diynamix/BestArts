namespace BestArts.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using Services.Data.Models.Order;
    using Services.Data.Interfaces;
    using ViewModels.Order;

    using static Common.GeneralApplicationConstants;
    using static Common.NotificationMessagesConstants;

    public class OrderController : BaseAdminController
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery] AllOrdersQueryModel queryModel)
        {
            AllOrdersFilteredServiceModel serviceModel = await orderService.AllAsync(queryModel);

            queryModel.Orders = serviceModel.Orders;
            queryModel.TotalOrders = serviceModel.TotalOrdersCount;

            return View(queryModel);
        }

        [HttpGet]
        public async Task<IActionResult> Update(string orderId)
        {
            bool orderExists = await orderService.OrderExistsByIdAsync(orderId);

            if (!orderExists)
            {
                TempData[ErrorMessage] = "The order does not exist!";

                return RedirectToAction("All", "Order", new { Area = AdminAreaName});
            }

            try
            {
                OrderStatusFormModel formModel = await orderService.GetOrderForUpdateByIdAsync(orderId);

                return View(formModel);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Update(OrderStatusFormModel formModel, string orderId)
        {
            if (!ModelState.IsValid)
            {
                return View(formModel);
            }

            bool orderExists = await orderService.OrderExistsByIdAsync(orderId);

            if (!orderExists)
            {
                TempData[ErrorMessage] = "The order does not exist!";

                return RedirectToAction("All", "Order", new { Area = AdminAreaName });
            }

            try
            {
                await orderService.UpdateOrderStatusByIdAsync(orderId, formModel);

                TempData[SuccessMessage] = "Order status updated successfully!";
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Unexpected error occured while updating order status!");

                return View(formModel);
            }

            return RedirectToAction("Details", "Order", new { orderId, Area = String.Empty });
        }

        private IActionResult GeneralError()
        {
            TempData[ErrorMessage] = "Unexpected error occurred!";

            return RedirectToAction("All", "Product");
        }
    }
}
