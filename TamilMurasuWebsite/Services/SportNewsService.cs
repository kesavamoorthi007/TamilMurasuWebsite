using TamilMurasuWebsite.Interface;
using TamilMurasuWebsite.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using DocumentFormat.OpenXml.Bibliography;
using System.Linq;
using System.Data.SqlClient;
using System.IO;
using DocumentFormat.OpenXml.Office2010.Excel;

namespace TamilMurasuWebsite.Services
{
	public class SportNewsService : ISportNewsService
	{
		private readonly string _connectionString;
		public SportNewsService(IConfiguration _configuratio)
		{
			_connectionString = _configuratio.GetConnectionString("MySqlConnection");
		}
		public DataTable GetSportNews()
		{
			string SvSql = string.Empty;
			SvSql = "select top 5 N_Id,C_Id,NT_Head,N_Description,S_Image,L_Image,CONVERT(varchar, TMNews_N.AddedDate, 106) AS AddedDateFormatted from TMNews_N  where C_id='6' and deletenews='Y'  order by N_Id desc";
			DataTable dtt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter(SvSql, _connectionString);
			SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
			adapter.Fill(dtt);
			return dtt;

		}
		public DataTable SportNewsDetails(string id)
		{
			string SvSql = string.Empty;
			SvSql = "select top 10 N_Id,C_Id,NT_Head,N_Description,S_Image,L_Image,CONVERT(varchar, TMNews_N.AddedDate, 106) AS AddedDateFormatted from TMNews_N  where C_id='6' and deletenews='Y' and N_Id='" + id +"'  order by N_Id desc";
			DataTable dtt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter(SvSql, _connectionString);
			SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
			adapter.Fill(dtt);
			return dtt;
		}
	}
}
