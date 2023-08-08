namespace BestArts.Web.ViewModels.Order
{
    using System.ComponentModel.DataAnnotations;

    public class OrderDetailsViewModel : OrderAllViewModel
    {
        public OrderDetailsViewModel()
        {
            OrderItems = new HashSet<AllOrderItemsViewModel>();
        }

        [Display(Name = "Shipping address")]
        public string ShippingAddress { get; set; } = null!;

        [Display(Name = "Shipping cost")]
        public decimal ShippingPrice { get; set; }

        [Display(Name = "Subtotal price")]
        public decimal SubTotalPrice { get; set; }

        [Display(Name = "VAT price")]
        public decimal VAT { get; set; }

        public IEnumerable<AllOrderItemsViewModel> OrderItems { get; set; } = null!;
    }
}
