namespace BestArts.Web.ViewModels.Order
{
    using System.ComponentModel.DataAnnotations;
    using BestArts.Web.ViewModels.Order.Enums;

    public class AllOrdersQueryModel
    {
        public AllOrdersQueryModel()
        {
            Orders = new HashSet<OrderAllViewModel>();
        }

        [Display(Name = "Order status")]
        public int OrderStatus { get; set; }

        [Display(Name = "Sort by")]
        public OrderSorting OrderSorting { get; set; }

        public int TotalOrders { get; set; }

        public IEnumerable<OrderAllViewModel> Orders { get; set; } = null!;
    }
}
