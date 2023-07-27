namespace BestArts.Web.ViewModels.Product
{
    using Common;

    public class ProductAllViewModel
    {
        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public string CategoryName { get; set; } = null!;

        public decimal Width { get; set; }

        public decimal Height { get; set; }

        public decimal Price { get; set; }
    }
}
