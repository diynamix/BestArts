namespace BestArts.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using Services.Data.Interfaces;
    using ViewModels.Product;

    using static Common.GeneralApplicationConstants;
    using static Common.NotificationMessagesConstants;

    public class ProductController : BaseAdminController
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;

        public ProductController(IProductService productService,
            ICategoryService categoryService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            try
            {
                ProductFormModel model = new ProductFormModel()
                {
                    Categories = await categoryService.AllCategoriesForProductSelectFormModelAsync(),
                };

                return View(model);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductFormModel model)
        {
            bool categoryExists = await categoryService.ExistsByIdAsync(model.CategoryId);

            if (!categoryExists)
            {
                ModelState.AddModelError(nameof(model.CategoryId), "Selected category does not exist!");
            }

            if (!ModelState.IsValid)
            {
                model.Categories = await categoryService.AllCategoriesForProductSelectFormModelAsync();

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

                model.Categories = await categoryService.AllCategoriesForProductSelectFormModelAsync();

                return View(model);
            }

            return RedirectToAction("Details", "Product", new { id = productId, Area = string.Empty });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            bool productExists = await productService.ExistsByIdAsync(id);

            if (!productExists)
            {
                TempData[ErrorMessage] = "The product does not exist!";

                return RedirectToAction("All", "Product", new { Area = string.Empty });
            }

            try
            {
                ProductFormModel formModel = await productService.GetProductForEditByIdAsync(id);

                formModel.Categories = await categoryService.AllCategoriesForProductSelectFormModelAsync();

                return View(formModel);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, ProductFormModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Categories = await categoryService.AllCategoriesForProductSelectFormModelAsync();

                return View(model);
            }

            bool productExists = await productService.ExistsByIdAsync(id);

            if (!productExists)
            {
                TempData[ErrorMessage] = "The product does not exist!";

                return RedirectToAction("All", "Product", new { Area = string.Empty });
            }

            try
            {
                await productService.EditProductByIdAsync(id, model);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Unexpected error occured while editing product!");

                model.Categories = await categoryService.AllCategoriesForProductSelectFormModelAsync();

                return View(model);
            }

            return RedirectToAction("Details", "Product", new { id, Area = string.Empty });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            bool productExists = await productService.ExistsByIdAsync(id);

            if (!productExists)
            {
                TempData[ErrorMessage] = "The product does not exist!";

                return RedirectToAction("All", "Product", new { Area = string.Empty });
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

        [HttpPost]
        public async Task<IActionResult> Delete(string id, ProductSoftDeleteViewModel model)
        {
            bool productExists = await productService.ExistsByIdAsync(id);

            if (!productExists)
            {
                TempData[ErrorMessage] = "The product does not exist!";

                return RedirectToAction("All", "Product", new { Area = string.Empty });
            }

            try
            {
                await productService.DeleteProductByIdAsync(id);

                TempData[WarningMessage] = "Product was successfully deleted!";

                return RedirectToAction("All", "Product", new
                {
                    Area = string.Empty,
                    currentPage = TempData.Peek("CurrentPage"),
                    categorySort = TempData.Peek("CategorySort"),
                    searchString = TempData.Peek("SearchString"),
                    productSorting = (int)TempData.Peek("ProductSorting")
                });
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        private IActionResult GeneralError()
        {
            TempData[ErrorMessage] = "Unexpected error occurred!";

            return RedirectToAction("All", "Product", new { Area = string.Empty });
        }
    }
}
