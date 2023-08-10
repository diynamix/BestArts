namespace BestArts.Data
{
    using System.Reflection;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using Models;

    public class BestArtsDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public BestArtsDbContext(DbContextOptions<BestArtsDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Wishlist> Wishlists { get; set; } = null!;

        public DbSet<Cart> Carts { get; set; } = null!;

        public DbSet<OrderItem> OrderItems { get; set; } = null!;

        public DbSet<Order> Orders { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Wishlist>()
                .HasKey(w => new { w.ProductId, w.UserId });

            builder.Entity<Cart>()
                .HasKey(c => new { c.ProductId, c.UserId });

            builder.Entity<OrderItem>()
                .HasKey(oi => new { oi.OrderId, oi.ProductId });


            Assembly configAssembly = Assembly.GetAssembly(typeof(BestArtsDbContext)) ??
                Assembly.GetExecutingAssembly();
            builder.ApplyConfigurationsFromAssembly(configAssembly);

            base.OnModelCreating(builder);
        }
    }
}