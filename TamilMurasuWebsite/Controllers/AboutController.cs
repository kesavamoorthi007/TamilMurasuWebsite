using Microsoft.AspNetCore.Mvc;

namespace TamilMurasuWebsite.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult About()
		{
			return View();
		}
	}
}
