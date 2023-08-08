namespace BestArts.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class OrderItemEntityConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder
                .Property(oi => oi.TotalPrice)
                .HasPrecision(18, 2);

            builder
                .Property(oi => oi.SinglePrice)
                .HasPrecision(18, 2);
        }
    }
}
