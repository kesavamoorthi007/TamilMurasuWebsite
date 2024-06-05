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
			SvSql = "select top 7 I_Id,News_head,Addeddate from TMImages_N  where I_cat='21' order by I_id desc";
			DataTable dtt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter(SvSql, _connectionString);
			SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
			adapter.Fill(dtt);
			return dtt;
		}
		public DataTable GetLatestNews()
		{
			string SvSql = string.Empty;
			SvSql = "select top 3 N_Id,C_Id,NT_Head from TMNews_N  where Highlights='1' order by N_Id Asc";
			DataTable dtt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter(SvSql, _connectionString);
			SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
			adapter.Fill(dtt);
			return dtt;
		}

		public DataTable GetSportNews()
		{
			string SvSql = string.Empty;
			SvSql = "select top 1 N_Id,C_Id,NT_Head,N_Description,S_Image,CONVERT(varchar, TMNews_N.AddedDate, 106) AS AddedDateFormatted from TMNews_N  where C_id='6' order by N_Id desc";
			DataTable dtt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter(SvSql, _connectionString);
			SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
			adapter.Fill(dtt);
			return dtt;
		}
		public DataTable GetHeadNews()
		{
			string SvSql = string.Empty;
			SvSql = "select top 1 N_Id,C_Id,NT_Head,N_Description,S_Image,CONVERT(varchar, TMNews_N.AddedDate, 106) AS AddedDateFormatted from TMNews_N  where editorpick='1' order by N_Id desc";
			DataTable dtt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter(SvSql, _connectionString);
			SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
			adapter.Fill(dtt);
			return dtt;
		}
		public DataTable GetNewsLine()
		{
			string SvSql = string.Empty;
			SvSql = "select top 15 N_Id,C_Id,NT_Head,N_Description,S_Image,CONVERT(varchar, TMNews_N.AddedDate, 106) AS AddedDateFormatted from TMNews_N  where editorpick='1' order by N_Id desc";
			DataTable dtt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter(SvSql, _connectionString);
			SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
			adapter.Fill(dtt);
			return dtt;
		}
        public DataTable GetSportLine()
        {
            string SvSql = string.Empty;
            SvSql = "select top 4 N_Id,C_Id,NT_Head,N_Description,S_Image,CONVERT(varchar, TMNews_N.AddedDate, 106) AS AddedDateFormatted from TMNews_N  where C_id='6' order by N_Id desc";
            DataTable dtt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(SvSql, _connectionString);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Fill(dtt);
            return dtt;
        }
		public DataTable GetNewsFirstLine()
		{
			string SvSql = string.Empty;
			SvSql = "select top 6 N_Id,C_Id,NT_Head,N_Description,L_Image,CONVERT(varchar, TMNews_N.AddedDate, 106) AS AddedDateFormatted from TMNews_N  where C_id='5' order by N_Id desc";
			DataTable dtt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter(SvSql, _connectionString);
			SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
			adapter.Fill(dtt);
			return dtt;
		}
	}
}
