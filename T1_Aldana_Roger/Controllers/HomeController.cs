using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using T1_Aldana_Roger.Models;

namespace T1_Aldana_Roger.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Alicorp()
        {
            return View();
        }

        public IActionResult Sysco()
        {
            return View();
        }

        public IActionResult IngramMicro()
        {
            return View();
        }
    }
}