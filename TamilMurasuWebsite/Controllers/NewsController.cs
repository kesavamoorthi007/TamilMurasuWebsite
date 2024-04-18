using Microsoft.AspNetCore.Mvc;

namespace TamilMurasuWebsite.Controllers
{
	public class NewsController : Controller
	{
		public IActionResult News()
		{
			return View();
		}
	}
}
