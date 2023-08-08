namespace BestArts.Web.ViewModels.Order
{
    using System.ComponentModel.DataAnnotations;

    public class OrderAllViewModel
    {
        public string Id { get; set; } = null!;

        [Display(Name = "Order status")]
        public string OrderStatus { get; set; } = null!;

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Created on")]
        public DateTime CreatedOn { get; set; }

        [Display(Name = "Grand total price")]
        public decimal GrandTotalPrice { get; set; }

        public string PaymentMethod { get; set; } = null!;
    }
}
