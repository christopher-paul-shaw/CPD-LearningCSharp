using Microsoft.AspNetCore.Mvc;
using testProgram004.Data;
namespace testProgram004.Controllers
{
	public class AppController : Controller
    {
		
		private readonly DatabaseContext _context;

		public AppController (DatabaseContext context) {
			_context = context;
		}
		
		public IActionResult Index() {
			var results = _context.Customer;
			return View(results.ToList());
		}
		public IActionResult Page2() {
			return View();
		}
    }
}