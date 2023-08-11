namespace BestArts.Services.Tests
{
    using Microsoft.EntityFrameworkCore;

    using BestArts.Data;
    using Services.Data;
    using Services.Data.Interfaces;
    using BestArts.Data.Models;
    using BestArts.Web.ViewModels.Product;

    public class ProductServiceTests
    {
        private DbContextOptions<BestArtsDbContext> dbOptions;
        private BestArtsDbContext dbContext;

        private IProductService productService;
        private IWishlistService wishlistService;

        public static ApplicationUser user;
        public static Product product;

        [SetUp]
        public void OneTimeSetUp()
        {
            dbOptions = new DbContextOptionsBuilder<BestArtsDbContext>()
                .UseInMemoryDatabase("BestArtsInMemory" + Guid.NewGuid().ToString())
                .Options;
            dbContext = new BestArtsDbContext(dbOptions);

            dbContext.Database.EnsureCreated();

            productService = new ProductService(dbContext);
            wishlistService = new WishlistService(dbContext);

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

            product = new Product()
            {
                Name = "Tulips",
                ImageUrl = "quilling-card-flower-tulip-red.jpg",
                CategoryId = 1,
                Width = 15,
                Height = 10,
                Price = 10,
            };
            dbContext.Products.Add(product);

            dbContext.SaveChanges();
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task AllAsyncReturnsCorrectProductCollection()
        {
            var queryModel = new AllProductsQueryModel();

            var result = await productService.AllAsync(queryModel);

            Assert.IsNotNull(result);
            Assert.That(result.TotalProductsCount, Is.EqualTo(21));
        }

        [Test]
        public async Task CreateAsyncCreatesCorrectProduct()
        {
            ProductFormModel formModel = new ProductFormModel()
            {
                Name = "New Created Product",
                ImageUrl = "quilling-card-flower-tulip-red.jpg",
                Width = 15,
                Height = 10,
                Price = 10,
                CategoryId = 1,
            };

            string productId = await productService.CreateAsync(formModel);

            bool productExists = await productService.ExistsByIdAsync(productId);

            Assert.IsTrue(productExists);
        }

        [Test]
        public async Task DeleteProductByIdAsyncWorksCorrectly()
        {
            await productService.DeleteProductByIdAsync(product.Id.ToString());

            bool productExists = await productService.ExistsByIdAsync(product.Id.ToString());

            Assert.IsFalse(productExists);
        }

        [Test]
        public async Task EditProductByIdAsyncWorksCorrectly()
        {
            ProductFormModel formModel = new ProductFormModel()
            {
                Name = "Eddited Product",
                ImageUrl = "quilling-money-envelope-pink.jpg",
                Width = 20,
                Height = 10,
                Price = 15,
                CategoryId = 2,
            };

            await productService.EditProductByIdAsync(product.Id.ToString(), formModel);

            Assert.That(product.Name, Is.EqualTo("Eddited Product"));
            Assert.That(product.ImageUrl, Is.EqualTo("quilling-money-envelope-pink.jpg"));
            Assert.That(product.Width, Is.EqualTo(20));
            Assert.That(product.Height, Is.EqualTo(10));
            Assert.That(product.Price, Is.EqualTo(15));
            Assert.That(product.CategoryId, Is.EqualTo(2));
        }

        [Test]
        public async Task GetDetailsByIdAsyncReturnsCorrectProductDetails()
        {
            var result = await productService.GetDetailsByIdAsync(product.Id.ToString());

            Assert.That(result.Id.ToString(), Is.EqualTo(product.Id.ToString()));
            Assert.That(result.Name, Is.EqualTo("Tulips"));
            Assert.That(result.ImageUrl, Is.EqualTo("quilling-card-flower-tulip-red.jpg"));
            Assert.That(result.Width, Is.EqualTo(15));
            Assert.That(result.Height, Is.EqualTo(10));
            Assert.That(result.Price, Is.EqualTo(10));
            Assert.That(result.CategoryName, Is.EqualTo("Quilling card"));
        }

        [Test]
        public async Task GetProductForEditByIdAsyncReturnsCorrectProductDetails()
        {
            var result = await productService.GetProductForEditByIdAsync(product.Id.ToString());

            Assert.That(result.Name, Is.EqualTo("Tulips"));
            Assert.That(result.ImageUrl, Is.EqualTo("quilling-card-flower-tulip-red.jpg"));
            Assert.That(result.Width, Is.EqualTo(15));
            Assert.That(result.Height, Is.EqualTo(10));
            Assert.That(result.Price, Is.EqualTo(10));
            Assert.That(result.CategoryId, Is.EqualTo(1));
        }

        [Test]
        public async Task GetProductForSoftDeleteByIdAsyncReturnsCorrectProductDetails()
        {
            var result = await productService.GetProductForSoftDeleteByIdAsync(product.Id.ToString());

            Assert.That(result.Id.ToString(), Is.EqualTo(product.Id.ToString()));
            Assert.That(result.Name, Is.EqualTo("Tulips"));
            Assert.That(result.ImageUrl, Is.EqualTo("quilling-card-flower-tulip-red.jpg"));
            Assert.That(result.CategoryName, Is.EqualTo("Quilling card"));
        }

        [Test]
        public async Task AddProductToWishlistAsync_AddsProduct()
        {
            await productService.AddProductToWishlistAsync(user.Id.ToString(), product.Id.ToString());

            bool result = await wishlistService.IsAlreadyAddedAsync(user.Id.ToString(), product.Id.ToString());

            Assert.IsTrue(result);
        }

        [Test]
        public async Task RemoveProductFromWishlistAsync_RemovesProduct()
        {
            await productService.AddProductToWishlistAsync(user.Id.ToString(), product.Id.ToString());

            await productService.RemoveProductFromWishlistAsync(user.Id.ToString(), product.Id.ToString());

            bool result = await wishlistService.IsAlreadyAddedAsync(user.Id.ToString(), product.Id.ToString());

            Assert.IsFalse(result);
        }
    }
}