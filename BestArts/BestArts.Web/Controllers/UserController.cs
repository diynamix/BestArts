﻿namespace BestArts.Web.Controllers
{
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Caching.Memory;

    using Data.Models;
    using Infrastructure.Extensions;
    using Services.Data.Interfaces;
    using ViewModels.User;

    using static Common.GeneralApplicationConstants;
    using static Common.NotificationMessagesConstants;

    public class UserController : BaseController
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;

        private readonly IMemoryCache memoryCache;

        private readonly IOrderService orderService;

        public UserController(SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager,
            IMemoryCache memoryCache,
            IOrderService orderService)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;

            this.memoryCache = memoryCache;

            this.orderService = orderService;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("All", "Product");
            }

            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            ApplicationUser user = new ApplicationUser()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
            };

            await userManager.SetEmailAsync(user, model.Email);
            await userManager.SetUserNameAsync(user, model.Email);

            IdentityResult result = await userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

                return View(model);
            }

            await signInManager.SignInAsync(user, false);

            memoryCache.Remove(UsersCacheKey);

            return RedirectToAction("All", "Product");
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Login(string? returnUrl = null)
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Home");
            }

            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            LoginFormModel model = new LoginFormModel()
            {
                ReturnUrl = returnUrl,
            };

            //if (!string.IsNullOrEmpty(ErrorMessage))
            //{
            //    ModelState.AddModelError(string.Empty, ErrorMessage);
            //}

            //returnUrl ??= Url.Content("~/");

            return View(model);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

            if (!result.Succeeded)
            {
                TempData[ErrorMessage] = "An error occured while login. Please try again!";

                return View(model);
            }

            //return Redirect(model.ReturnUrl ?? "/Home/Index");
            return RedirectToAction("All", "Product");

        }

        public async Task<IActionResult> Account()
        {
            var userOrders = await orderService.GetAllOrdersByUserIdAsync(User.GetId()!);

            return View(userOrders);
        }
    }
}