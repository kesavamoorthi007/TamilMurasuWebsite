using Microsoft.AspNetCore.Mvc;
using TamilMurasuWebsite.Interface;
using TamilMurasuWebsite.Models;
using TamilMurasuWebsite.Services;
using System.Data;

namespace TamilMurasuWebsite.Controllers
{
	public class AanmeegamController : Controller
	{
		IAanmeegamService AanmeegamService;
		IConfiguration? _configuratio;
		private string? _connectionString;
		public AanmeegamController(IAanmeegamService _AanmeegamService, IConfiguration _configuratio)
		{
			AanmeegamService = _AanmeegamService;
			_connectionString = _configuratio.GetConnectionString("MySqlConnection");
		}
		public IActionResult Aanmeegam()
		{
			Aanmeegam br = new Aanmeegam();

			List<AanmeegamList> TData = new List<AanmeegamList>();
			AanmeegamList tda = new AanmeegamList();

			DataTable dt1 = new DataTable();
			dt1 = AanmeegamService.GetAanmeegamService();
			for (int i = 0; i < dt1.Rows.Count; i++)
			{
				tda = new AanmeegamList();
				tda.News_head1 = dt1.Rows[i]["NT_Head"].ToString();
				tda.News_des = dt1.Rows[i]["N_Description"].ToString();
				tda.News_image = dt1.Rows[i]["S_Image"].ToString();
				tda.L_News_image = dt1.Rows[i]["L_Image"].ToString();
				tda.News_date = dt1.Rows[i]["AddedDateFormatted"].ToString();
				tda.N_id = dt1.Rows[i]["N_Id"].ToString();
				TData.Add(tda);

			}
			br.Aanmeegamlist = TData;
			return View(br);
		}
		public IActionResult AanmeegamDeatils(string id)
		{
			Aanmeegam br = new Aanmeegam();

			List<AanmeegamDeatilsList> TData1 = new List<AanmeegamDeatilsList>();
			AanmeegamDeatilsList tda1 = new AanmeegamDeatilsList();

			DataTable dt2 = new DataTable();
			dt2 = AanmeegamService.GetAanmeegamDeatils(id);
			for (int i = 0; i < dt2.Rows.Count; i++)
			{
				tda1 = new AanmeegamDeatilsList();
				tda1.News_head1_d = dt2.Rows[i]["NT_Head"].ToString();
				tda1.News_des_d = dt2.Rows[i]["N_Description"].ToString();
				tda1.News_image_d = dt2.Rows[i]["S_Image"].ToString();
				tda1.L_News_image = dt2.Rows[i]["L_Image"].ToString();
				tda1.News_date_d = dt2.Rows[i]["AddedDateFormatted"].ToString();
				tda1.N_id_d = dt2.Rows[i]["N_Id"].ToString();
				TData1.Add(tda1);

			}
			br.AanmeegamDeatilslist = TData1;
			return View(br);
		}
	}
}
