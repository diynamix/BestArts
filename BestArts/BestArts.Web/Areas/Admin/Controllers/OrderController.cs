namespace BestArts.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class OrderController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
