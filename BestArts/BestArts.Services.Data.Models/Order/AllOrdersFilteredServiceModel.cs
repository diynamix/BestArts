namespace BestArts.Services.Data.Models.Order
{
    using BestArts.Web.ViewModels.Order;

    public class AllOrdersFilteredServiceModel
    {
        public AllOrdersFilteredServiceModel()
        {
            Orders = new HashSet<OrderAllViewModel>();
        }

        public int TotalOrdersCount { get; set; }

        public IEnumerable<OrderAllViewModel> Orders { get; set; } = null!;
    }
}
