namespace BestArts.Web.ViewModels.Cart
{
    using System.ComponentModel.DataAnnotations;

    public class DeleteCartProductViewModel
    {
        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;

        [Display(Name = "Image link")]
        public string ImageUrl { get; set; } = null!;

        public decimal Width { get; set; }

        public decimal Height { get; set; }
    }
}
