using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using TamilMurasuWebsite.Interface;
using TamilMurasuWebsite.Models;

namespace TamilMurasuWebsite.Controllers
{
    public class HomeDeatilsController : Controller
    {
		IHomeDeatilsService HomeDeatilsService;
		IConfiguration? _configuratio;
		private string? _connectionString;
		public HomeDeatilsController(IHomeDeatilsService _HomeDeatilsService, IConfiguration _configuratio)
		{
			HomeDeatilsService = _HomeDeatilsService;
			_connectionString = _configuratio.GetConnectionString("MySqlConnection");
		}
		public IActionResult HomeDeatils(string id)
        {
			HomeDeatils br = new HomeDeatils();
			
			DataTable dt = new DataTable();
			dt = HomeDeatilsService.GetHomeDeatils();
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				br.News_head1 = dt.Rows[i]["News_head"].ToString();

			}
			return View(br);
        }
    }
}
