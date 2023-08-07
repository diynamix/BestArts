namespace BestArts.Web.ViewModels.Order
{
    using System.ComponentModel.DataAnnotations;

    using static Common.EntityValidationConstants.Order;

    public class OrderFormModel
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        [Display(Name = "Full Name")]
        public string CustomerName { get; set; } = null!;

        [Required]
        [StringLength(AddressMaxLength, MinimumLength = AddressMinLength)]
        [Display(Name = "Shipping address")]
        public string ShippingAddress { get; set; } = null!;

        [Display(Name = "Shipping cost")]
        public decimal ShippingPrice { get; set; }

        [Display(Name = "Subtotal price")]
        public decimal SubTotalPrice { get; set; }

        [Display(Name = "VAT price")]
        public decimal VAT { get; set; }

        [Display(Name = "GrandTotal price")]
        public decimal GrandTotalPrice { get; set; }

        [Display(Name = "Accept Terms")]
        public bool AcceptTerms { get; set; }
    }
}
