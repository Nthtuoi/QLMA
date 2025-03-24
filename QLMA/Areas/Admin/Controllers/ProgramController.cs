using Microsoft.AspNetCore.Mvc;

namespace QLMA.Areas.Admin.Controllers
{
    public class ProgramController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
