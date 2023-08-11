namespace BestArts.Services.Tests
{
    using Microsoft.EntityFrameworkCore;

    using BestArts.Data;
    using Services.Data;
    using Services.Data.Interfaces;
    using BestArts.Data.Models;
    using BestArts.Web.ViewModels.Category;

    public class CategoryServiceTests
    {
        private DbContextOptions<BestArtsDbContext> dbOptions;
        private BestArtsDbContext dbContext;
        private ICategoryService categoryService;

        public static Category category5;

        [SetUp]
        public void OneTimeSetUp()
        {
            dbOptions = new DbContextOptionsBuilder<BestArtsDbContext>()
                .UseInMemoryDatabase("BestArtsInMemory" + Guid.NewGuid().ToString())
                .Options;
            dbContext = new BestArtsDbContext(dbOptions);

            dbContext.Database.EnsureCreated();

            categoryService = new CategoryService(dbContext);

            category5 = new Category()
            {
                Id = 5,
                Name = "Stars"
            };

            dbContext.Categories.Add(category5);

            dbContext.SaveChanges();
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task AllCategoriesAsyncReturnsCorrectCollection()
        {
            var result = await categoryService.AllCategoriesAsync();
            
            Assert.IsNotNull(result);
            Assert.That(result.Count, Is.EqualTo(5));
        }

        [Test]
        public async Task AllCategoriesForProductSelectFormModelAsyncReturnsCorrectCollection()
        {
            var result = await categoryService.AllCategoriesForProductSelectFormModelAsync();
            
            Assert.IsNotNull(result);
            Assert.That(result.Count, Is.EqualTo(5));
        }

        [Test]
        public async Task AllCategoryNamesAsyncReturnsCorrectCollection()
        {
            IEnumerable<string> expected = new string[] { "Quilling card", "Magnet", "Quilling doll", "Quilling bottle", "Stars" };
            var result = await categoryService.AllCategoryNamesAsync();
            
            Assert.IsNotNull(result);
            Assert.That(result.Count, Is.EqualTo(5));
            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public async Task ExistsByIdAsyncReturnsTrueWhenCategoryExists()
        {
            bool result = await categoryService.ExistsByIdAsync(1);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task ExistsByIdAsyncReturnsTrueWhenCategoryDoesNotExists()
        {
            bool result = await categoryService.ExistsByIdAsync(100);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task ExistsNameIdAsyncReturnsTrueWhenCategoryExists()
        {
            bool result = await categoryService.ExistsByNameAsync("Quilling card");

            Assert.IsTrue(result);
        }

        [Test]
        public async Task ExistsNameIdAsyncReturnsTrueWhenCategoryDoesNotExists()
        {
            bool result = await categoryService.ExistsByNameAsync("None existing category");

            Assert.IsFalse(result);
        }

        [Test]
        public async Task CreateAsyncWorksCorrectly()
        {
            CategoryFormModel formModel = new CategoryFormModel() { Name = "Test category" };
            await categoryService.CreateAsync(formModel);

            bool result = await categoryService.ExistsByNameAsync("Test category");
            
            Assert.IsTrue(result);
        }

        [Test]
        public async Task EditCategoryByIdAsyncWorksCorrectly()
        {
            CategoryFormModel formModel = new CategoryFormModel() { Name = "Test category" };

            await categoryService.EditCategoryByIdAsync("5", formModel);

            bool result = await categoryService.ExistsByNameAsync("Test category");
            
            Assert.IsTrue(result);
        }

        [Test]
        public async Task GetCategoryForEditByIdAsyncReturnsCorrectFormModel()
        {
            var productForDelete = await categoryService.GetCategoryForEditByIdAsync("1");

            Assert.That(productForDelete.Name, Is.EqualTo("Quilling card"));
        }
    }
}