namespace BestArts.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder
                .Property(u => u.FirstName)
                .HasDefaultValue("FirstName");

            builder
                .Property(u => u.LastName)
                .HasDefaultValue("LastName");

            //builder.HasData(GenerateUsers());
        }

        //public ApplicationUser[] GenerateUsers()
        //{
        //    ICollection<ApplicationUser> users = new HashSet<ApplicationUser>();

        //    ApplicationUser user;

        //    var hasher = new PasswordHasher<ApplicationUser>();

        //    user = new ApplicationUser()
        //    {
        //        FirstName = "Jack",
        //        LastName = "Rabbit",
        //        Email = "jackrabbit@mail.com",
        //        PhoneNumber = "+359000000000",
        //    };
        //    user.PasswordHash = hasher.HashPassword(user, "123456");

        //    users.Add(user);

        //    return users.ToArray();
        //}
    }
}
