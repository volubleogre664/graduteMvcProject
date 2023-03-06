using FirstMVCProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstMVCProject.Controllers
{
    public class NduduzoController : Controller
    {
        private readonly ILogger<NduduzoController> _logger;

        public NduduzoController(ILogger<NduduzoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}