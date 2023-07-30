namespace BestArts.Web.ViewModels.Product
{
using System.ComponentModel.DataAnnotations;

    public class ProductSoftDeleteViewModel
    {
        public string Name { get; set; } = null!;

        [Display(Name = "Image link")]
        public string ImageUrl { get; set; } = null!;

        [Display(Name = "Category")]

        public string CategoryName { get; set; } = null!;
    }
}
