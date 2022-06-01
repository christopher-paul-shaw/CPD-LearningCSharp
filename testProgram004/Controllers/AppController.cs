using Microsoft.AspNetCore.Mvc;
//using testProgram004.Data;
namespace testProgram004.Controllers
{
	public class AppController : Controller
    {
		/*
		private readonly Context _context;

		public AppController (Context context) {
			_context = context;
		}
		*/
		public IActionResult Index() {
		
			return View();
		}
		public IActionResult Page2() {
			return View();
		}
    }
}