namespace BestArts.Web.ViewModels.Cart
{
    using System.ComponentModel.DataAnnotations;

    using static Common.EntityValidationConstants.Cart;

    public class AllCartsViewModel
    {
        public string ProductId { get; set; } = null!;

        public string Name { get; set; } = null!;

        [Display(Name = "Image link")]
        public string ImageUrl { get; set; } = null!;

        public decimal Width { get; set; }

        public decimal Height { get; set; }

        public decimal Price { get; set; }

        [Required]
        [Range(typeof(int), QuantityMinValue, QuantityMaxValue)]
        public int Quantity { get; set; }
    }
}
