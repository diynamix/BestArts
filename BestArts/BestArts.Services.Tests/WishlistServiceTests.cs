namespace BestArts.Services.Tests
{
    using Microsoft.EntityFrameworkCore;

    using BestArts.Data;
    using BestArts.Data.Models;
    using Services.Data;
    using Services.Data.Interfaces;
    using BestArts.Web.ViewModels.Product;

    public class WishlistServiceTests
    {
        private DbContextOptions<BestArtsDbContext> dbOptions;
        private BestArtsDbContext dbContext;

        private IWishlistService wishlistService;

        private Product product1;
        private Product product2;
        private ApplicationUser user;
        private Wishlist wishlist;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            dbOptions = new DbContextOptionsBuilder<BestArtsDbContext>()
                .UseInMemoryDatabase("BestArtsInMemory" + Guid.NewGuid().ToString())
                .Options;
            dbContext = new BestArtsDbContext(dbOptions);

            dbContext.Database.EnsureCreated();

            wishlistService = new WishlistService(dbContext);

            product1 = new Product()
            {
                Name = "Tulips",
                ImageUrl = "quilling-card-flower-tulip-red.jpg",
                CategoryId = 1,
                Width = 15,
                Height = 10,
                Price = 10,
            };
            dbContext.Products.Add(product1);

            product2 = new Product()
            {
                Name = "Blue Bear",
                ImageUrl = "quilling-card-bear-blue-small.jpg",
                CategoryId = 1,
                Width = 10,
                Height = 7.5M,
                Price = 7,
            };
            dbContext.Products.Add(product2);

            user = new ApplicationUser()
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
            dbContext.Users.Add(user);

            wishlist = new Wishlist()
            {
                UserId = user.Id,
                ProductId = product1.Id,
            };
            dbContext.Wishlists.Add(wishlist);

            dbContext.SaveChanges();
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task IsAlreadyAddedAsyncReturnsTrueWhenAdded()
        {
            bool result = await wishlistService.IsAlreadyAddedAsync(user.Id.ToString(), product1.Id.ToString());

            Assert.IsTrue(result);
        }

        [Test]
        public async Task IsAlreadyAddedAsyncReturnsFalseWhenNotAdded()
        {
            bool result = await wishlistService.IsAlreadyAddedAsync(user.Id.ToString(), product2.Id.ToString());

            Assert.IsFalse(result);
        }

        [Test]
        public async Task AllAsyncReturnsCorrectWishlistCollection()
        {
            var queryModel = new AllProductsQueryModel();

            var result = await wishlistService.AllAsync(queryModel, user.Id.ToString());

            Assert.IsNotNull(result);
            Assert.That(result.TotalProductsCount, Is.EqualTo(1));
        }
    }
}