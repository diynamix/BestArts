namespace BestArts.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using Infrastructure.Extensions;
    using Services.Data.Interfaces;
    using Services.Data.Models.Product;
    using ViewModels.Product;

    using static Common.NotificationMessagesConstants;

    public class ProductController : BaseController
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;
        private readonly IWishlistService wishlistService;

        public ProductController(IProductService productService,
            ICategoryService categoryService,
            IWishlistService wishlistService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
            this.wishlistService = wishlistService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> All([FromQuery] AllProductsQueryModel queryModel)
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

            try
            {
                ProductFormModel model = new ProductFormModel()
                {
                    Categories = await categoryService.AllCategoriesAsync(),
                };

                return View(model);
            }
            catch (Exception)
            {
                return GeneralError();
            }
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

            string productId;

            try
            {
                productId = await productService.CreateAsync(model);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Unexpected error occured while trying to add new product!");

                model.Categories = await categoryService.AllCategoriesAsync();

                return View(model);
            }

            return RedirectToAction("Details", "Product", new { id = productId });
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

            try
            {
                ProductFormModel formModel = await productService.GetProductForEditByIdAsync(id);

                formModel.Categories = await categoryService.AllCategoriesAsync();

                return View(formModel);
            }
            catch (Exception)
            {
                return GeneralError();
            }
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

        //[Authorize(Roles = AdminRoleName)]
        [HttpGet]
        public async Task<IActionResult> Delete(string id)
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

            try
            {
                ProductSoftDeleteViewModel model = await productService.GetProductForSoftDeleteByIdAsync(id);

                return View(model);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        //[Authorize(Roles = AdminRoleName)]
        [HttpPost]
        public async Task<IActionResult> Delete(string id, ProductSoftDeleteViewModel model)
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

            try
            {
                await productService.DeleteProductByIdAsync(id);

                TempData[WarningMessage] = "Product was successfully deleted!";

                return RedirectToAction("All", "Product", new
                {
                    currentPage = TempData.Peek("CurrentPage"),
                    categorySort = TempData.Peek("Category"),
                    searchString = TempData.Peek("SearchString"),
                    productSorting = (int)TempData.Peek("ProductSorting")
                });
            }
            catch (Exception)
            {
                return GeneralError();
            }
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

            try
            {
                ProductDetailsViewModel viewModel = await productService.GetDetailsByIdAsync(id);

                return View(viewModel);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> AddToWishlist(string userid, string productId)
        {
            if (User?.Identity?.IsAuthenticated == false)
            {
                TempData[ErrorMessage] = "You need to login first!";

                return RedirectToAction("Login", "User");
            }

            bool productExists = await productService.ExistsByIdAsync(productId);

            if (!productExists)
            {
                TempData[ErrorMessage] = "The product does not exist!";

                return RedirectToAction("All", "Product");
            }

            bool alreadyAdded = await wishlistService.IsAlreadyAddedAsync(userid, productId);

            if (alreadyAdded)
            {
                TempData[ErrorMessage] = "This product is already added to your wishlist!";

                return RedirectToAction("All", "Product");
            }

            try
            {
                await productService.AddProductToWishlistAsync(userid, productId);

                TempData[SuccessMessage] = "Product added to wishlist!";
            }
            catch (Exception)
            {
                return GeneralError();
            }

            return RedirectToAction("All", TempData["ReturnPage"]?.ToString() ?? "Product", new
            {
                currentPage = TempData.Peek("CurrentPage"),
                categorySort = TempData.Peek("Category"),
                searchString = TempData.Peek("SearchString"),
                productSorting = (int)TempData.Peek("ProductSorting")
            });
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromWishlist(string userid, string productId, string? wishlist)
        {
            bool productExists = await productService.ExistsByIdAsync(productId);

            if (!productExists)
            {
                TempData[ErrorMessage] = "The product does not exist!";

                return RedirectToAction("All", "Product");
            }

            bool alreadyAdded = await wishlistService.IsAlreadyAddedAsync(userid, productId);

            if (!alreadyAdded)
            {
                TempData[ErrorMessage] = "This product is not added to your wishlist!";

                return RedirectToAction("All", "Product");
            }

            try
            {
                await productService.RemoveProductFromWishlistAsync(userid, productId);

                TempData[WarningMessage] = "Product removed from wishlist!";
            }
            catch (Exception)
            {
                return GeneralError();
            }

            return RedirectToAction("All", TempData["ReturnPage"]?.ToString() ?? "Product", new
            {
                currentPage = TempData.Peek("CurrentPage"),
                categorySort = TempData.Peek("Category"),
                searchString = TempData.Peek("SearchString"),
                productSorting = (int)TempData.Peek("ProductSorting")
            });
        }

        private IActionResult GeneralError()
        {
            TempData[ErrorMessage] = "Unexpected error occurred!";

            return RedirectToAction("All", "Product");
        }
    }
}
