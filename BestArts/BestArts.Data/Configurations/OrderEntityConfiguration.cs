namespace BestArts.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class OrderEntityConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder
                .Property(o => o.ShippingPrice)
                .HasPrecision(18, 2);

            builder
                .Property(o => o.SubTotalPrice)
                .HasPrecision(18, 2);

            builder
                .Property(o => o.VAT)
                .HasPrecision(18, 2);

            builder
                .Property(o => o.GrandTotalPrice)
                .HasPrecision(18, 2);
        }
    }
}
