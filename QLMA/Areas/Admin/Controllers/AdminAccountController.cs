using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QLMA.Models;

namespace QLMA.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminAccountController : Controller
    {
        private readonly SignInManager<ADMIN> _signInManager;

        public AdminAccountController(SignInManager<ADMIN> signInManager)
        {
            _signInManager = signInManager;
        }
        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            var result = await _signInManager.PasswordSignInAsync(email, password, false, false);
            if (result.Succeeded)
                return RedirectToAction("Index", "Dashboard", new { area = "Admin" });

            ViewBag.Error = "Đăng nhập thất bại";
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
