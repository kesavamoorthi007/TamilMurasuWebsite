using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using System.Data;
using TamilMurasuWebsite.Interface;
using TamilMurasuWebsite.Models;
using TamilMurasuWebsite.Services;

namespace TamilMurasuWebsite.Controllers
{
	public class SportHeadNewsController : Controller
	{
		ISportHeadNewsService SportHeadNewsService;
		IConfiguration? _configuratio;
		private string? _connectionString;
		public SportHeadNewsController(ISportHeadNewsService _SportHeadNewsService, IConfiguration _configuratio)
		{
			SportHeadNewsService = _SportHeadNewsService;
			_connectionString = _configuratio.GetConnectionString("MySqlConnection");
		}
		public IActionResult SportHeadNews(string id)
		{
			SportHeadNews br = new SportHeadNews();

			List<SportHead> TData = new List<SportHead>();
			SportHead tda = new SportHead();

			DataTable dt1 = new DataTable();
			dt1 = SportHeadNewsService.GetSportHeadNews(id);
			for (int i = 0; i < dt1.Rows.Count; i++)
			{
				tda = new SportHead();
				tda.News_head1_s = dt1.Rows[i]["NT_Head"].ToString();
				tda.News_des_s = dt1.Rows[i]["N_Description"].ToString();
				tda.News_image_s = dt1.Rows[i]["S_Image"].ToString();
				tda.News_date_s = dt1.Rows[i]["AddedDateFormatted"].ToString();
				tda.N_id = dt1.Rows[i]["N_Id"].ToString();
				TData.Add(tda);


			}
			br.SportHeadlst = TData;
			return View(br);
		}
		
	}
}
