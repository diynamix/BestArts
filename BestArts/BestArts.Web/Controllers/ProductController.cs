﻿namespace BestArts.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    
    using Services.Data.Interfaces;
    using ViewModels.Product;

    public class ProductController : BaseController
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            IEnumerable<ProductAllViewModel> viewModel = await productService.GetAllAvailableProductsAsync();

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {

        }
    }
}
