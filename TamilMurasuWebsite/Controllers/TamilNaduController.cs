using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using TamilMurasuWebsite.Interface;
using TamilMurasuWebsite.Models;
using TamilMurasuWebsite.Services;

namespace TamilMurasuWebsite.Controllers
{
	public class TamilNaduController : Controller
	{
		ITamilNaduService TamilNaduService;
		IConfiguration? _configuratio;
		private string? _connectionString;
		public TamilNaduController(ITamilNaduService _TamilNaduService, IConfiguration _configuratio)
		{
			TamilNaduService = _TamilNaduService;
			_connectionString = _configuratio.GetConnectionString("MySqlConnection");
		}
		public IActionResult TamilNadu()
		{
			TamilNadu br = new TamilNadu();

			List<Tamil> TData = new List<Tamil>();
			Tamil tda = new Tamil();

			DataTable dt1 = new DataTable();
			dt1 = TamilNaduService.GetTamilNadu();
			for (int i = 0; i < dt1.Rows.Count; i++)
			{
				tda = new Tamil();
				tda.News_head1 = dt1.Rows[i]["NT_Head"].ToString();
				tda.News_des = dt1.Rows[i]["N_Description"].ToString();
				tda.News_image = dt1.Rows[i]["S_Image"].ToString();
				tda.L_News_image = dt1.Rows[i]["L_Image"].ToString();
				tda.News_date = dt1.Rows[i]["AddedDateFormatted"].ToString();
				tda.N_id = dt1.Rows[i]["N_Id"].ToString();
				TData.Add(tda);

			}
			br.Tamillst = TData;
			return View(br);
		}
		public IActionResult TamilNaduDeatils(string id)
		{
			TamilNadu br = new TamilNadu();

			List<TamilDeatils> TData1 = new List<TamilDeatils>();
			TamilDeatils tda1 = new TamilDeatils();

			DataTable dt2 = new DataTable();
			dt2 = TamilNaduService.GetTamilNaduDeatils(id);
			for (int i = 0; i < dt2.Rows.Count; i++)
			{
				tda1 = new TamilDeatils();
				tda1.News_head1_d = dt2.Rows[i]["NT_Head"].ToString();
				tda1.News_des_d = dt2.Rows[i]["N_Description"].ToString();
				tda1.News_image_d = dt2.Rows[i]["S_Image"].ToString();
				tda1.L_News_image = dt2.Rows[i]["L_Image"].ToString();
				tda1.News_date_d = dt2.Rows[i]["AddedDateFormatted"].ToString();
				tda1.N_id_d = dt2.Rows[i]["N_Id"].ToString();
				TData1.Add(tda1);

			}
			br.TamilDeatilslist = TData1;
			return View(br);
		}
	}
}
