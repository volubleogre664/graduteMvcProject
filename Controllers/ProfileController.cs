using Microsoft.AspNetCore.Mvc;
using FirstMVCProject.Models;
using FirstMVCProject.Data;
using System.Collections.Generic;
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

        public IActionResult AddUser()
        {
            var data = HttpContext.Request.Form;

            _context.AddRange(new ProfileViewModel()
            {
                Name = data["firstname"],
                Surname = data["lastname"],
                DOB = Convert.ToDateTime(data["dob"]),
                Age = int.Parse(data["age"]),
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
            {
                return NotFound();
            }

            return View(userProfile);
        }

        public IActionResult EditSelectedUser()
        {
            var data = HttpContext.Request.Form;

            var editedProfile = new ProfileViewModel()
            {
                ID = int.Parse(data["id"]),
                Name = data["firstname"],
                Surname = data["lastname"],
                DOB = Convert.ToDateTime(data["dob"]),
                Age = int.Parse(data["age"]),
                Country = data["country"],
                City = data["city"]
            };

            _context.UserProfiles.Update(editedProfile);
            _context.SaveChanges();

            return new RedirectResult("/Profile");
        }
    }
}
