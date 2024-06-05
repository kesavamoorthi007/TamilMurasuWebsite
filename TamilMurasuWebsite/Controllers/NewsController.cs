using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using System.Data;
using TamilMurasuWebsite.Interface;
using TamilMurasuWebsite.Models;
using TamilMurasuWebsite.Services;

namespace TamilMurasuWebsite.Controllers
{
	public class NewsController : Controller
	{
		INewsService NewsService;
		IConfiguration? _configuratio;
		private string? _connectionString;
		public NewsController(INewsService _NewsService, IConfiguration _configuratio)
		{
			NewsService = _NewsService;
			_connectionString = _configuratio.GetConnectionString("MySqlConnection");
		}
		public IActionResult News(string id)
		{
			News br = new News();

			List<NewsHead> TData = new List<NewsHead>();
			NewsHead tda = new NewsHead();

			DataTable dt1 = new DataTable();
			dt1 = NewsService.GetNews(id);
			for (int i = 0; i < dt1.Rows.Count; i++)
			{
				tda = new NewsHead();
				tda.News_head1_N = dt1.Rows[i]["NT_Head"].ToString();
				tda.News_des_N = dt1.Rows[i]["N_Description"].ToString();
				tda.News_image_N = dt1.Rows[i]["L_Image"].ToString();
				tda.News_date_N = dt1.Rows[i]["AddedDateFormatted"].ToString();
				tda.N_id = dt1.Rows[i]["N_Id"].ToString();
				TData.Add(tda);


			}
			br.NewsHeadlst = TData;
			return View(br);
		}
	}
}
