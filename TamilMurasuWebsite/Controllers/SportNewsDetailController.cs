using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using TamilMurasuWebsite.Interface;
using TamilMurasuWebsite.Models;
using TamilMurasuWebsite.Services;

namespace TamilMurasuWebsite.Controllers
{
	public class SportNewsDetailController : Controller
	{
		ISportNewsDetailService SportNewsDetailService;
		IConfiguration? _configuratio;
		private string? _connectionString;
		public SportNewsDetailController(ISportNewsDetailService _SportNewsDetailService, IConfiguration _configuratio)
		{
			SportNewsDetailService = _SportNewsDetailService;
			_connectionString = _configuratio.GetConnectionString("MySqlConnection");
		}
		public IActionResult SportNewsDetail()
		{
			SportNewsDetail br = new SportNewsDetail();

			DataTable dt2 = new DataTable();
			dt2 = SportNewsDetailService.GetSportNewsDeatils();
			for (int i = 0; i < dt2.Rows.Count; i++)
			{
				br.News_head1 = dt2.Rows[i]["NT_Head"].ToString();
				br.News_des = dt2.Rows[i]["N_Description"].ToString();
				br.News_image = dt2.Rows[i]["S_Image"].ToString();
				br.News_date = dt2.Rows[i]["AddedDateFormatted"].ToString();

			}

			return View(br);
		}
	}
}
