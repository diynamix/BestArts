namespace BestArts.Web.ViewModels.Product
{
    using System.ComponentModel.DataAnnotations;

    using Category;
    using static Common.EntityValidationConstants.Product;

    public class ProductFormModel
    {
        public ProductFormModel()
        {
            Categories = new HashSet<ProductSelectCategoryFormModel>();
        }

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(ImageUrlMaxLength)]
        [Display(Name = "ImageUrl URL")]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Range(typeof(decimal), WidthMinValue, WidthMaxValue)]
        public decimal Width { get; set; }

        [Required]
        [Range(typeof(decimal), HeightMinValue, HeightMaxValue)]
        public decimal Height { get; set; }

        [Required]
        [Range(typeof(decimal), PriceMinValue, PriceMaxValue)]
        public decimal Price { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        
        public IEnumerable<ProductSelectCategoryFormModel> Categories { get; set; } = null!;
    }
}
