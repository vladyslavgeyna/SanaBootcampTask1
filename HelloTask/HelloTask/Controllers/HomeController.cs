using HelloTask.Models;
using HelloTask.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HelloTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
			return RedirectToAction("Hello");
        }

        public IActionResult Hello()
        {
            return View("HelloGet");
        }

		[HttpPost]
		public IActionResult Hello(HelloHomeViewModel helloHomeViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("HelloGet", helloHomeViewModel);
            }
            return View("HelloPost", helloHomeViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}