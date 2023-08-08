namespace BestArts.Web.ViewModels.Order
{
    using System.ComponentModel.DataAnnotations;

    public class OrderStatusFormModel
    {
        public int OrderId { get; set; }

        [Display(Name = "Order status")]
        public int OrderStatus { get; set; }
    }
}
