﻿namespace BestArts.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using ViewModels.Category;
    using Services.Data.Interfaces;

    using static Common.NotificationMessagesConstants;
    using static Common.GeneralApplicationConstants;

    public class CategoryController : BaseAdminController
    {

        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            IEnumerable<AllCategoriesViewModel> viewModel = await categoryService.AllCategoriesAsync();

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Add()
        {
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

            return RedirectToAction("All", "Category", new { Area = AdminAreaName });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            bool categoryExists = await categoryService.ExistsByIdAsync(int.Parse(id));

            if (!categoryExists)
            {
                TempData[ErrorMessage] = "The category does not exist!";

                return RedirectToAction("All", "Category", new { Area = AdminAreaName });
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

                return RedirectToAction("All", "Category", new { Area = AdminAreaName });
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

            return RedirectToAction("All", "Category", new { Area = AdminAreaName });
        }

        private IActionResult GeneralError()
        {
            TempData[ErrorMessage] = "Unexpected error occurred!";

            return RedirectToAction("All", "Category", new { Area = AdminAreaName });
        }
    }
}
