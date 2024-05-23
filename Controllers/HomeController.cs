using Microsoft.AspNetCore.Mvc;
using StudentPortal.Models;
using System.Diagnostics;

namespace StudentPortal.Controllers
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

		public IActionResult SetSession()
		{
			HttpContext.Session.SetString("UserName", "Ali Veli");
			HttpContext.Session.SetInt32("UserAge", 30);
			return RedirectToAction("GetSession");
		}

		public IActionResult GetSession()
		{
			var userName = HttpContext.Session.GetString("UserName");
			var userAge = HttpContext.Session.GetInt32("UserAge");

			ViewBag.UserName = userName;
			ViewBag.UserAge = userAge;

			return View();
		}
	}
}
