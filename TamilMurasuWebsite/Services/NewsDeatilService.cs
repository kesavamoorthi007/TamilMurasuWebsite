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

namespace TamilMurasuWebsite.Services
{
	public class NewsDeatilService : INewsDeatilService
	{
		private readonly string _connectionString;
		public NewsDeatilService(IConfiguration _configuratio)
		{
			_connectionString = _configuratio.GetConnectionString("MySqlConnection");
		}
		public DataTable GetNewsDeatils()
		{
			string SvSql = string.Empty;
			SvSql = "select top 1 N_Id,C_Id,NT_Head,N_Description,S_Image,CONVERT(varchar, TMNews_N.AddedDate, 106) AS AddedDateFormatted from TMNews_N  where C_id='6' order by N_Id desc";
			DataTable dtt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter(SvSql, _connectionString);
			SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
			adapter.Fill(dtt);
			return dtt;
		}
	}
}
