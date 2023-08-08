namespace BestArts.Web.ViewModels.Order
{
using System.ComponentModel.DataAnnotations;
    public class AllOrderItemsViewModel
    {
        public string ProductId { get; set; } = null!;

        public string Name { get; set; } = null!;

        [Display(Name = "Image link")]
        public string ImageUrl { get; set; } = null!;

        public decimal Width { get; set; }

        public decimal Height { get; set; }
        
        public int Quantity { get; set; }

        [Display(Name = "Single price")]
        public decimal SinglePrice { get; set; }

        [Display(Name = "Total price")]
        public decimal TotalPrice { get; set; }
    }
}
