namespace BestArts.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using Infrastructure.Extensions;
    using ViewModels.Category;
    using Services.Data.Interfaces;

    using static Common.NotificationMessagesConstants;
    using BestArts.Services.Data;
    using BestArts.Web.ViewModels.Product;

    public class CategoryController : BaseController
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public async Task<IActionResult> All()
        {
            IEnumerable<AllCategoriesViewModel> viewModel = await categoryService.AllCategoriesAsync();
            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            bool categoryExists = await categoryService.ExistsByIdAsync(int.Parse(id));

            if (!categoryExists)
            {
                TempData[ErrorMessage] = "The category does not exist!";

                return RedirectToAction("All", "Product");
            }

            if (!User.IsAdmin())
            {
                TempData[ErrorMessage] = "You cannot access this page!";
                return RedirectToAction("Index", "Home");
            }

            try
            {
                CategoryFormModel formModel = await categoryService.GetCategoryForEditByIdAsync(id);

                return View(formModel);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, CategoryFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            bool categoryExists = await categoryService.ExistsByIdAsync(int.Parse(id));

            if (!categoryExists)
            {
                TempData[ErrorMessage] = "The category does not exist!";

                return RedirectToAction("All", "Product");
            }

            if (!User.IsAdmin())
            {
                TempData[ErrorMessage] = "You cannot access this page!";

                return RedirectToAction("Index", "Home");
            }

            try
            {
                await categoryService.EditCategoryByIdAsync(id, model);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Unexpected error occured while editing category!");

                return View(model);
            }

            return RedirectToAction("All", "Category");
        }

        private IActionResult GeneralError()
        {
            TempData[ErrorMessage] = "Unexpected error occurred!";

            return RedirectToAction("All", "Product");
        }
    }
}
