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
	public class HomeDeatilsService : IHomeDeatilsService
	{
		private readonly string _connectionString;
		public HomeDeatilsService(IConfiguration _configuratio)
		{
			_connectionString = _configuratio.GetConnectionString("MySqlConnection");
		}

		public DataTable GetHomeDeatils()
		{
			string SvSql = string.Empty;
			SvSql = "select top 10 I_Id,News_head,Addeddate from TMImages_N  where I_cat='21' order by I_id desc";
			DataTable dtt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter(SvSql, _connectionString);
			SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
			adapter.Fill(dtt);
			return dtt;
		}
	}
}
