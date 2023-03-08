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
            return View(await _context.UserProfiles.ToListAsync());
        }

        public IActionResult AddUser()
        {
            var data = HttpContext.Request.Form;

            _context.AddRange(new ProfileModel()
            {
                Name = data["firstname"],
                Surname = data["lastname"],
                DOB = Convert.ToDateTime(data["dob"]),
                Age = int.TryParse(data["age"], out int output) ? output : 0,
                Country = data["country"],
                City = data["city"]
            });

            _context.SaveChanges();

            return new RedirectResult($"/Profile");
        }

        public async Task<IActionResult> EditUser(int? id)
        {
            var userProfile = await _context.UserProfiles.FindAsync(id);

            if (userProfile == null)
                return NotFound();

            return View(userProfile);
        }

        public IActionResult EditSelectedUser()
        {
            var data = HttpContext.Request.Form;

            if (data == null)
                return NotFound();

            var editedProfile = new ProfileModel()
            {
                ID = int.TryParse(data["id"], out int output) ? output : 0,
                Name = data["firstname"],
                Surname = data["lastname"],
                DOB = Convert.ToDateTime(data["dob"]),
                Age = int.TryParse(data["age"], out output) ? output : 0,
                Country = data["country"],
                City = data["city"]
            };

            _context.UserProfiles.Update(editedProfile);
            _context.SaveChanges();

            return new RedirectResult("/Profile");
        }

        public IActionResult DeleteUser(int id)
        {
            var profile = _context.UserProfiles.Find(id);

            if (profile == null)
                return NotFound();

            _context.UserProfiles.Remove(profile);
            _context.SaveChanges();

            return new RedirectResult("/Profile");
        }
    }
}
