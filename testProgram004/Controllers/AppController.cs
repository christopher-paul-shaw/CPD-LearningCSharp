using Microsoft.AspNetCore.Mvc;

namespace testProgram004.Controllers
{
	public class AppController : Controller
    {
		public IActionResult Index() {
			return View();
		}

		public IActionResult Page2() {
			return View();
		}
    }
}