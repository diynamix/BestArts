namespace BestArts.Services.Tests
{
    using Microsoft.EntityFrameworkCore;

    using BestArts.Data;
    using Services.Data;
    using Services.Data.Interfaces;
    using BestArts.Data.Models;

    public class UserServiceTests
    {
        private DbContextOptions<BestArtsDbContext> dbOptions;
        private BestArtsDbContext dbContext;
        private IUserService userService;

        public static ApplicationUser user1;
        public static ApplicationUser user2;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            dbOptions = new DbContextOptionsBuilder<BestArtsDbContext>()
                .UseInMemoryDatabase("BestArtsInMemory" + Guid.NewGuid().ToString())
                .Options;
            dbContext = new BestArtsDbContext(dbOptions);

            dbContext.Database.EnsureCreated();

            userService = new UserService(dbContext);

            user1 = new ApplicationUser()
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

            user2 = new ApplicationUser()
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

            dbContext.Users.Add(user1);
            dbContext.Users.Add(user2);
            dbContext.SaveChanges();
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task GetFullNameByIdAsyncShouldReturnsCorrectFullName()
        {
            string user1Id = user1.Id.ToString();

            string expectedResult = "Jack Rabbit";
            string actualResult = await userService.GetFullNameByIdAsync(user1Id);

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public async Task AllAsyncReturnsCorrectUserCollection()
        {
            var result = await userService.AllAsync();

            Assert.IsNotNull(result);
            Assert.That(result.Count, Is.EqualTo(2));
        }
    }
}