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
            if ((TempData["ProductsLeftOnPage"] != null) &&
                ((int)TempData["ProductsLeftOnPage"] == 1))
            {
                queryModel.CurrentPage
                    = queryModel.CurrentPage <= 1
                    ? 1
                    : queryModel.CurrentPage - 1;
            }

            AllProductsFilteredAndPagedServiceModel serviceModel = await productService.AllAsync(queryModel);

            queryModel.Products = serviceModel.Products;
            queryModel.TotalProducts = serviceModel.TotalProductsCount;
            queryModel.Categories = await categoryService.AllCategoryNamesAsync();

            return View(queryModel);
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

            return RedirectToAction("All", "Product", new
            {
                currentPage = TempData.Peek("CurrentPage"),
                categorySort = TempData.Peek("CategorySort"),
                searchString = TempData.Peek("SearchString"),
                productSorting = (int)TempData.Peek("ProductSorting")
            });
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromWishlist(string userid, string productId)
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

            await Console.Out.WriteLineAsync(TempData.Peek("ReturnPage")?.ToString());

            return RedirectToAction("All", TempData["ReturnPage"]?.ToString() ?? "Product", new
            {
                currentPage = TempData.Peek("CurrentPage"),
                categorySort = TempData.Peek("CategorySort"),
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
