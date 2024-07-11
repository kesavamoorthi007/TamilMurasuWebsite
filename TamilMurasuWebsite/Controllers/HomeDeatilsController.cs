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


			DataTable dt = new DataTable();
			dt = HomeDeatilsService.GetHomeDeatils();
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				br.News_head1 = dt.Rows[i]["News_head"].ToString();

			}
			DataTable dt1 = new DataTable();
			dt1 = HomeDeatilsService.GetLatestNews();

			List<LatestNews> TData = new List<LatestNews>();
			LatestNews tda = new LatestNews();
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
				br.News_head1_sport = dt2.Rows[i]["NT_Head"].ToString();
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

			DataTable dt7 = new DataTable();
			dt7 = HomeDeatilsService.GetIndiaNews();

			List<IndiaNewsList> TData3 = new List<IndiaNewsList>();
			IndiaNewsList tda3 = new IndiaNewsList();
			for (int i = 0; i < dt7.Rows.Count; i++)
			{
				tda3 = new IndiaNewsList();
				tda3.NT_Head_i = dt7.Rows[i]["NT_Head"].ToString();
				tda3.N_Description_i = dt7.Rows[i]["N_Description"].ToString();
				tda3.S_Image_i = dt7.Rows[i]["S_Image"].ToString();
				tda3.L_Image_i = dt7.Rows[i]["L_Image"].ToString();
				tda3.date_i = dt7.Rows[i]["AddedDateFormatted"].ToString();
				tda3.N_id = dt7.Rows[i]["N_Id"].ToString();
				TData3.Add(tda3);
			}

			DataTable dt8 = new DataTable();
			dt8 = HomeDeatilsService.GetWorldNews();

			List<WorldNewsList> TData4 = new List<WorldNewsList>();
			WorldNewsList tda4 = new WorldNewsList();
			for (int i = 0; i < dt8.Rows.Count; i++)
			{
				tda4 = new WorldNewsList();
				tda4.NT_Head_w = dt8.Rows[i]["NT_Head"].ToString();
				tda4.N_Description_w = dt8.Rows[i]["N_Description"].ToString();
				tda4.S_Image_w = dt8.Rows[i]["S_Image"].ToString();
				tda4.L_Image_w = dt8.Rows[i]["L_Image"].ToString();
				tda4.date_w = dt8.Rows[i]["AddedDateFormatted"].ToString();
				tda4.N_id = dt8.Rows[i]["N_Id"].ToString();
				TData4.Add(tda4);
			}
			DataTable dt9 = new DataTable();
			dt9 = HomeDeatilsService.GetTopIndiaNews();
			for (int i = 0; i < dt9.Rows.Count; i++)
			{
				br.NT_Head_i = dt9.Rows[i]["NT_Head"].ToString();
				br.N_Description_i = dt9.Rows[i]["N_Description"].ToString();
				br.S_Image_i = dt9.Rows[i]["S_Image"].ToString();
				br.L_Image_i = dt9.Rows[i]["L_Image"].ToString();
				br.date_i = dt9.Rows[i]["AddedDateFormatted"].ToString();
				br.N_id = dt9.Rows[i]["N_Id"].ToString();

			}

			DataTable dt10 = new DataTable();
			dt10 = HomeDeatilsService.GetTopCinimaNews();
			for (int i = 0; i < dt10.Rows.Count; i++)
			{
				br.NT_Head_c = dt10.Rows[i]["NT_Head"].ToString();
				br.N_Description_c = dt10.Rows[i]["N_Description"].ToString();
				br.S_Image_c = dt10.Rows[i]["S_Image"].ToString();
				br.L_Image_c = dt10.Rows[i]["L_Image"].ToString();
				br.date_c = dt10.Rows[i]["AddedDateFormatted"].ToString();
				br.N_id = dt10.Rows[i]["N_Id"].ToString();

			}

			br.WorldNewsListlst = TData4;
			br.IndiaNewsListlst = TData3;
			br.NewsFirstlst = TData2;
			br.Latestslst = TData1;
			br.Latestlst = TData;
			return View(br);
		}
	}
}
