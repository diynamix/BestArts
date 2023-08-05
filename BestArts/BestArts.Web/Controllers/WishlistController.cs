namespace BestArts.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    
    using Services.Data.Models.Product;
    using Services.Data.Interfaces;
    using ViewModels.Product;
    using BestArts.Web.Infrastructure.Extensions;

    public class WishlistController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IWishlistService wishlistService;

        public WishlistController(ICategoryService categoryService,
            IWishlistService wishlistService)
        {
            this.categoryService = categoryService;
            this.wishlistService = wishlistService;
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery] AllProductsQueryModel queryModel)
        {
            AllProductsFilteredAndPagedServiceModel serviceModel = await wishlistService.AllAsync(queryModel, User.GetId()!);

            queryModel.Products = serviceModel.Products;
            queryModel.TotalProducts = serviceModel.TotalProductsCount;
            queryModel.Categories = await categoryService.AllCategoryNamesAsync();

            return View(queryModel);
        }
    }
}
