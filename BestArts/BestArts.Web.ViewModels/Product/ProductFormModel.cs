namespace BestArts.Web.ViewModels.Product
{
    using Category;
    using static Common.EntityValidationConstants.Product;

    public class ProductFormModel
    {
        public ProductFormModel()
        {
            Categories
        }

        public string Name { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public decimal Width { get; set; }

        public decimal Height { get; set; }

        public decimal Price { get; set; }
        
        public IEnumerable<ProductSelectCategoryFormModel> Categories { get; set; } = null!;
    }
}
