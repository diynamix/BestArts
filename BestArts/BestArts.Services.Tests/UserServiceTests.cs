namespace BestArts.Services.Tests
{
    using Microsoft.EntityFrameworkCore;

    using BestArts.Data;
    using Services.Data;
    using Services.Data.Interfaces;

    using static DatabaseSeeder;

    public class UserServiceTests
    {
        private DbContextOptions<BestArtsDbContext> dbOptions;
        private BestArtsDbContext dbContext;

        private IUserService userService;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            dbOptions = new DbContextOptionsBuilder<BestArtsDbContext>()
                .UseInMemoryDatabase("BestArtsInMemory" + Guid.NewGuid().ToString())
                .Options;
            dbContext = new BestArtsDbContext(dbOptions);

            dbContext.Database.EnsureCreated();
            SeedDatabase(dbContext);

            userService = new UserService(dbContext);
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task GetFullNameByIdAsyncShouldReturnsCorrectFullName()
        {
            string user1Id = User1.Id.ToString();

            string expectedResult = "Jack Rabbit";
            string actualResult = await userService.GetFullNameByIdAsync(user1Id);

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public async Task AllAsyncReturnsCorrectUserCollection()
        {
            var result = await userService.AllAsync();

            Assert.IsNotNull(result);
            Assert.That(result.Count, Is.EqualTo(3));
        }
    }
}