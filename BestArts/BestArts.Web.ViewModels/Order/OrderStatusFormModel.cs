namespace BestArts.Web.ViewModels.Order
{
    using System.ComponentModel.DataAnnotations;

    using static Common.EntityValidationConstants.Order;

    public class OrderStatusFormModel
    {
        public string OrderId { get; set; } = null!;

        [Display(Name = "Current status")]
        public string? OrderStatusName { get; set; }

        [Required]
        [Range(OrderStatusMinValue, OrderStatusMaxValue)]
        [Display(Name = "New status")]
        public int OrderStatus { get; set; }
    }
}
