namespace BestArts.Web.Controllers
{
    using BestArts.Services.Data;
    using BestArts.Web.Infrastructure.Extensions;
    using BestArts.Web.ViewModels.Product;
    using Microsoft.AspNetCore.Mvc;

    using Services.Data.Interfaces;
    using ViewModels.Cart;

    using static Common.NotificationMessagesConstants;

    public class CartController : BaseController
    {
        private readonly ICartService cartService;
        private readonly IProductService productService;

        public CartController(IProductService productService,
            ICartService cartService)
        {
            this.productService = productService;
            this.cartService = cartService;
        }

        public async Task<IActionResult> All()
        {
            IEnumerable<AllCartsViewModel> viewModel = await cartService.AllCartsAsync(User.GetId()!);

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(string userid, string productId)
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

            bool alreadyAdded = await cartService.IsAlreadyAddedAsync(userid, productId);

            if (alreadyAdded)
            {
                TempData[ErrorMessage] = "This product is already added to your wishlist!";

                return RedirectToAction("All", "Product");
            }

            try
            {
                await cartService.AddProductToCartAsync(userid, productId);

                await productService.RemoveProductFromWishlistAsync(userid, productId);

                TempData[SuccessMessage] = "Product added to wishlist!";
            }
            catch (Exception)
            {
                return GeneralError();
            }

            return RedirectToAction("All", "Wishlist", new
            {
                currentPage = TempData.Peek("CurrentPage"),
                categorySort = TempData.Peek("Category"),
                searchString = TempData.Peek("SearchString"),
                productSorting = (int)TempData.Peek("ProductSorting")
            });
        }

        //[HttpGet]
        //public async Task<IActionResult> Delete(string userid, string productId)
        //{
        //    bool productExists = await productService.ExistsByIdAsync(productId);

        //    if (!productExists)
        //    {
        //        TempData[ErrorMessage] = "The product does not exist!";
        //        return RedirectToAction("All", "Product");
        //    }

        //    bool alreadyAdded = await cartService.IsAlreadyAddedAsync(userid, productId);

        //    if (!alreadyAdded)
        //    {
        //        TempData[ErrorMessage] = "This product is not added to your wishlist!";

        //        return RedirectToAction("All", "Product");
        //    }

        //    try
        //    {
        //        DeleteCartProductViewModel model = await cartService.GetProductForDeletingFromCartAsync(userid, productId);

        //        return View(model);
        //    }
        //    catch (Exception)
        //    {
        //        return GeneralError();
        //    }
        //}

        [HttpPost]
        public async Task<IActionResult> RemoveFromCart(string userid, string productId)
        {
            bool productExists = await productService.ExistsByIdAsync(productId);

            if (!productExists)
            {
                TempData[ErrorMessage] = "The product does not exist!";
                return RedirectToAction("All", "Product");
            }

            bool alreadyAdded = await cartService.IsAlreadyAddedAsync(userid, productId);

            if (!alreadyAdded)
            {
                TempData[ErrorMessage] = "This product is not added to your wishlist!";

                return RedirectToAction("All", "Product");
            }

            try
            {
                await cartService.RemoveProductFromCartAsync(userid, productId);

                TempData[WarningMessage] = "Product removed from wishlist!";
            }
            catch (Exception)
            {
                return GeneralError();
            }

            return RedirectToAction("All", "Cart");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCart(string userId, string productId, AllCartsViewModel model)
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
                return RedirectToAction("All", "Cart");
            }

            bool alreadyAdded = await cartService.IsAlreadyAddedAsync(userId, productId);

            if (!alreadyAdded)
            {
                TempData[ErrorMessage] = "This product is not added to your wishlist yet!";

                return RedirectToAction("All", "Cart");
            }

            if (!ModelState.IsValid)
            {
                TempData[ErrorMessage] = "Invalid quantity entered!";

                return RedirectToAction("All", "Cart");
            }

            try
            {
                await cartService.UpdateProductQuantityAsync(userId, productId, model);

                TempData[SuccessMessage] = "Product updated!";
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Unexpected error occured while updating product quantity!");

                return RedirectToAction("All", "Cart");
            }

            return RedirectToAction("All", "Cart");
        }

        private IActionResult GeneralError()
        {
            TempData[ErrorMessage] = "Unexpected error occurred!";

            return RedirectToAction("All", "Cart");
        }
    }
}
