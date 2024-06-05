using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
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

			List<LatestNews> TData = new List<LatestNews>();
			LatestNews tda = new LatestNews();

			DataTable dt = new DataTable();
			dt = HomeDeatilsService.GetHomeDeatils();
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				br.News_head1 = dt.Rows[i]["News_head"].ToString();

			}
			DataTable dt1 = new DataTable();
			dt1 = HomeDeatilsService.GetLatestNews();
			for (int i = 0; i < dt1.Rows.Count; i++)
			{
				tda = new LatestNews();
				tda.NT_head = dt1.Rows[i]["NT_head"].ToString();
				TData.Add(tda);

			}
			DataTable dt2 = new DataTable();
			dt2 = HomeDeatilsService.GetSportNews();
			for (int i = 0; i < dt2.Rows.Count; i++)
			{
				br.News_head1 = dt2.Rows[i]["NT_Head"].ToString();
				br.News_des = dt2.Rows[i]["N_Description"].ToString();
				br.News_image = dt2.Rows[i]["S_Image"].ToString();
				br.News_date = dt2.Rows[i]["AddedDateFormatted"].ToString();

			}
			DataTable dt3 = new DataTable();
			dt3 = HomeDeatilsService.GetHeadNews();
			for (int i = 0; i < dt3.Rows.Count; i++)
			{
				br.NT_head = dt3.Rows[i]["NT_head"].ToString();
				br.NT_date = dt3.Rows[i]["AddedDateFormatted"].ToString();

			}
			DataTable dt4 = new DataTable();
			dt4 = HomeDeatilsService.GetNewsLine();
			for (int i = 0; i < dt4.Rows.Count; i++)
			{
				br.News_head1 = dt4.Rows[i]["NT_Head"].ToString();
				br.News_des = dt4.Rows[i]["N_Description"].ToString();
				br.News_image = dt4.Rows[i]["S_Image"].ToString();
				br.News_date = dt4.Rows[i]["AddedDateFormatted"].ToString();

			}
			DataTable dt5 = new DataTable();
            dt5 = HomeDeatilsService.GetSportLine();
			List<Latestsports> TData1 = new List<Latestsports>();
			Latestsports tda1 = new Latestsports();
			for (int i = 0; i < dt5.Rows.Count; i++)
			{
				tda1 = new Latestsports();
				tda1.News_head1_s = dt5.Rows[i]["NT_Head"].ToString();
				tda1.News_des_s = dt5.Rows[i]["N_Description"].ToString();
				tda1.News_image_s = dt5.Rows[i]["S_Image"].ToString();
				tda1.News_date_s = dt5.Rows[i]["AddedDateFormatted"].ToString();
				tda1.N_id = dt5.Rows[i]["N_Id"].ToString();
				TData1.Add(tda1);
			}
			DataTable dt6 = new DataTable();
			dt6 = HomeDeatilsService.GetNewsFirstLine();
			List<NewsFirst> TData2 = new List<NewsFirst>();
			NewsFirst tda2 = new NewsFirst();
			for (int i = 0; i < dt6.Rows.Count; i++)
			{
				tda2 = new NewsFirst();
				tda2.News_head1_N = dt6.Rows[i]["NT_Head"].ToString();
				tda2.News_des_N = dt6.Rows[i]["N_Description"].ToString();
				tda2.News_image_N = dt6.Rows[i]["L_Image"].ToString();
				tda2.News_date_N = dt6.Rows[i]["AddedDateFormatted"].ToString();
				tda2.N_id = dt6.Rows[i]["N_Id"].ToString();
				TData2.Add(tda2);
			}
			br.NewsFirstlst = TData2;
			br.Latestslst = TData1;
			br.Latestlst = TData;
			return View(br);
		}
	}
}
