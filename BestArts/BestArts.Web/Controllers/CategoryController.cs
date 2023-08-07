namespace BestArts.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using Infrastructure.Extensions;
    using ViewModels.Category;
    using Services.Data.Interfaces;

    using static Common.NotificationMessagesConstants;

    public class CategoryController : BaseController
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            if (!User.IsAdmin())
            {
                TempData[ErrorMessage] = "You cannot access this page!";

                return RedirectToAction("All", "Product");
            }

            IEnumerable<AllCategoriesViewModel> viewModel = await categoryService.AllCategoriesAsync();

            return View(viewModel);
        }

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
                CategoryFormModel model = new CategoryFormModel();

                return View(model);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryFormModel model)
        {
            if (!User.IsAdmin())
            {
                TempData[ErrorMessage] = "You cannot access this page!";

                return RedirectToAction("Index", "Home");
            }

            bool categoryExists = await categoryService.ExistsByNameAsync(model.Name);

            if (categoryExists)
            {
                ModelState.AddModelError(nameof(model.Name), "This category is already added!");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await categoryService.CreateAsync(model);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Unexpected error occured while trying to add new category!");

                return View(model);
            }

            return RedirectToAction("All", "Category");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            if (!User.IsAdmin())
            {
                TempData[ErrorMessage] = "You cannot access this page!";
                return RedirectToAction("Index", "Home");
            }

            bool categoryExists = await categoryService.ExistsByIdAsync(int.Parse(id));

            if (!categoryExists)
            {
                TempData[ErrorMessage] = "The category does not exist!";

                return RedirectToAction("All", "Product");
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
            if (!User.IsAdmin())
            {
                TempData[ErrorMessage] = "You cannot access this page!";

                return RedirectToAction("Index", "Home");
            }

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
