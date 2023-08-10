namespace BestArts.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Caching.Memory;

    using Services.Data.Interfaces;
    using Web.ViewModels.User;

    using static Common.GeneralApplicationConstants;

    public class UserController : BaseAdminController
    {
        private readonly IUserService userService;
        private readonly IMemoryCache memoryCache;

        public UserController(IUserService userService,
            IMemoryCache memoryCache)
        {
            this.userService = userService;
            this.memoryCache = memoryCache;
        }

        public async Task<IActionResult> All()
        {
            IEnumerable<UserViewModel> users = memoryCache.Get<IEnumerable<UserViewModel>>(UsersCacheKey);

            if (users == null)
            {
                users = await userService.AllAsync();

                MemoryCacheEntryOptions cacheOptions = new MemoryCacheEntryOptions().
                    SetAbsoluteExpiration(TimeSpan.FromMinutes(UsersCacheDurationMinutes));

                memoryCache.Set(UsersCacheKey, users, cacheOptions);
            }

            return View(users);
        }
    }
}
