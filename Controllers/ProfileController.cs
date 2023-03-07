using Microsoft.AspNetCore.Mvc;
using FirstMVCProject.Models;

namespace FirstMVCProject.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ProfileViewModel("Nduduzo", "Shabalala", DateTime.Now, 32, "Russia", "Moscow");

            return View(profile);
        }
    }
}
