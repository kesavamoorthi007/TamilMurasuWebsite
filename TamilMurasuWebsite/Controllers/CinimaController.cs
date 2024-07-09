using Microsoft.AspNetCore.Mvc;
using TamilMurasuWebsite.Interface;
using TamilMurasuWebsite.Models;
using TamilMurasuWebsite.Services;
using System.Data;
using DocumentFormat.OpenXml.Office2010.Excel;

namespace TamilMurasuWebsite.Controllers
{
	public class CinimaController : Controller
	{
		ICinimaService CinimaService;
		IConfiguration? _configuratio;
		private string? _connectionString;
		public CinimaController(ICinimaService _CinimaService, IConfiguration _configuratio)
		{
			CinimaService = _CinimaService;
			_connectionString = _configuratio.GetConnectionString("MySqlConnection");
		}
		public IActionResult Cinima()
		{
			Cinima br = new Cinima();

			List<CinimaList> TData = new List<CinimaList>();
			CinimaList tda = new CinimaList();

			DataTable dt1 = new DataTable();
			dt1 = CinimaService.GetCinima();
			for (int i = 0; i < dt1.Rows.Count; i++)
			{
				tda = new CinimaList();
				tda.News_head1 = dt1.Rows[i]["NT_Head"].ToString();
				tda.News_des = dt1.Rows[i]["N_Description"].ToString();
				tda.News_image = dt1.Rows[i]["S_Image"].ToString();
				tda.L_News_image = dt1.Rows[i]["L_Image"].ToString();
				tda.News_date = dt1.Rows[i]["AddedDateFormatted"].ToString();
				tda.N_id = dt1.Rows[i]["N_Id"].ToString();
				TData.Add(tda);

			}
			br.Cinimallst = TData;
			return View(br);
		}
		public IActionResult CinimaDeatils(string id)
		{
			Cinima br = new Cinima();

			List<CinimaDeatils> TData1 = new List<CinimaDeatils>();
			CinimaDeatils tda1 = new CinimaDeatils();

			DataTable dt2 = new DataTable();
			dt2 = CinimaService.GetCinimaDeatils(id);
			for (int i = 0; i < dt2.Rows.Count; i++)
			{
				tda1 = new CinimaDeatils();
				tda1.News_head1_d = dt2.Rows[i]["NT_Head"].ToString();
				tda1.News_des_d = dt2.Rows[i]["N_Description"].ToString();
				tda1.News_image_d = dt2.Rows[i]["S_Image"].ToString();
				tda1.L_News_image = dt2.Rows[i]["L_Image"].ToString();
				tda1.News_date_d = dt2.Rows[i]["AddedDateFormatted"].ToString();
				tda1.N_id_d = dt2.Rows[i]["N_Id"].ToString();
				TData1.Add(tda1);

			}
			br.CinimaDeatilslist = TData1; 
			return View(br);
		}
	}
}
