using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using TamilMurasuWebsite.Interface;
using TamilMurasuWebsite.Models;
using TamilMurasuWebsite.Services;

namespace TamilMurasuWebsite.Controllers
{
	public class NewsDeatilController : Controller
	{
		INewsDeatilService NewsDeatilService;
		IConfiguration? _configuratio;
		private string? _connectionString;
		public NewsDeatilController(INewsDeatilService _NewsDeatilService, IConfiguration _configuratio)
		{
			NewsDeatilService = _NewsDeatilService;
			_connectionString = _configuratio.GetConnectionString("MySqlConnection");
		}
		public IActionResult NewsDeatil()
		{
			NewsDeatil br = new NewsDeatil();

			DataTable dt1 = new DataTable();
			dt1 = NewsDeatilService.GetNewsDeatils();
			for (int i = 0; i < dt1.Rows.Count; i++)
			{
				br.News_head1 = dt1.Rows[i]["NT_Head"].ToString();
				br.News_des = dt1.Rows[i]["N_Description"].ToString();
				br.News_image = dt1.Rows[i]["S_Image"].ToString();
				br.News_date = dt1.Rows[i]["AddedDateFormatted"].ToString();

			}
			return View(br);
		}
	}
}
