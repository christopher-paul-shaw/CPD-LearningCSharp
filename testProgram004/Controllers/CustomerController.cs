using Microsoft.AspNetCore.Mvc;
using testProgram004.Data;
namespace testProgram004.Controllers
{
	public class CustomerController : Controller
    {
		
		private readonly DatabaseContext _context;

		public CustomerController (DatabaseContext context) {
			_context = context;
		}
		
		public IActionResult Index() {
			Console.WriteLine("CHRIS");
			var results = _context.Customer;
			return View(results.ToList());
		}
		public IActionResult Show(int id) {
	
			return View();
		}
    }
}