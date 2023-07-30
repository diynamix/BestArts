namespace BestArts.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using Infrastructure.Extensions;
    using Services.Data.Interfaces;
    using Services.Data.Models.Product;
    using ViewModels.Product;

    using static Common.GeneralApplicationConstants;
    using static Common.NotificationMessagesConstants;
    using Microsoft.CodeAnalysis.Differencing;

    public class ProductController : BaseController
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            this.productService = productService;
            this.categoryService = categoryService;

        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> All([FromQuery]AllProductsQueryModel queryModel)
        {
            AllProductsFilteredAndPagedServiceModel serviceModel = await productService.AllAsync(queryModel);

            queryModel.Products = serviceModel.Products;
            queryModel.TotalProducts = serviceModel.TotalProductsCount;
            queryModel.Categories = await categoryService.AllCategoryNamesAsync();

            return View(queryModel);
        }

        //[Authorize(Roles = AdminRoleName)]
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            if (!User.IsAdmin())
            {
                TempData[ErrorMessage] = "You cannot access this page!";

                return RedirectToAction("Index", "Home");
            }

            ProductFormModel model = new ProductFormModel()
            {
                Categories = await categoryService.AllCategoriesAsync(),
            };

            return View(model);
        }

        //[Authorize(Roles = AdminRoleName)]
        [HttpPost]
        public async Task<IActionResult> Add(ProductFormModel model)
        {
            if (!User.IsAdmin())
            {
                TempData[ErrorMessage] = "You cannot access this page!";

                return RedirectToAction("Index", "Home");
            }

            bool categoryExists = await categoryService.ExistsByIdAsync(model.CategoryId);

            if (!categoryExists)
            {
                ModelState.AddModelError(nameof(model.CategoryId), "Selected category does not exist!");
            }

            if (!ModelState.IsValid)
            {
                model.Categories = await categoryService.AllCategoriesAsync();

                return View(model);
            }

            try
            {
                await productService.CreateAsync(model);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Unexpected error occured while trying to add new product!");

                model.Categories = await categoryService.AllCategoriesAsync();

                return View(model);
            }

            return RedirectToAction("All", "Product");
        }

        //[Authorize(Roles = AdminRoleName)]
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            bool productExists = await productService.ExistsByIdAsync(id);

            if (!productExists)
            {
                TempData[ErrorMessage] = "The product does not exist!";

                return RedirectToAction("All", "Product");
            }

            if (!User.IsAdmin())
            {
                TempData[ErrorMessage] = "You cannot access this page!";

                return RedirectToAction("Index", "Home");
            }

            ProductFormModel formModel = await productService.GetProductForEditByIdAsync(id);

            formModel.Categories = await categoryService.AllCategoriesAsync();

            return View(formModel);
        }

        //[Authorize(Roles = AdminRoleName)]
        [HttpPost]
        public async Task<IActionResult> Edit(string id, ProductFormModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Categories = await categoryService.AllCategoriesAsync();

                return View(model);
            }

            bool productExists = await productService.ExistsByIdAsync(id);

            if (!productExists)
            {
                TempData[ErrorMessage] = "The product does not exist!";

                return RedirectToAction("All", "Product");
            }

            if (!User.IsAdmin())
            {
                TempData[ErrorMessage] = "You cannot access this page!";

                return RedirectToAction("Index", "Home");
            }

            try
            {
                await productService.EditProductByIdAsync(id, model);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Unexpected error occured while editing product!");

                model.Categories = await categoryService.AllCategoriesAsync();

                return View(model);
            }

            return RedirectToAction("Details", "Product", new { id });
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            bool productExists = await productService.ExistsByIdAsync(id);

            if (!productExists)
            {
                TempData[ErrorMessage] = "The product does not exist!";

                return RedirectToAction("All", "Product");
            }

            ProductDetailsViewModel viewModel = await productService.GetDetailsByIdAsync(id);

            return View(viewModel);
        }
    }
}
