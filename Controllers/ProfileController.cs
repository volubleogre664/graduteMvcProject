using Microsoft.AspNetCore.Mvc;
using FirstMVCProject.Models;
using FirstMVCProject.Data;
using Microsoft.EntityFrameworkCore;

namespace FirstMVCProject.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ProfileContext _context;

        public ProfileController(ProfileContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            /*var profile = new ProfileViewModel("Nduduzo", "Shabalala", DateTime.Now, 32, "Russia", "Moscow");*/

            return View(await _context.UserProfiles.ToListAsync());
        }
    }
}
