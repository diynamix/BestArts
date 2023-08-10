namespace BestArts.Services.Tests
{
    using BestArts.Data;
    using BestArts.Data.Models;

    public static class DatabaseSeeder
    {
        public static ApplicationUser User1;
        public static ApplicationUser User2;
        public static ApplicationUser User3;

        public static void SeedDatabase(BestArtsDbContext dbContext)
        {
            User1 = new ApplicationUser()
            {
                UserName = "jackrabbit@user.tests",
                NormalizedUserName = "JACKRABBIT@USER.TESTS",
                Email = "jackrabbit@user.tests",
                NormalizedEmail = "JACKRABBIT@USER.TESTS",
                EmailConfirmed = true,
                PasswordHash = "8D969EEF6ECAD3C29A3A629280E686CF0C3F5D5A86AFF3CA12020C923ADC6C92",
                SecurityStamp = "f6dee661-4201-4d37-8f58-0164ee6efa38",
                TwoFactorEnabled = false,
                FirstName = "Jack",
                LastName = "Rabbit",
            };

            User2 = new ApplicationUser()
            {
                UserName = "duckdodgers@user.tests",
                NormalizedUserName = "DUCKDODGERS@USER.TESTS",
                Email = "duckdodgers@user.tests",
                NormalizedEmail = "DUCKDODGERS@USER.TESTS",
                EmailConfirmed = true,
                PasswordHash = "8D969EEF6ECAD3C29A3A629280E686CF0C3F5D5A86AFF3CA12020C923ADC6C92",
                SecurityStamp = "ca32c787-626e-4234-a4e4-8c94d85a2b1c",
                TwoFactorEnabled = false,
                FirstName = "Duck",
                LastName = "Dodgers",
            };
            
            User3 = new ApplicationUser()
            {
                UserName = "bugsbunny@user.tests",
                NormalizedUserName = "BUGSBUNNY@USER.TESTS",
                Email = "bugsbunny@user.tests",
                NormalizedEmail = "BUGSBUNNY@USER.TESTS",
                EmailConfirmed = true,
                PasswordHash = "8D969EEF6ECAD3C29A3A629280E686CF0C3F5D5A86AFF3CA12020C923ADC6C92",
                SecurityStamp = "f6af46f5-74ba-43dc-927b-ad83497d0387",
                TwoFactorEnabled = false,
                FirstName = "Bugs",
                LastName = "Bunny",
            };

            dbContext.Users.Add(User1);
            dbContext.Users.Add(User2);
            dbContext.Users.Add(User3);
            dbContext.SaveChanges();
        }
    }
}
