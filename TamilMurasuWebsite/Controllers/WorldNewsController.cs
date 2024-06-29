using Microsoft.AspNetCore.Mvc;
using System.Data;
using TamilMurasuWebsite.Interface;
using TamilMurasuWebsite.Models;
using TamilMurasuWebsite.Services;

namespace TamilMurasuWebsite.Controllers
{
	public class WorldNewsController : Controller
	{
		IWorldNewsService WorldNewsService;
		IConfiguration? _configuratio;
		private string? _connectionString;
		public WorldNewsController(IWorldNewsService _WorldNewsService, IConfiguration _configuratio)
		{
			WorldNewsService = _WorldNewsService;
			_connectionString = _configuratio.GetConnectionString("MySqlConnection");
		}
		public IActionResult WorldNews()
		{
			WorldNews br = new WorldNews();

			List<World> TData = new List<World>();
			World tda = new World();

			DataTable dt1 = new DataTable();
			dt1 = WorldNewsService.GetWorldNews();
			for (int i = 0; i < dt1.Rows.Count; i++)
			{
				tda = new World();
				tda.News_head1 = dt1.Rows[i]["NT_Head"].ToString();
				tda.News_des = dt1.Rows[i]["N_Description"].ToString();
				tda.News_image = dt1.Rows[i]["S_Image"].ToString();
				tda.News_date = dt1.Rows[i]["AddedDateFormatted"].ToString();
				tda.N_id = dt1.Rows[i]["N_Id"].ToString();
				TData.Add(tda);

			}
			br.Worldlst = TData;
			return View(br);
		}
		public IActionResult WorldNewsDeatils(string id)
		{
			WorldNews br = new WorldNews();

			List<WorldDeatils> TData1 = new List<WorldDeatils>();
			WorldDeatils tda1 = new WorldDeatils();

			DataTable dt2 = new DataTable();
			dt2 = WorldNewsService.GetWorldNewsService(id);
			for (int i = 0; i < dt2.Rows.Count; i++)
			{
				tda1 = new WorldDeatils();
				tda1.News_head1_d = dt2.Rows[i]["NT_Head"].ToString();
				tda1.News_des_d = dt2.Rows[i]["N_Description"].ToString();
				tda1.News_image_d = dt2.Rows[i]["S_Image"].ToString();
				tda1.News_date_d = dt2.Rows[i]["AddedDateFormatted"].ToString();
				tda1.N_id_d = dt2.Rows[i]["N_Id"].ToString();
				TData1.Add(tda1);

			}
			br.WorldDeatilslist = TData1;
			return View(br);
		}
	}
}
