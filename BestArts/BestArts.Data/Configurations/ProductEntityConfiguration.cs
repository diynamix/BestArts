namespace BestArts.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .Property(h => h.CreatedOn)
                .HasDefaultValueSql("GETDATE()");

            builder
                .Property(p => p.Width)
                .HasPrecision(18, 2);

            builder
                .Property(p => p.Height)
                .HasPrecision(18, 2);

            builder
                .Property(p => p.Price)
                .HasPrecision(18, 2);

            builder
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(GenerateProducts());
        }

        private Product[] GenerateProducts()
        {
            ICollection<Product> products = new HashSet<Product>();

            Product product;

            product = new Product()
            {
                Name = "Tulips",
                ImageUrl = "quilling-card-flower-tulip-red.jpg",
                CategoryId = 1,
                Width = 15,
                Height = 10,
                Price = 10,
            };
            products.Add(product);

            product = new Product()
            {
                Name = "Blue Bear",
                ImageUrl = "quilling-card-bear-blue-small.jpg",
                CategoryId = 1,
                Width = 10,
                Height = 7.5M,
                Price = 7,
            };
            products.Add(product);

            product = new Product()
            {
                Name = "Red Bear",
                ImageUrl = "quilling-card-bear-red-small.jpg",
                CategoryId = 1,
                Width = 10,
                Height = 7.5M,
                Price = 7.50M,
            };
            products.Add(product);

            product = new Product()
            {
                Name = "Anniversary",
                ImageUrl = "quilling-card-flower-anniversary-orange.jpg",
                CategoryId = 1,
                Width = 15,
                Height = 10,
                Price = 10.80M,
            };
            products.Add(product);

            product = new Product()
            {
                Name = "Brown flowers",
                ImageUrl = "quilling-card-flower-brown.jpg",
                CategoryId = 1,
                Width = 15,
                Height = 10,
                Price = 12,
            };
            products.Add(product);

            product = new Product()
            {
                Name = "Yellow flowers",
                ImageUrl = "quilling-card-flower-yellow.jpg",
                CategoryId = 1,
                Width = 15,
                Height = 10,
                Price = 10.50M,
            };
            products.Add(product);

            product = new Product()
            {
                Name = "Anniversary",
                ImageUrl = "quilling-card-folding-flower-orange.jpg",
                CategoryId = 1,
                Width = 30,
                Height = 21,
                Price = 17,
            };
            products.Add(product);

            product = new Product()
            {
                Name = "Whitedrops",
                ImageUrl = "quilling-card-snowdrop-white.jpg",
                CategoryId = 1,
                Width = 15,
                Height = 10,
                Price = 10,
            };
            products.Add(product);

            product = new Product()
            {
                Name = "Violet",
                ImageUrl = "quilling-card-violet.png",
                CategoryId = 1,
                Width = 10,
                Height = 7.5M,
                Price = 10,
            };
            products.Add(product);

            product = new Product()
            {
                Name = "Heart",
                ImageUrl = "quilling-magnet-heart-red.jpg",
                CategoryId = 2,
                Width = 7.5M,
                Height = 6,
                Price = 10,
            };
            products.Add(product);

            product = new Product()
            {
                Name = "Flower basket",
                ImageUrl = "quilling-magnet-basket-multi.jpg",
                CategoryId = 2,
                Width = 6.5M,
                Height = 4.5M,
                Price = 10,
            };
            products.Add(product);

            product = new Product()
            {
                Name = "Panda",
                ImageUrl = "quilling-magnet-bear-panda.jpg",
                CategoryId = 2,
                Width = 6,
                Height = 4,
                Price = 10,
            };
            products.Add(product);

            product = new Product()
            {
                Name = "Bulgarian rose",
                ImageUrl = "quilling-magnet-bulgarian-rose-red.jpg",
                CategoryId = 2,
                Width = 8,
                Height = 5.5M,
                Price = 10,
            };
            products.Add(product);

            product = new Product()
            {
                Name = "Dolphin",
                ImageUrl = "quilling-magnet-dolphin-blue.jpg",
                CategoryId = 2,
                Width = 9,
                Height = 6,
                Price = 10,
            };
            products.Add(product);

            product = new Product()
            {
                Name = "Flower",
                ImageUrl = "quilling-magnet-flower-circle-multi.jpg",
                CategoryId = 2,
                Width = 7,
                Height = 7,
                Price = 10,
            };
            products.Add(product);

            product = new Product()
            {
                Name = "Orange flower",
                ImageUrl = "quilling-card-flower-orange.png",
                CategoryId = 1,
                Width = 13.5M,
                Height = 13.5M,
                Price = 15,
            };
            products.Add(product);

            product = new Product()
            {
                Name = "Wedding",
                ImageUrl = "quilling-card-flower-wedding-beige.png",
                CategoryId = 1,
                Width = 13.5M,
                Height = 13.5M,
                Price = 15,
            };
            products.Add(product);

            product = new Product()
            {
                Name = "Baby blue",
                ImageUrl = "quilling-card-baby-chair-blue.jpg",
                CategoryId = 1,
                Width = 13.5M,
                Height = 13.5M,
                Price = 14.50M,
            };
            products.Add(product);

            product = new Product()
            {
                Name = "Bottle",
                ImageUrl = "quilling-bottle.jpg",
                CategoryId = 4,
                Width = 15,
                Height = 7,
                Price = 20,
            };
            products.Add(product);

            product = new Product()
            {
                Name = "Doll w flowers",
                ImageUrl = "quilling-doll.jpg",
                CategoryId = 3,
                Width = 6,
                Height = 5,
                Price = 15,
            };
            products.Add(product);

            return products.ToArray();
        }
    }
}
