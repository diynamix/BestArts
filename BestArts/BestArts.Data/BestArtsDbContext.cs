namespace BestArts.Data
{
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
    }
}