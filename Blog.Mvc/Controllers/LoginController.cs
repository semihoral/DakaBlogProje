using Microsoft.AspNetCore.Mvc;

namespace DakaBlog.Mvc.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
