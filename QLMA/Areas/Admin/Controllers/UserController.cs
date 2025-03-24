using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QLMA.Models;

namespace QLMA.Areas.Admin.Controllers

{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly QLMAContext _context;
        public UserController(QLMAContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var users = await (_context.NguoiCanHoTros?.ToListAsync() ?? Task.FromResult(new List<NguoiCanHoTro>()));
            return View(users);
        }
    }
}
