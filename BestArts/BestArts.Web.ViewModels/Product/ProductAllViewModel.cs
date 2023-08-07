namespace BestArts.Web.ViewModels.Product
{
    using System.ComponentModel.DataAnnotations;

    public class ProductAllViewModel
    {
        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;

        [Display(Name = "Image link")]
        public string ImageUrl { get; set; } = null!;

        [Display(Name = "Category")]
        public string CategoryName { get; set; } = null!;

        public decimal Width { get; set; }

        public decimal Height { get; set; }

        public decimal Price { get; set; }
    }
}
