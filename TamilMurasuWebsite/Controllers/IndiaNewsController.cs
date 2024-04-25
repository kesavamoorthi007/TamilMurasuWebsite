using Microsoft.AspNetCore.Mvc;

namespace TamilMurasuWebsite.Controllers
{
	public class IndiaNewsController : Controller
	{
		public IActionResult IndiaNews()
		{
			return View();
		}
	}
}
