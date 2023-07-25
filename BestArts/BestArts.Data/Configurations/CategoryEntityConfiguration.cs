namespace BestArts.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(GenerateCategories());
        }

        private Category[] GenerateCategories()
        {
            ICollection<Category> categories = new HashSet<Category>();

            Category category;

            category = new Category()
            {
                Id = 1,
                Name = "Quilling card"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 2,
                Name = "Magnet"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 3,
                Name = "Quilling doll"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 4,
                Name = "Quilling bottle"
            };
            categories.Add(category);

            return categories.ToArray();
        }
    }
}
