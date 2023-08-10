namespace BestArts.Services.Tests
{
    using Microsoft.EntityFrameworkCore;

    using BestArts.Data;
    using BestArts.Data.Models;
    using Services.Data;
    using Services.Data.Interfaces;
    using BestArts.Web.ViewModels.Cart;

    public class CartServiceTests
    {
        private DbContextOptions<BestArtsDbContext> dbOptions;
        private BestArtsDbContext dbContext;

        private ICartService cartService;

        private Product product1;
        private Product product2;
        private ApplicationUser user;
        private Cart cart;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
        }

        [SetUp]
        public void Setup()
        {
            dbOptions = new DbContextOptionsBuilder<BestArtsDbContext>()
                .UseInMemoryDatabase("BestArtsInMemory" + Guid.NewGuid().ToString())
                .Options;
            dbContext = new BestArtsDbContext(dbOptions);

            dbContext.Database.EnsureCreated();

            cartService = new CartService(dbContext);

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

            cart = new Cart()
            {
                UserId = user.Id,
                ProductId = product1.Id,
                Quantity = 1,
            };
            dbContext.Carts.Add(cart);

            dbContext.SaveChanges();
        }

        [Test]
        public async Task IsAlreadyAddedAsyncReturnsTrueWhenAdded()
        {
            bool result = await cartService.IsAlreadyAddedAsync(user.Id.ToString(), product1.Id.ToString());

            Assert.IsTrue(result);
        }

        [Test]
        public async Task IsAlreadyAddedAsyncReturnsFalseWhenNotAdded()
        {
            bool result = await cartService.IsAlreadyAddedAsync(user.Id.ToString(), product2.Id.ToString());

            Assert.IsFalse(result);
        }

        [Test]
        public async Task AllCartsAsyncReturnsCorrectCollection()
        {
            var result = await cartService.AllCartsAsync(user.Id.ToString());

            Assert.IsNotNull(result);
            Assert.That(result.Count, Is.EqualTo(1));
        }

        [Test]
        public async Task AddProductToCartAsyncWorksCorrectly()
        {
            await cartService.AddProductToCartAsync(user.Id.ToString(), product2.Id.ToString());

            bool result = await cartService.IsAlreadyAddedAsync(user.Id.ToString(), product2.Id.ToString());

            Assert.IsTrue(result);
        }

        [Test]
        public async Task RemoveProductFromCartAsyncWorksCorrectly()
        {
            await cartService.RemoveProductFromCartAsync(user.Id.ToString(), product1.Id.ToString());

            bool result = await cartService.IsAlreadyAddedAsync(user.Id.ToString(), product1.Id.ToString());

            Assert.IsFalse(result);
        }

        [Test]
        public async Task UpdateProductQuantityAsyncWorksCorrectly()
        {
            int oldQuantity = cart.Quantity;

            var model = new AllCartsViewModel() { Quantity = 2 };

            await cartService.UpdateProductQuantityAsync(cart.UserId.ToString(), cart.ProductId.ToString(), model);

            int newQuantity = cart.Quantity;

            Assert.That(newQuantity, Is.Not.EqualTo(oldQuantity));
            Assert.That(newQuantity, Is.EqualTo(2));
        }

        [Test]
        public async Task GetProductForDeletingFromCartAsyncWorksCorrectly()
        {
            var productForDelete = await cartService.GetProductForDeletingFromCartAsync(cart.UserId.ToString(), cart.ProductId.ToString());

            Assert.That(productForDelete.Id.ToString(), Is.EqualTo(product1.Id.ToString()));
            Assert.That(productForDelete.Name, Is.EqualTo("Tulips"));
            Assert.That(productForDelete.ImageUrl, Is.EqualTo("quilling-card-flower-tulip-red.jpg"));
            Assert.That(productForDelete.Width, Is.EqualTo(15));
            Assert.That(productForDelete.Height, Is.EqualTo(10));
        }
    }
}