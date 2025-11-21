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

            List<SportNewsDeatils> TData1 = new List<SportNewsDeatils>();
            SportNewsDeatils tda1 = new SportNewsDeatils();
            DataTable dt2 = new DataTable();
			dt2 = SportNewsDetailService.GetSportNewsDeatils();
			for (int i = 0; i < dt2.Rows.Count; i++)
			{
                tda1.News_head1 = dt2.Rows[i]["NT_Head"].ToString();
                tda1.ID = dt2.Rows[i]["N_Id"].ToString();
                tda1.News_des = dt2.Rows[i]["N_Description"].ToString();
                tda1.News_image = dt2.Rows[i]["S_Image"].ToString();
                tda1.L_News_image = dt2.Rows[i]["L_Image"].ToString();
                tda1.News_date = dt2.Rows[i]["AddedDateFormatted"].ToString();
                TData1.Add(tda1);

            }
            br.SportNewsDeatilslst = TData1;
            return View(br);
		}
	}
}
