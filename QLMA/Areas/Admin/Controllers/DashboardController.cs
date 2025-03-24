using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace QLMA.Areas.Admin.Controllers
{
    [Area("Admin")]//  Chỉ Admin mới truy cập được
    //[Authorize(Roles = "Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LoadPartial(string viewName)
        {
            return PartialView($"~/Areas/Admin/Views/Shared/{viewName}.cshtml");
        }
    }
}
