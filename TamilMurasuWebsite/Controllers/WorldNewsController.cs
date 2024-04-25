using Microsoft.AspNetCore.Mvc;

namespace TamilMurasuWebsite.Controllers
{
	public class WorldNewsController : Controller
	{
		public IActionResult WorldNews()
		{
			return View();
		}
	}
}
