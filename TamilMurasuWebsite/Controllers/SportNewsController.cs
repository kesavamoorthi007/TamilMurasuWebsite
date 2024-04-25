using Microsoft.AspNetCore.Mvc;

namespace TamilMurasuWebsite.Controllers
{
	public class SportNewsController : Controller
	{
		public IActionResult SportNews()
		{
			return View();
		}
	}
}
