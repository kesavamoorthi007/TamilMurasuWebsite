using Microsoft.AspNetCore.Mvc;
using System.Data;
using TamilMurasuWebsite.Interface;
using TamilMurasuWebsite.Models;
using TamilMurasuWebsite.Services;

namespace TamilMurasuWebsite.Controllers
{
	public class SportNewsController : Controller
	{
		ISportNewsService SportNewsService;
		IConfiguration? _configuratio;
		private string? _connectionString;
		public SportNewsController(ISportNewsService _SportNewsService, IConfiguration _configuratio)
		{
			SportNewsService = _SportNewsService;
			_connectionString = _configuratio.GetConnectionString("MySqlConnection");
		}
		public IActionResult SportNews()
		{
			SportNews br = new SportNews();

			List<SportNewsHead> TData = new List<SportNewsHead>();
			SportNewsHead tda = new SportNewsHead();

			DataTable dt1 = new DataTable();
			dt1 = SportNewsService.GetSportNews();
			for (int i = 0; i < dt1.Rows.Count; i++)
			{
				tda = new SportNewsHead();
				tda.News_head1 = dt1.Rows[i]["NT_Head"].ToString();
				tda.News_des = dt1.Rows[i]["N_Description"].ToString();
				tda.News_image = dt1.Rows[i]["S_Image"].ToString();
				tda.L_News_image = dt1.Rows[i]["L_Image"].ToString();
				tda.News_date = dt1.Rows[i]["AddedDateFormatted"].ToString();
				tda.N_id = dt1.Rows[i]["N_Id"].ToString();
				TData.Add(tda);

			}
			br.SportNewsHeadlst = TData;
			return View(br);
		}
		public IActionResult SportNewsDetails(string id)
		{
			SportNews br = new SportNews();

			List<SportNewsDetails> TData1 = new List<SportNewsDetails>();
			SportNewsDetails tda1 = new SportNewsDetails();

			DataTable dt2 = new DataTable();
			dt2 = SportNewsService.SportNewsDetails(id);
			for (int i = 0; i < dt2.Rows.Count; i++)
			{
				tda1 = new SportNewsDetails();
				tda1.News_head1_d = dt2.Rows[i]["NT_Head"].ToString();
				tda1.News_des_d = dt2.Rows[i]["N_Description"].ToString();
				tda1.News_image_d = dt2.Rows[i]["S_Image"].ToString();
				tda1.L_News_image = dt2.Rows[i]["L_Image"].ToString();
				tda1.News_date_d = dt2.Rows[i]["AddedDateFormatted"].ToString();
				tda1.N_id_d = dt2.Rows[i]["N_Id"].ToString();
				TData1.Add(tda1);

			}
			br.SportNewsDetailslst = TData1;
			return View(br);
		}
		public ActionResult ShowImage(string filename)
		{
			var file = filename;
			var ext = file.Split('.').Last();
			return File(file, "image/" + ext, Path.GetFileName(file));
		}

	}
}
